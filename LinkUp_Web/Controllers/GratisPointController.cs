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
public class GratisPointController : Controller
{
    private readonly IUnitOfWork _unitOfWork;

    public GratisPointController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    // GET
    public IActionResult Index()
    {
        var claimsIdentity = (ClaimsIdentity)User.Identity;
        var userId = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier).Value;

        var applicationUser = _unitOfWork.ApplicationUser.Get(u => u.Id == userId);
        
        return View(applicationUser);
    }

    public IActionResult GratisPackagesAvailableToBeBought()
    {
        var gratisPackages = _unitOfWork.GratisPointPackages.GetAll().ToList();

        return View(gratisPackages);
    }

    public IActionResult Summary(int? id)
    {
        GratisPointPackages? gratisPointPackagesFromDb =
            _unitOfWork.GratisPointPackages.Get(u => u.gratisPointPackagesId == id);
        
        return View(gratisPointPackagesFromDb);
    }
    
    [HttpPost]
     [ActionName("Summary")]
     public IActionResult SummaryPOST(int id)
     {
         var gratisPurchaseId = 0;
         var claimsIdentity = (ClaimsIdentity)User.Identity;
         var userId = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier).Value;

         var gratisPointPackages = _unitOfWork.GratisPointPackages.Get(u => u.gratisPointPackagesId == id);

         if (_unitOfWork.GratisPurchase.Count() == 0)
         {
             gratisPurchaseId = 1;
         }
         else
         {
             gratisPurchaseId = _unitOfWork.GratisPurchase.Max(u => u.gratisPurchaseId) + 1;
         }

         var gratisPurchase = new GratisPurchase
         {
             gratisPurchaseId = gratisPurchaseId,
             gratisPointQuantity = gratisPointPackages.gratisPointQuantity,
             amountForGratisPoint = gratisPointPackages.AmountForGratisPoint,
             datePurchased = DateTimeOffset.UtcNow,
             paymentStatus = SD.PaymentStatusPending,
             applicationUser = userId
         };
         _unitOfWork.GratisPurchase.Add(gratisPurchase);
         _unitOfWork.Save();

         var domain = "https://localhost:7010/";
         var successURL = $"{domain}GratisPoint/OrderConfirmation?id={gratisPurchaseId}";
         var cancelURL = $"{domain}GratisPoint/index";
         var options = new SessionCreateOptions
         {
             SuccessUrl = successURL,
             CancelUrl = cancelURL,
             LineItems = new List<SessionLineItemOptions>(),
             Mode = "payment",
         };
         var sessionLineItem = new SessionLineItemOptions
         {
             PriceData = new SessionLineItemPriceDataOptions
             {
                 UnitAmount = (long)(gratisPointPackages.AmountForGratisPoint * 100),
                 Currency = "usd",
                 ProductData = new SessionLineItemPriceDataProductDataOptions
                 {
                     Name = gratisPointPackages.gratisPointQuantity.ToString()
                 }
             },
             Quantity = 1
         };
         options.LineItems.Add(sessionLineItem);
         
         var service = new SessionService();
         Session session = service.Create(options);
         _unitOfWork.GratisPurchase.UpdateStripePaymentID(gratisPurchaseId, session.Id, session.PaymentIntentId);
         _unitOfWork.Save();
    
         Response.Headers.Add("Location", session.Url);
         return new StatusCodeResult(303);
     }
    
    public IActionResult OrderConfirmation(int id)
    {
        var claimsIdentity = (ClaimsIdentity)User.Identity;
        var userId = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier).Value;
        
        GratisPurchase gratisPurchase = _unitOfWork.GratisPurchase.Get(u => u.gratisPurchaseId == id);
        
         var service = new SessionService();
         Session session = service.Get(gratisPurchase.sessionId);
        
         if (session.PaymentStatus.ToLower() == "paid")
         {
             _unitOfWork.GratisPurchase.UpdateStripePaymentID(id, session.Id, session.PaymentIntentId);
             _unitOfWork.GratisPurchase.UpdateStatus(id, SD.StatusApproved, SD.PaymentStatusApproved);
             _unitOfWork.ApplicationUser.BuyGratisPoints(userId,gratisPurchase.gratisPointQuantity);
             
             _unitOfWork.Save();
         }
         _unitOfWork.Save();
         return View(id);
    }
}