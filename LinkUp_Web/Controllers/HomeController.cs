using System.Diagnostics;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using LinkUp_Web.Models;
using LinkUp_Web.Repository.IRepository;
using Microsoft.AspNetCore.Authorization;

namespace LinkUp_Web.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IUnitOfWork _unitOfWork;

    public HomeController(ILogger<HomeController> logger, IUnitOfWork unitOfWork)
    {
        _logger = logger;
        _unitOfWork = unitOfWork;
    }

    public IActionResult Index()
    {
        //IEnumerable<Product> productList = _unitOfWork.Product.GetAll();
        IEnumerable<Product> productList = _unitOfWork.Product.GetAll(includeProperties: "category");
        return View(productList);
    }

    public IActionResult Details(Guid productId)
    {
        Booking book = new()
        {
            product = _unitOfWork.Product.Get(u => u.productId == productId, includeProperties: "category"),
            plusOne = 0,
            ProductId = productId
        };
        return View(book);
    }

    [HttpPost]
    // [Authorize]
    public IActionResult Details(Booking booking)
    {
        var claimsIdentity = (ClaimsIdentity)User.Identity;
        var userId = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier).Value;
        booking.applicationUserId = userId;

        Booking bookingFromDb = _unitOfWork.Booking.Get(u => u.applicationUserId == userId && u.ProductId == booking.ProductId);
        if (bookingFromDb != null)
        {
            bookingFromDb.plusOne += booking.plusOne;
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