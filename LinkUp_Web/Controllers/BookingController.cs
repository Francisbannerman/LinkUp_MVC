using LinkUp_Web.Models;
using LinkUp_Web.Models.ViewModels;
using LinkUp_Web.Repository.IRepository;
using LinkUp_Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace LinkUp_Web.Controllers;

// [Area("customer")]
// [Authorize]
public class BookingController : Controller
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly NotificationService _notificationService;
    private readonly GratisPointService _gratisPointService;
    private readonly CurrentPendingBookingService _currentPendingBookingService;
    private readonly GetUserIdService _getUserIdService;
    [BindProperty] public BookingVM BookingVM { get; set; }
    
    public BookingController(IUnitOfWork unitOfWork, NotificationService notificationService, 
        GratisPointService gratisPointService, CurrentPendingBookingService currentPendingBookingService,
        GetUserIdService getUserIdService)
    {
        _unitOfWork = unitOfWork;
        _notificationService = notificationService;
        _gratisPointService = gratisPointService;
        _currentPendingBookingService = currentPendingBookingService;
        _getUserIdService = getUserIdService;
    }

    // GET
    public IActionResult Index()
    {
        BookingVM = new()
        {
            BookingList = _currentPendingBookingService.GetCurrentUsersCurrentBookings(),
            BookingHeader = new()
        };
        foreach (var booking in _currentPendingBookingService.GetCurrentUsersCurrentBookings())
        {
            booking.price = GetPriceBasedNumberOfAttendees(booking);
            BookingVM.BookingHeader.orderTotal += booking.price;
        }
        return View(BookingVM);
    }

    private double GetPriceBasedNumberOfAttendees(Booking booking)
    {
        double finalPrice;
        if (booking.numberOfAttendees == 1)
        {
            finalPrice = booking.product.displayPrice;
        }
        else if (booking.numberOfAttendees == 2)
        {
            finalPrice = booking.product.displayPrice * 2;
        }
        else 
        {
            var indexForNumOfUsersEligibleForExtraPrice = (booking.numberOfAttendees - 2) * 0.5;
            var amountToPayForExtraUsers = booking.product.displayPrice * indexForNumOfUsersEligibleForExtraPrice;
            finalPrice = (booking.product.displayPrice * 2) + amountToPayForExtraUsers;
        }
        return finalPrice;
    }

    public IActionResult Plus(Guid bookingId)
    {
        var bookingFromDb = _unitOfWork.Booking.Get(u => u.ProductId == bookingId);
        bookingFromDb.numberOfAttendees = bookingFromDb.numberOfAttendees + 1;
        _unitOfWork.Booking.Update(bookingFromDb);
        _unitOfWork.Save();
        return RedirectToAction(nameof(Index));
    }

    public IActionResult Minus(Guid bookingId)
    {
        var bookingFromDb = _unitOfWork.Booking.Get(u => u.ProductId == bookingId);
        if (bookingFromDb.numberOfAttendees <= 1)
        {
            _unitOfWork.Booking.Remove(bookingFromDb);
        }
        else
        {
            bookingFromDb.numberOfAttendees -= 1;
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
        BookingVM = new()
        {
            BookingList = _currentPendingBookingService.GetCurrentUsersCurrentBookings(),
            BookingHeader = new()
        };
        BookingVM.BookingHeader.applicationUser = _unitOfWork.ApplicationUser.Get(u => u.Id == _getUserIdService.GetCurrentUserId());
        BookingVM.BookingHeader.name = BookingVM.BookingHeader.applicationUser.name;
        BookingVM.BookingHeader.phoneNumber = BookingVM.BookingHeader.applicationUser.PhoneNumber;
        BookingVM.BookingHeader.streetAddress = BookingVM.BookingHeader.applicationUser.streetAddress;
        BookingVM.BookingHeader.city = BookingVM.BookingHeader.applicationUser.city;
        BookingVM.BookingHeader.region = BookingVM.BookingHeader.applicationUser.region;
    
        foreach (var booking in _currentPendingBookingService.GetCurrentUsersCurrentBookings())
        {
            booking.price = GetPriceBasedNumberOfAttendees(booking);
            BookingVM.BookingHeader.orderTotal += booking.price;
        }
        return View(BookingVM);
    }
    
    [HttpPost]
    [ActionName("Summary")]
    public IActionResult SummaryPOST()
    {
        try
        {
            double userBalance = Convert.ToDouble(_gratisPointService.GetUserGratisPointBalance(_getUserIdService.GetCurrentUserId()));
            if (userBalance < BookingVM.BookingHeader.orderTotal)
            {
                // Handle insufficient funds (e.g., display an error message)
                return RedirectToAction("Index", "GratisPoint");
            }
            
            BookingVM.BookingHeader.applicationUserId = _getUserIdService.GetCurrentUserId();
            BookingVM.BookingHeader.dateBooked = DateTime.UtcNow;
            BookingVM.BookingHeader.orderStatus = "Pending Approval";
    
            foreach (var booking in _currentPendingBookingService.GetCurrentUsersCurrentBookings())
            {
                booking.price = GetPriceBasedNumberOfAttendees(booking);
                BookingVM.BookingHeader.orderTotal += booking.price;
                BookingVM.BookingHeader.bookingDateTime = booking.SelectedDateTime;
            }
            _unitOfWork.BookingHeader.Add(BookingVM.BookingHeader);

            foreach (var booking in _currentPendingBookingService.GetCurrentUsersCurrentBookings())
            {
                var temps = new BookedProduct
                {
                    id = Guid.NewGuid(),
                    applicationUserId = _getUserIdService.GetCurrentUserId(),
                    productId = booking.ProductId,
                    bookingHeaderId = BookingVM.BookingHeader.Id.ToString(),
                    numberOfAttendees = booking.numberOfAttendees,
                    productDateBooked = booking.SelectedDateTime
                };
                _unitOfWork.BookedProduct.Add(temps);
            }
            _gratisPointService.UpdateUserGratisPoints(_getUserIdService.GetCurrentUserId(),Convert.ToInt32(BookingVM.BookingHeader.orderTotal));
            var msg = $"{BookingVM.BookingHeader.orderTotal} has been deducted from your gratis account balance. " +
                      $"Your new gratis balance is {_gratisPointService.GetUserGratisPointBalance(_getUserIdService.GetCurrentUserId())}";
            _notificationService.AddNotification(msg,_getUserIdService.GetCurrentUserId());
            _unitOfWork.Save();
            return RedirectToAction(nameof(OrderConfirmation), new{id = BookingVM.BookingHeader.Id});
        }
        catch (Exception)
        {
            return View("Error");
        }
    }

    public IActionResult OrderConfirmation(Guid id)
    {
         BookingHeader bookingHeader =
             _unitOfWork.BookingHeader.Get(u => u.Id == id, includeProperties: "applicationUser");
         
         List<Booking> bookings = _unitOfWork.Booking
             .GetAll(u => u.applicationUserId == bookingHeader.applicationUserId).ToList();
         
         _unitOfWork.Booking.RemoveRange(bookings);
         _unitOfWork.ApplicationUser.BuyGratisPoints(_getUserIdService.GetCurrentUserId(),1);
         _unitOfWork.Save();
         return View();
    }
}