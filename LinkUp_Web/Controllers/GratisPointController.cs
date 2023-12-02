using LinkUp_Web.Models;
using LinkUp_Web.Repository.IRepository;
using LinkUp_Web.Services;
using LinkUp_Web.Services.IServices;
using LinkUp_Web.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Stripe.Checkout;

namespace LinkUp_Web.Controllers;

// [Area("customer")]
// [Authorize]
public class GratisPointController : Controller
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly NotificationService _notificationService;
    private readonly IPaymentServices _paymentService;
    private readonly GetUserIdService _getUserIdService;

    public GratisPointController(IUnitOfWork unitOfWork, NotificationService notificationService, 
        IPaymentServices paymentService, GetUserIdService getUserIdService)
    {
        _unitOfWork = unitOfWork;
        _notificationService = notificationService;
        _paymentService = paymentService;
        _getUserIdService = getUserIdService;
    }
    // GE
    public IActionResult Index()
    {
        var applicationUser = _unitOfWork.ApplicationUser.Get(u => u.Id == _getUserIdService.GetCurrentUserId());
        
        return View(applicationUser);
    }

    public IActionResult GratisPackagesAvailableToBeBought()
    {
        var gratisPackages = _unitOfWork.GratisPointPackages.GetAll().ToList();

        return View(gratisPackages);
    }

    public IActionResult Summary(Guid? id)
    {
        GratisPointPackages? gratisPointPackagesFromDb =
            _unitOfWork.GratisPointPackages.Get(u => u.gratisPointPackagesId == id);
        
        return View(gratisPointPackagesFromDb);
    }
    
    [HttpPost]
     [ActionName("Summary")]
     public IActionResult SummaryPOST(Guid id)
     {
         var gratisPointPackages = _unitOfWork.GratisPointPackages.Get(u => u.gratisPointPackagesId == id);

         var gratisPurchase = new GratisPurchase
         {
             gratisPurchaseId = Guid.NewGuid(),
             gratisPointQuantity = gratisPointPackages.gratisPointQuantity,
             amountForGratisPoint = gratisPointPackages.AmountForGratisPoint,
             datePurchased = DateTimeOffset.UtcNow,
             paymentStatus = SD.PaymentStatusPending,
             applicationUser = _getUserIdService.GetCurrentUserId()
         };
         _unitOfWork.GratisPurchase.Add(gratisPurchase);
         _unitOfWork.Save();
         
         var sessionUrl = _paymentService.stripePayment(gratisPointPackages, gratisPurchase);
    
         Response.Headers.Add("Location", sessionUrl);
         return new StatusCodeResult(303);
     }
    
    public IActionResult OrderConfirmation(Guid id)
    {
        GratisPurchase gratisPurchase = _unitOfWork.GratisPurchase.Get(u => u.gratisPurchaseId == id);
        
        var newBalance = _unitOfWork.ApplicationUser.Get(u => u.Id == _getUserIdService.GetCurrentUserId()).gratisPoint +
                         gratisPurchase.gratisPointQuantity;
        var msg = $"Your Account Has Been Credited with {gratisPurchase.gratisPointQuantity} " 
                  + $"Gratis Points. Your New Gratis Point Account Balance is {newBalance} ";
        
        var service = new SessionService();
         Session session = service.Get(gratisPurchase.sessionId);
        
         if (session.PaymentStatus.ToLower() == "paid")
         {
             _unitOfWork.GratisPurchase.UpdateStripePaymentID(id, session.Id, session.PaymentIntentId);
             _unitOfWork.GratisPurchase.UpdateStatus(id, SD.StatusApproved, SD.PaymentStatusApproved);
             _unitOfWork.ApplicationUser.BuyGratisPoints(_getUserIdService.GetCurrentUserId(),gratisPurchase.gratisPointQuantity);
             _notificationService.AddNotification(msg,_getUserIdService.GetCurrentUserId());
             _unitOfWork.Save();
         }
         _unitOfWork.Save();
         return View(id);
    }
}