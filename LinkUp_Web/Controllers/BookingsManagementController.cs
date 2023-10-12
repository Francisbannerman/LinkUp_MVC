using LinkUp_Web.Models;
using LinkUp_Web.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace LinkUp_Web.Controllers;

//[Area("admin")]
public class BookingsManagementController : Controller
{
    private readonly IUnitOfWork _unitOfWork;

    public BookingsManagementController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    // GET
    public IActionResult Index()
    {
        List<BookingHeader> bookingHeaderObjList = _unitOfWork.BookingHeader.GetAll().ToList();
        return View(bookingHeaderObjList);
    }
    
    [HttpGet]
    public IActionResult GetAll()
    {
        List<BookingHeader> objBookingHeaders = _unitOfWork.BookingHeader.GetAll(includeProperties: "ApplicationUser").ToList();
        return Json(new { data = objBookingHeaders });
    }
}