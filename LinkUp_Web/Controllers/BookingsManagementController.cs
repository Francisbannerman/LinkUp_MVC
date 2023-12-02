using LinkUp_Web.Models;
using LinkUp_Web.Models.ViewModels;
using LinkUp_Web.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using LinkUp_Web.Services;


namespace LinkUp_Web.Controllers;

//[Area("admin")]
public class BookingsManagementController : Controller
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly NotificationService _notificationService;
    
    public BookingsManagementController(IUnitOfWork unitOfWork, 
        NotificationService notificationService)
    {
        _unitOfWork = unitOfWork;
        _notificationService = notificationService;
    }
    
    public IActionResult Index()
    {
        List<BookingHeader> bookingHeaders = _unitOfWork.BookingHeader.GetAll().ToList();
        List<Product> products = _unitOfWork.Product.GetAll().ToList();
        List<BookedProduct> bookedProducts = _unitOfWork.BookedProduct.GetAll().ToList();

        var result = from bookedProduct in bookedProducts
            join product in products on bookedProduct.productId equals product.productId
            join bookingHeader in bookingHeaders on Guid.Parse(bookedProduct.bookingHeaderId) equals bookingHeader.Id
            group product.productId by bookingHeader.Id into grouped
            select new ResultItem
            {
                BookingHeaderId = grouped.Key,
                ProductName = grouped.Select(productId => products.First(p => p.productId == productId).productTitle).ToList(),
                ProductIds = grouped.ToList()
            };
        var viewModel = new OrderManagementVM
        {
            BookingHeaderList = bookingHeaders,
            ProductList = products,
            BookedProductList = bookedProducts,
            Result = result.ToList()
        };
        return View(viewModel);
    }

    public IActionResult BookingManagement(Guid? id, string bookedProductIds)
    {
        if (id == null || string.IsNullOrEmpty(bookedProductIds))
        {
            return NotFound();
        }
        var bookingHeader = _unitOfWork.BookingHeader.Get(u => u.Id == id);
        List<Guid> bookedproductIdList = bookedProductIds.Split(',').Select(Guid.Parse).ToList();
        Dictionary<Guid, int> numberOfUsersMap = new Dictionary<Guid, int>();
        
        List<BookedProduct> bookedProductdetails = new List<BookedProduct>();
        List<Guid> productIds = new List<Guid>();
        foreach (var bookedProductId in bookedproductIdList)
        {
            var temp = _unitOfWork.BookedProduct.Get(u => u.id == bookedProductId);
            bookedProductdetails.Add(temp);
            productIds.Add(temp.productId);
            numberOfUsersMap[temp.productId] = temp.numberOfAttendees;
        }
        
        List<Product> bookedProducts = new List<Product>();
        foreach (var productId in productIds)
        {
            var temp = _unitOfWork.Product.Get(u => u.productId == productId);
            bookedProducts.Add(temp);
        }

        var viewModel = new OrderManagementVM
        {
            BookingHeader = bookingHeader,
            ProductList = bookedProducts,
            BookedProductList = bookedProductdetails,
            NumberOfUsersMap = numberOfUsersMap
        };
        return View(viewModel);
    }
    
    [HttpPost, ActionName("BookingManagement")]
    public IActionResult BookingManagementPost(BookingHeader bookingHeader)
    {
        if (ModelState.IsValid)
        {
            _unitOfWork.BookingHeader.Update(bookingHeader);
            _notificationService.ProcessingNotification(bookingHeader);
            _unitOfWork.Save();
            return RedirectToAction("Index");
        }
        else
        {
            return View();
        }
    }

    public IActionResult Details(Guid productId, DateTimeOffset dateBooked, int numberOfUsers)
    {
        Booking book = new()
        {
            product = _unitOfWork.Product.Get(u => u.productId == productId, includeProperties: "category"),
            numberOfAttendees = numberOfUsers,
            SelectedDateTime = dateBooked,
            ProductId = productId,
        };
        return View(book);
    }
}