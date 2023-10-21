using System.Security.Claims;
using LinkUp_Web.Models;
using LinkUp_Web.Models.ViewModels;
using LinkUp_Web.Repository.IRepository;
using LinkUp_Web.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Stripe.Checkout;

namespace LinkUp_Web.Controllers;

// [Area("customer")]
// [Authorize]
public class BookingController : Controller
{
    private readonly IUnitOfWork _unitOfWork;
    [BindProperty] public BookingVM BookingVM { get; set; }

    public BookingController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    // GET
    public IActionResult Index()
    {
        var claimsIdentity = (ClaimsIdentity)User.Identity;
        var userId = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier).Value;

        BookingVM = new()
        {
            BookingList = _unitOfWork.Booking.GetAll(u => u.applicationUserId == userId,
                includeProperties: "product"),
            BookingHeader = new()
        };
        foreach (var booking in BookingVM.BookingList)
        {
            booking.price = GetPriceBasedOnPlusOnes(booking);
            BookingVM.BookingHeader.orderTotal += booking.price;
        }

        return View(BookingVM);
    }

    private double GetPriceBasedOnPlusOnes(Booking booking)
    {
        if (booking.plusOne == 0)
        {
            return booking.product.displayPrice;
        }
        else
        {
            double temp1 = booking.plusOne * 0.5;
            double temp2 = booking.product.displayPrice * temp1;
            double finalPrice = booking.product.displayPrice + temp2;
            return finalPrice;
        }
    }

    public IActionResult Plus(Guid bookingId)
    {
        var bookingFromDb = _unitOfWork.Booking.Get(u => u.ProductId == bookingId);
        bookingFromDb.plusOne = bookingFromDb.plusOne + 1;
        _unitOfWork.Booking.Update(bookingFromDb);
        _unitOfWork.Save();
        return RedirectToAction(nameof(Index));
    }

    public IActionResult Minus(Guid bookingId)
    {
        var bookingFromDb = _unitOfWork.Booking.Get(u => u.ProductId == bookingId);
        if (bookingFromDb.plusOne <= 0)
        {
            _unitOfWork.Booking.Remove(bookingFromDb);
        }
        else
        {
            bookingFromDb.plusOne -= 1;
            _unitOfWork.Booking.Update(bookingFromDb);
        }

        _unitOfWork.Save();
        return RedirectToAction(nameof(Index));
    }

    public IActionResult Remove(Guid bookingId)
    {
        var bookingFromDb = _unitOfWork.Booking.Get(u => u.ProductId == bookingId);
        _unitOfWork.Booking.Remove(bookingFromDb);
        _unitOfWork.Save();
        return RedirectToAction(nameof(Index));
    }

    // public IActionResult Summary()
    // {
    //     var claimsIdentity = (ClaimsIdentity)User.Identity;
    //     var userId = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier).Value;
    //
    //     BookingVM = new()
    //     {
    //         BookingList = _unitOfWork.Booking.GetAll(u => u.applicationUserId == userId,
    //             includeProperties: "product"),
    //         BookingHeader = new()
    //     };
    //
    //     BookingVM.BookingHeader.applicationUser = _unitOfWork.ApplicationUser.Get(u => u.Id == userId);
    //     BookingVM.BookingHeader.name = BookingVM.BookingHeader.applicationUser.name;
    //     BookingVM.BookingHeader.phoneNumber = BookingVM.BookingHeader.applicationUser.PhoneNumber;
    //     BookingVM.BookingHeader.streetAddress = BookingVM.BookingHeader.applicationUser.streetAddress;
    //     BookingVM.BookingHeader.city = BookingVM.BookingHeader.applicationUser.city;
    //     BookingVM.BookingHeader.region = BookingVM.BookingHeader.applicationUser.region;
    //
    //     foreach (var booking in BookingVM.BookingList)
    //     {
    //         booking.price = GetPriceBasedOnPlusOnes(booking);
    //         BookingVM.BookingHeader.orderTotal += booking.price;
    //     }
    //
    //     return View(BookingVM);
    // }
    //
    // [HttpPost]
    //  [ActionName("Summary")]
    //  public IActionResult SummaryPOST()
    //  {
    //      var claimsIdentity = (ClaimsIdentity)User.Identity;
    //      var userId = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier).Value;
    //
    //      BookingVM.BookingList = _unitOfWork.Booking.GetAll(u => u.applicationUserId == userId,
    //          includeProperties: "product");
    //
    //      BookingVM.BookingHeader.dateBooked = System.DateTime.UtcNow;
    //      BookingVM.BookingHeader.applicationUserId = userId;
    //      ApplicationUser applicationUser = _unitOfWork.ApplicationUser.Get(u => u.Id == userId);
    //
    //      foreach (var booking in BookingVM.BookingList)
    //      {
    //          booking.price = GetPriceBasedOnPlusOnes(booking);
    //          BookingVM.BookingHeader.orderTotal += booking.price;
    //      }
    //      
    //      BookingVM.BookingHeader.paymentStatus = SD.PaymentStatusPending;
    //      BookingVM.BookingHeader.orderStatus = SD.StatusPending;
    //      _unitOfWork.BookingHeader.Add(BookingVM.BookingHeader);
    //      _unitOfWork.Save();
    //
    //      foreach (var cart in BookingVM.BookingList)
    //      {
    //          BookingDetail bookingDetail = new()
    //          {
    //              productId = cart.ProductId,
    //              BookingHeaderId = BookingVM.BookingHeader.Id,
    //              price = cart.price,
    //              plusOnes = cart.plusOne
    //          };
    //          _unitOfWork.BookingDetail.Add(bookingDetail);
    //          _unitOfWork.Save();
    //      }
    //      
    //      //payment logic
    //      var domain = "https://localhost:7010/";
    //      var options = new SessionCreateOptions
    //      {
    //          SuccessUrl = domain+ $"Booking/OrderConfirmation?id={BookingVM.BookingHeader.Id}",
    //          CancelUrl = domain+"Booking/index",
    //          LineItems = new List<SessionLineItemOptions>(),
    //          Mode = "payment",
    //      };
    //
    //      foreach (var item in BookingVM.BookingList)
    //      {
    //          var sessionLineItem = new SessionLineItemOptions
    //          {
    //              PriceData = new SessionLineItemPriceDataOptions
    //              {
    //                  UnitAmount = (long)(item.price * 100),
    //                  Currency = "usd",
    //                  ProductData = new SessionLineItemPriceDataProductDataOptions
    //                  {
    //                      Name = item.product.productTitle
    //                  }
    //              },
    //              Quantity = item.plusOne
    //          };
    //          options.LineItems.Add(sessionLineItem);
    //      }
    //          
    //      var service = new SessionService();
    //      Session session = service.Create(options);
    //      _unitOfWork.BookingHeader.UpdateStripePaymentID(BookingVM.BookingHeader.Id, session.Id, session.PaymentIntentId);
    //      _unitOfWork.Save();
    //
    //      Response.Headers.Add("Location", session.Url);
    //      return new StatusCodeResult(303);
    //  }
    //
    // public IActionResult OrderConfirmation(int id)
    // {
    //      BookingHeader bookingHeader =
    //          _unitOfWork.BookingHeader.Get(u => u.Id == id, includeProperties: "applicationUser");
    //     
    //      //an instant payment order
    //      var service = new SessionService();
    //      Session session = service.Get(bookingHeader.sessionId);
    //     
    //      if (session.PaymentStatus.ToLower() == "paid")
    //      {
    //          _unitOfWork.BookingHeader.UpdateStripePaymentID(id, session.Id, session.PaymentIntentId);
    //          _unitOfWork.BookingHeader.UpdateStatus(id, SD.StatusApproved, SD.PaymentStatusApproved);
    //          _unitOfWork.Save();
    //      }
    //      List<Booking> bookings = _unitOfWork.Booking
    //          .GetAll(u => u.applicationUserId == bookingHeader.applicationUserId).ToList();
    //     
    //      _unitOfWork.Booking.RemoveRange(bookings);
    //      _unitOfWork.Save();
    //
    //     return View(id);
    // }
}