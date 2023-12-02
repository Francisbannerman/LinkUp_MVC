using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LinkUp_Web.Models;
using LinkUp_Web.Repository.IRepository;
using LinkUp_Web.Services;
using Microsoft.AspNetCore.Authorization;

namespace LinkUp_Web.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IUnitOfWork _unitOfWork;
    private readonly GetUserIdService _getUserIdService;

    public HomeController(ILogger<HomeController> logger, IUnitOfWork unitOfWork, 
        GetUserIdService getUserIdService)
    {
        _logger = logger;
        _unitOfWork = unitOfWork;
        _getUserIdService = getUserIdService;
    }

    public IActionResult Index()
    {
        IEnumerable<Product> productList = _unitOfWork.Product.GetAll(includeProperties: "category");
        return View(productList);
    }

    public IActionResult Details(Guid productId)
    {
        Booking book = new()
        {
            product = _unitOfWork.Product.Get(u => u.productId == productId, includeProperties: "category"),
            numberOfAttendees = 1,
            SelectedDateTime = DateTimeOffset.Now,
            ProductId = productId,
        };
        return View(book);
    }

    [HttpPost]
    // [Authorize]
    public IActionResult Details(Booking booking)
    {
        booking.applicationUserId = _getUserIdService.GetCurrentUserId();

        Booking bookingFromDb = _unitOfWork.Booking.
            Get(u => u.applicationUserId == _getUserIdService.GetCurrentUserId() && u.ProductId == booking.ProductId);
        if (bookingFromDb != null)
        {
            bookingFromDb.numberOfAttendees += booking.numberOfAttendees;
            _unitOfWork.Booking.Update(bookingFromDb);
        }
        else
        {
            _unitOfWork.Booking.Add(booking);
        }
        _unitOfWork.Save();

        return RedirectToAction(nameof(Index));
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}