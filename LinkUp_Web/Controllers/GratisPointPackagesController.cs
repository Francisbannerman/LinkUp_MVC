using System.Security.Claims;
using LinkUp_Web.Models;
using LinkUp_Web.Repository.IRepository;
using LinkUp_Web.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LinkUp_Web.Controllers;

// [Authorize(Roles = SD.Role_Admin)]
// [Authorize(Roles = SD.Role_Company)]
public class GratisPointPackagesController : Controller
{
    private readonly IUnitOfWork _unitOfWork;

    public GratisPointPackagesController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    
    // GET
    public IActionResult Index()
    {
        List<GratisPointPackages> gratisPointPackagesFromDb = _unitOfWork.GratisPointPackages.GetAll().ToList();
        return View(gratisPointPackagesFromDb);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(GratisPointPackages obj)
    {
        var maxId = _unitOfWork.GratisPointPackages.Max(u => u.gratisPointPackagesId);
        maxId = maxId + 1;
        obj.gratisPointPackagesId = maxId;
        
        var claimsIdentity = (ClaimsIdentity)User.Identity;
        var userId = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier).Value;
        
        obj.dateAdded = DateTimeOffset.Now;
        obj.addedByWho = userId;

        if (ModelState.IsValid)
        {
            _unitOfWork.GratisPointPackages.Add(obj);
            _unitOfWork.Save();
            return RedirectToAction("Index");
        }
        return View();
    }

    public IActionResult Edit(int? id)
    {
        if (id == null || id == 0)
        {
            return NotFound();
        }
        GratisPointPackages? gratisPointPackagesFromDb = _unitOfWork.GratisPointPackages.Get(u => u.gratisPointPackagesId == id);
        
        if (gratisPointPackagesFromDb == null)
        {
            return NotFound();
        }
        return View(gratisPointPackagesFromDb);
    }

    [HttpPost]
    public IActionResult Edit(GratisPointPackages obj)
    {
        if (ModelState.IsValid)
        {
            _unitOfWork.GratisPointPackages.Update(obj);
            _unitOfWork.Save();
            return RedirectToAction("Index");
        }
        return View();
    }

    public IActionResult Delete(int? id)
    {
        if (id == null || id == 0)
        {
            return NotFound();
        }
        GratisPointPackages? gratisPointPackagesFromDb = _unitOfWork.GratisPointPackages.Get(u => u.gratisPointPackagesId == id);

        if (gratisPointPackagesFromDb == null)
        {
            return NotFound();
        }
        return View(gratisPointPackagesFromDb);
    }

    [HttpPost, ActionName("Delete")]
    public IActionResult DeletePost(int? id)
    {
        GratisPointPackages? obj = _unitOfWork.GratisPointPackages.Get(u => u.gratisPointPackagesId == id);

        if (obj == null)
        {
            return NotFound();
        }
        _unitOfWork.GratisPointPackages.Remove(obj);
        _unitOfWork.Save();

        return RedirectToAction("Index");
    }
}