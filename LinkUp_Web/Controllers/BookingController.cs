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
            BookingList = _unitOfWork.Booking.GetAll(u => u.ApplicationUserId == userId,
                includeProperties: "Product"),
            BookingHeader = new()
        };
        foreach (var booking in BookingVM.BookingList)
        {
            booking.Price = GetPriceBasedOnPlusOnes(booking);
            BookingVM.BookingHeader.OrderTotal += booking.Price;
        }

        return View(BookingVM);
    }

    private double GetPriceBasedOnPlusOnes(Booking booking)
    {
        if (booking.Count == 0)
        {
            return booking.Product.DisplayPrice;
        }
        else
        {
            double temp1 = booking.Count * 0.5;
            double temp2 = booking.Product.DisplayPrice * temp1;
            double finalPrice = booking.Product.DisplayPrice + temp2;
            booking.Product.DisplayPrice = finalPrice;
            return booking.Product.DisplayPrice;
        }
    }

    public IActionResult Plus(Guid bookingId)
    {
        var bookingFromDb = _unitOfWork.Booking.Get(u => u.ProductId == bookingId);
        bookingFromDb.Count = bookingFromDb.Count + 1;
        _unitOfWork.Booking.Update(bookingFromDb);
        _unitOfWork.Save();
        return RedirectToAction(nameof(Index));
    }

    public IActionResult Minus(Guid bookingId)
    {
        var bookingFromDb = _unitOfWork.Booking.Get(u => u.ProductId == bookingId);
        if (bookingFromDb.Count <= 0)
        {
            _unitOfWork.Booking.Remove(bookingFromDb);
        }
        else
        {
            bookingFromDb.Count -= 1;
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

    public IActionResult Summary()
    {
        var claimsIdentity = (ClaimsIdentity)User.Identity;
        var userId = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier).Value;

        BookingVM = new()
        {
            BookingList = _unitOfWork.Booking.GetAll(u => u.ApplicationUserId == userId,
                includeProperties: "Product"),
            BookingHeader = new()
        };

        BookingVM.BookingHeader.ApplicationUser = _unitOfWork.ApplicationUser.Get(u => u.Id == userId);
        BookingVM.BookingHeader.Name = BookingVM.BookingHeader.ApplicationUser.Name;
        BookingVM.BookingHeader.PhoneNumber = BookingVM.BookingHeader.ApplicationUser.PhoneNumber;
        BookingVM.BookingHeader.StreetAddress = BookingVM.BookingHeader.ApplicationUser.StreetAddress;
        BookingVM.BookingHeader.City = BookingVM.BookingHeader.ApplicationUser.City;
        BookingVM.BookingHeader.Region = BookingVM.BookingHeader.ApplicationUser.Region;

        foreach (var booking in BookingVM.BookingList)
        {
            booking.Price = GetPriceBasedOnPlusOnes(booking);
            BookingVM.BookingHeader.OrderTotal += booking.Price;
        }

        return View(BookingVM);
    }
    
    [HttpPost]
     [ActionName("Summary")]
     public IActionResult SummaryPOST()
     {
         var claimsIdentity = (ClaimsIdentity)User.Identity;
         var userId = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier).Value;
    
         BookingVM.BookingList = _unitOfWork.Booking.GetAll(u => u.ApplicationUserId == userId,
             includeProperties: "Product");
    
         BookingVM.BookingHeader.DateBooked = System.DateTime.UtcNow;
         BookingVM.BookingHeader.ApplicationUserId = userId;
         ApplicationUser applicationUser = _unitOfWork.ApplicationUser.Get(u => u.Id == userId);
    
         foreach (var booking in BookingVM.BookingList)
         {
             booking.Price = GetPriceBasedOnPlusOnes(booking);
             BookingVM.BookingHeader.OrderTotal += booking.Price;
         }
    
         if (applicationUser.CompanyId.GetValueOrDefault() == 0)
         {
             BookingVM.BookingHeader.PaymentStatus = SD.PaymentStatusPending;
             BookingVM.BookingHeader.OrderStatus = SD.StatusPending;
         }
         else
         {
             //delayed  payment implementation.
             BookingVM.BookingHeader.PaymentStatus = SD.PaymentStatusDelayedPayment;
             BookingVM.BookingHeader.OrderStatus = SD.StatusApproved;
         }
         _unitOfWork.BookingHeader.Add(BookingVM.BookingHeader);
         _unitOfWork.Save();
    
         foreach (var cart in BookingVM.BookingList)
         {
             BookingDetail bookingDetail = new()
             {
                 ProductId = cart.ProductId,
                 BookingHeaderId = BookingVM.BookingHeader.Id,
                 Price = cart.Price,
                 Count = cart.Count
             };
             _unitOfWork.BookingDetail.Add(bookingDetail);
             _unitOfWork.Save();
         }
         
         if (applicationUser.CompanyId.GetValueOrDefault() == 0)
         {
             //payment logic
             var domain = "https://localhost:7010/";
             var options = new SessionCreateOptions
             {
                 SuccessUrl = domain+ $"Booking/OrderConfirmation?id={BookingVM.BookingHeader.Id}",
                 CancelUrl = domain+"Booking/index",
                 LineItems = new List<SessionLineItemOptions>(),
                 Mode = "payment",
             };
             
             foreach (var item in BookingVM.BookingList)
             {
                 var sessionLineItem = new SessionLineItemOptions
                 {
                     PriceData = new SessionLineItemPriceDataOptions
                     {
                         UnitAmount = (long)(item.Price * 100),
                         Currency = "usd",
                         ProductData = new SessionLineItemPriceDataProductDataOptions
                         {
                             Name = item.Product.productTitle
                         }
                     },
                     Quantity = item.Count
                 };
                 options.LineItems.Add(sessionLineItem);
             }
             
             var service = new SessionService();
             Session session = service.Create(options);
             _unitOfWork.BookingHeader.UpdateStripePaymentID(BookingVM.BookingHeader.Id, session.Id, session.PaymentIntentId);
             _unitOfWork.Save();
    
             Response.Headers.Add("Location", session.Url);
             return new StatusCodeResult(303);
         }
         return RedirectToAction(nameof(OrderConfirmation), new { id = BookingVM.BookingHeader.Id });
     }
    
    public IActionResult OrderConfirmation(int id)
    {
         BookingHeader bookingHeader =
             _unitOfWork.BookingHeader.Get(u => u.Id == id, includeProperties: "ApplicationUser");
        
         if (bookingHeader.PaymentStatus != SD.PaymentStatusDelayedPayment)
         {
             //an instant payment order
             var service = new SessionService();
             Session session = service.Get(bookingHeader.SessionId);
        
             if (session.PaymentStatus.ToLower() == "paid")
             {
                 _unitOfWork.BookingHeader.UpdateStripePaymentID(id, session.Id, session.PaymentIntentId);
                 _unitOfWork.BookingHeader.UpdateStatus(id, SD.StatusApproved, SD.PaymentStatusApproved);
                 _unitOfWork.Save();
             }
         }
        
         List<Booking> bookings = _unitOfWork.Booking
             .GetAll(u => u.ApplicationUserId == bookingHeader.ApplicationUserId).ToList();
        
         _unitOfWork.Booking.RemoveRange(bookings);
         _unitOfWork.Save();

        return View(id);
    }
}