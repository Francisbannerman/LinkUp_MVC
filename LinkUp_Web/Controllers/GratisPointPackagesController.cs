using LinkUp_Web.Models;
using LinkUp_Web.Repository.IRepository;
using LinkUp_Web.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LinkUp_Web.Controllers;

// [Authorize(Roles = SD.Role_Admin)]
// [Authorize(Roles = SD.Role_Company)]
public class GratisPointPackagesController : Controller
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly GetUserIdService _getUserIdService;

    public GratisPointPackagesController(IUnitOfWork unitOfWork, GetUserIdService getUserIdService)
    {
        _unitOfWork = unitOfWork;
        _getUserIdService = getUserIdService;
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
        obj.gratisPointPackagesId = Guid.NewGuid();
        
        obj.dateAdded = DateTimeOffset.Now;
        obj.addedByWho = _getUserIdService.GetCurrentUserId();

        if (ModelState.IsValid)
        {
            _unitOfWork.GratisPointPackages.Add(obj);
            _unitOfWork.Save();
            return RedirectToAction("Index");
        }
        return View();
    }

    public IActionResult Edit(Guid? id)
    {
        if (id == null)
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

    public IActionResult Delete(Guid? id)
    {
        if (id == null)
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
    public IActionResult DeletePost(Guid? id)
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