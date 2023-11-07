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

    public IActionResult Summary()
    {
        var claimsIdentity = (ClaimsIdentity)User.Identity;
        var userId = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier).Value;
    
        BookingVM = new()
        {
            BookingList = _unitOfWork.Booking.GetAll(u => u.applicationUserId == userId,
                includeProperties: "product"),
            BookingHeader = new()
        };
    
        BookingVM.BookingHeader.applicationUser = _unitOfWork.ApplicationUser.Get(u => u.Id == userId);
        
        BookingVM.BookingHeader.name = BookingVM.BookingHeader.applicationUser.name;
        BookingVM.BookingHeader.phoneNumber = BookingVM.BookingHeader.applicationUser.PhoneNumber;
        BookingVM.BookingHeader.streetAddress = BookingVM.BookingHeader.applicationUser.streetAddress;
        BookingVM.BookingHeader.city = BookingVM.BookingHeader.applicationUser.city;
        BookingVM.BookingHeader.region = BookingVM.BookingHeader.applicationUser.region;
    
        foreach (var booking in BookingVM.BookingList)
        {
            booking.price = GetPriceBasedOnPlusOnes(booking);
            BookingVM.BookingHeader.orderTotal += booking.price;
        }
    
        return View(BookingVM);
    }
    
    // [HttpPost]
    //  [ActionName("Summary")]
     // public IActionResult SummaryPOST()
     // {
     //     var claimsIdentity = (ClaimsIdentity)User.Identity;
     //     var userId = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier).Value;
     //
     //     BookingVM.BookingList = _unitOfWork.Booking.
     //         GetAll(u => u.applicationUserId == userId, includeProperties: "product");
     //
     //     BookingVM.BookingHeader.applicationUserId = userId;
     //     BookingVM.BookingHeader.dateBooked = DateTime.UtcNow;
     //     //come and change this later to what customer actually booked for TODO
     //     BookingVM.BookingHeader.bookingDateTime = DateTime.UtcNow;
     //
     //     foreach (var booking in BookingVM.BookingList)
     //     {
     //         booking.price = GetPriceBasedOnPlusOnes(booking);
     //         BookingVM.BookingHeader.orderTotal += booking.price;
     //     }
     //     //come and change this later to what customer actually booked for TODO
     //     BookingVM.BookingHeader.paymentDate = DateTime.UtcNow;
     //     _unitOfWork.BookingHeader.Add(BookingVM.BookingHeader);
     //     _unitOfWork.Save();
     //     
     //     var usersCurrentGratisPointBalance = Convert.ToDouble(_unitOfWork.ApplicationUser.
     //         Get(u => u.Id == userId).gratisPoint);
     //
     //     var totalBookingPrice = BookingVM.BookingHeader.orderTotal;
     //
     //     if (usersCurrentGratisPointBalance < totalBookingPrice)
     //     {
     //         return View();
     //     }
     //     else
     //     {
     //         usersCurrentGratisPointBalance -= totalBookingPrice;
     //         _unitOfWork.ApplicationUser.UpdateGratisPoints(userId, Convert.ToInt32(usersCurrentGratisPointBalance));
     //     }
     //     return RedirectToAction(nameof(OrderConfirmation));
     // }
     
     
    [HttpPost]
    [ActionName("Summary")]
    public IActionResult SummaryPOST()
    {
        try
        {
            var userId = GetCurrentUserId();
            
            BookingVM.BookingList = _unitOfWork.Booking.
                GetAll(u => u.applicationUserId == userId, includeProperties: "product");

            BookingVM.BookingHeader.applicationUserId = userId;
            BookingVM.BookingHeader.dateBooked = DateTime.UtcNow;
            //come and change this later to what customer actually booked for TODO
            BookingVM.BookingHeader.bookingDateTime = DateTime.UtcNow;

            foreach (var booking in BookingVM.BookingList)
            {
                booking.price = GetPriceBasedOnPlusOnes(booking);
                BookingVM.BookingHeader.orderTotal += booking.price;
            }
            //come and change this later to what customer actually booked for TODO
            BookingVM.BookingHeader.paymentDate = DateTime.UtcNow;
            _unitOfWork.BookingHeader.Add(BookingVM.BookingHeader);
            _unitOfWork.Save();
    
            var usersCurrentGratisPointBalance = Convert.ToDouble(GetUserGratisPointBalance(userId));
    
            var totalBookingPrice = BookingVM.BookingHeader.orderTotal;
    
            if (usersCurrentGratisPointBalance < totalBookingPrice)
            {
                // Handle insufficient funds (e.g., display an error message)
                return RedirectToAction(nameof(Index));
            }
            UpdateUserGratisPoints(userId, Convert.ToInt32(BookingVM.BookingHeader.orderTotal));
            
            return RedirectToAction(nameof(OrderConfirmation), new{id = BookingVM.BookingHeader.Id});
        }
        catch (Exception ex)
        {
            // Handle exceptions or errors appropriately
            // Log the exception for debugging
            // Redirect to an error page or display an error message
            return View("Error");
        }
    }

    private string GetCurrentUserId()
    {
        var claimsIdentity = (ClaimsIdentity)User.Identity;
        return claimsIdentity.FindFirst(ClaimTypes.NameIdentifier).Value;
    }
    private decimal GetUserGratisPointBalance(string userId)
    {
        var user = _unitOfWork.ApplicationUser.Get(u => u.Id == userId);
        return Convert.ToDecimal(user.gratisPoint);
    }
    private void UpdateUserGratisPoints(string userId, int newPointBalance)
    {
        _unitOfWork.ApplicationUser.SpendGratisPoints(userId, Convert.ToInt32(newPointBalance));
        _unitOfWork.Save();
    }

    
    public IActionResult OrderConfirmation(int id)
    {
         BookingHeader bookingHeader =
             _unitOfWork.BookingHeader.Get(u => u.Id == id, includeProperties: "applicationUser");
         
         List<Booking> bookings = _unitOfWork.Booking
             .GetAll(u => u.applicationUserId == bookingHeader.applicationUserId).ToList();

         _unitOfWork.Booking.RemoveRange(bookings);
         _unitOfWork.ApplicationUser.BuyGratisPoints(GetCurrentUserId(),1);
         _unitOfWork.Save();
    
        return View(id);
    }
}