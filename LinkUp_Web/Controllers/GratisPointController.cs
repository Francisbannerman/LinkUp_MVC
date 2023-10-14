using System.Security.Claims;
using LinkUp_Web.Models;
using LinkUp_Web.Repository.IRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

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
}