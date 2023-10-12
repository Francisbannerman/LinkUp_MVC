using LinkUp_Web.Models;
using LinkUp_Web.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters.Xml;
using Microsoft.AspNetCore.Authorization;
using LinkUp_Web.Utility;

namespace LinkUp_Web.Controllers;

// [Authorize(Roles = SD.Role_Admin)]
public class CompanyController : Controller
{
    private readonly IUnitOfWork _unitOfWork;

    public CompanyController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    // GET
    public IActionResult Index()
    {
        List<Company> companyObjList = _unitOfWork.Company.GetAll().ToList();
        return View(companyObjList);
    }
    
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Company obj)
    {
        obj.companyDateJoined = DateTimeOffset.UtcNow;
        int currentMaxId = _unitOfWork.Company.Max(u => u.CompanyId);
        currentMaxId = currentMaxId+1;
        obj.CompanyId = currentMaxId;
        
        if (obj.Name.Length < 2)
        {
            ModelState.AddModelError("Name","Category Name Can't Be Just 1 Letter");
        }

        if (ModelState.IsValid)
        {
            _unitOfWork.Company.Add(obj);
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
        Company? companyFromDb = _unitOfWork.Company.Get(u => u.CompanyId == id);
        
        if (companyFromDb == null)
        {
            return NotFound();
        }
        return View(companyFromDb);
    }

    [HttpPost]
    public IActionResult Edit(Company obj)
    {
        if (ModelState.IsValid)
        {
            _unitOfWork.Company.Update(obj);
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
        Company? companyFromDb = _unitOfWork.Company.Get(u => u.CompanyId == id);

        if (companyFromDb == null)
        {
            return NotFound();
        }
        return View(companyFromDb);
    }

    [HttpPost, ActionName("Delete")]
    public IActionResult DeletePost(int? id)
    {
        Company? obj = _unitOfWork.Company.Get(u => u.CompanyId == id);

        if (obj == null)
        {
            return NotFound();
        }
        _unitOfWork.Company.Remove(obj);
        _unitOfWork.Save();

        return RedirectToAction("Index");
    }
}