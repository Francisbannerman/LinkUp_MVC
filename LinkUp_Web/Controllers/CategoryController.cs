using LinkUp_Web.Models;
using LinkUp_Web.Repository.IRepository;
using LinkUp_Web.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LinkUp_Web.Controllers;

// [Authorize(Roles = SD.Role_Admin)]
// [Authorize(Roles = SD.Role_Company)]
public class CategoryController : Controller
{
    private readonly IUnitOfWork _unitOfWork;

    public CategoryController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    
    // GET
    public IActionResult Index()
    {
        List<Category> categoryObjList = _unitOfWork.Category.GetAll().ToList();
        return View(categoryObjList);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Category obj)
    {
        if (obj.name == obj.displayOrder.ToString())
        {
            ModelState.AddModelError("Name", "The Name Cannot Be The Same As The Display Order");
        }
        if (obj.name.Length < 2)
        {
            ModelState.AddModelError("Name","Category Name Can't Be Just 1 Letter");
        }

        if (ModelState.IsValid)
        {
            _unitOfWork.Category.Add(obj);
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
        Category? categoryFromDb = _unitOfWork.Category.Get(u => u.categoryId == id);
        
        if (categoryFromDb == null)
        {
            return NotFound();
        }
        return View(categoryFromDb);
    }

    [HttpPost]
    public IActionResult Edit(Category obj)
    {
        if (ModelState.IsValid)
        {
            _unitOfWork.Category.Update(obj);
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
        Category? categoryFromDb = _unitOfWork.Category.Get(u => u.categoryId == id);

        if (categoryFromDb == null)
        {
            return NotFound();
        }
        return View(categoryFromDb);
    }

    [HttpPost, ActionName("Delete")]
    public IActionResult DeletePost(int? id)
    {
        Category? obj = _unitOfWork.Category.Get(u => u.categoryId == id);

        if (obj == null)
        {
            return NotFound();
        }
        _unitOfWork.Category.Remove(obj);
        _unitOfWork.Save();

        return RedirectToAction("Index");
    }
}