using System.Security.Claims;
using LinkUp_Web.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace LinkUp_Web.Controllers;

public class ReferralCodeController : Controller
{
    private readonly IUnitOfWork _unitOfWork;
    public ReferralCodeController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    
    // GET
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult RequestReferralCode()
    {
        var claimsIdentity = (ClaimsIdentity)User.Identity;
        var userId = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier).Value;
        var userColumn = _unitOfWork.ApplicationUser.Get(u => u.Id == userId);
        
        return Content(userColumn.referralCode);
    }
}