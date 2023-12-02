using LinkUp_Web.Repository.IRepository;
using LinkUp_Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace LinkUp_Web.Controllers;

public class ReferralCodeController : Controller
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly GetUserIdService _getUserIdService;
    public ReferralCodeController(IUnitOfWork unitOfWork, GetUserIdService getUserIdService)
    {
        _unitOfWork = unitOfWork;
        _getUserIdService = getUserIdService;
    }
    
    // GET
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult RequestReferralCode()
    {
        var userColumn = _unitOfWork.ApplicationUser.Get(u => u.Id == _getUserIdService.GetCurrentUserId());
        return Content(userColumn.referralCode);
    }
}