using LinkUp_Web.Models;
using LinkUp_Web.Models.ViewModels;
using LinkUp_Web.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;
using LinkUp_Web.Utility;


namespace LinkUp_Web.Controllers;

// [Authorize(Roles = SD.Role_Admin)]
// [Authorize(Roles = SD.Role_Company)]
public class ProductController : Controller
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IWebHostEnvironment _webHostEnvironment;
    public ProductController(IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment)
    {
        _unitOfWork = unitOfWork;
        _webHostEnvironment = webHostEnvironment;
    }
    // GET
    public IActionResult Index()
    {
        List<Product> categoryObjList = _unitOfWork.Product.GetAll(includeProperties:"Category").ToList();
        return View(categoryObjList);
    }

    public IActionResult Create()
    {
        ProductVM productVm = new()
        {
            CategoryList = _unitOfWork.Category.GetAll().Select(u => new SelectListItem
            {
                Text = u.Name,
                Value = u.CategoryId.ToString()
            }),
            CompanyList = _unitOfWork.Company.GetAll().Select(u => new SelectListItem
            {
                Text = u.Name,
                Value = u.CompanyId.ToString()
            }),
            Product = new Product()
        };
        return View(productVm);
    }

    [HttpPost]
    public IActionResult Create(ProductVM productVm, IFormFile? file)
    {
        Guid id = Guid.NewGuid();
        productVm.Product.productId = id;
        
        if (ModelState.IsValid)
        {
            string wwwRootPath = _webHostEnvironment.WebRootPath;

            string fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
            string productPath = Path.Combine(wwwRootPath, @"images/product");
                
            using (var fileStream = new FileStream(Path.Combine(productPath, fileName), FileMode.Create)) 
            { 
                file.CopyTo(fileStream);
            }
            productVm.Product.ImageUrl = @"/images/product/" + fileName;
            
            _unitOfWork.Product.Add(productVm.Product);
            
            _unitOfWork.Save();
            return RedirectToAction("Index");
        }
        else
        {
            return NotFound();
        }
    }
    
    public IActionResult Edit(Guid id)
    {
        ProductVM productVm = new()
        {
            CategoryList = _unitOfWork.Category.GetAll().Select(u => new SelectListItem
            {
                Text = u.Name,
                Value = u.CategoryId.ToString()
            }),
            Product = new Product()
        };
        
        productVm.Product = _unitOfWork.Product.Get(u => u.productId == id);
        return View(productVm);
    }

    [HttpPost]
    public IActionResult Edit(ProductVM productVm, IFormFile? file)
    {
        productVm.Product.CompanyId = 1;
        
        if (ModelState.IsValid)
        {
            string wwwRootPath = _webHostEnvironment.WebRootPath;

            if (file != null)
            {
                string fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                string productPath = Path.Combine(wwwRootPath, @"images/product");

                if (!string.IsNullOrEmpty(productVm.Product.ImageUrl))
                {
                    var oldImagePath = Path.Combine(wwwRootPath, productVm.Product.ImageUrl.TrimStart('/'));
                
                    if (System.IO.File.Exists(oldImagePath))
                    {
                        System.IO.File.Delete(oldImagePath);
                    }
                }
                using (var fileStream = new FileStream(Path.Combine(productPath, fileName), FileMode.Create))
                {
                    file.CopyTo(fileStream);
                }
                productVm.Product.ImageUrl = @"/images/product/" + fileName;
            }
            _unitOfWork.Product.Update(productVm.Product);
            
            _unitOfWork.Save();
            return RedirectToAction("Index");
        }
        else
        {
            return NotFound();
        }
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        List<Product> objProductList = _unitOfWork.Product.GetAll(includeProperties: "Category").ToList();
        return Json(new { data = objProductList });
    }

    public IActionResult Delete(Guid? id)
    {
        ProductVM productVm = new()
        {
            CategoryList = _unitOfWork.Category.GetAll().Select(u => new SelectListItem
            {
                Text = u.Name,
                Value = u.CategoryId.ToString()
            }),
            Product = new Product()
        };
        
        productVm.Product = _unitOfWork.Product.Get(u => u.productId == id);
        return View(productVm);
    }
    
    [HttpPost, ActionName("Delete")]
    public IActionResult DeleteProduct(Guid? id)
    {
        var productToBeDeleted = _unitOfWork.Product.Get(u => u.productId == id);

        if (productToBeDeleted == null)
        {
            return Json(new { success = false, message = "Error while deleting" });
        }
        var oldImagePath = Path.Combine(_webHostEnvironment.WebRootPath, productToBeDeleted.ImageUrl.TrimStart('\\'));

        if (System.IO.File.Exists(oldImagePath))
        {
            System.IO.File.Delete(oldImagePath);
        }

        _unitOfWork.Product.Remove(productToBeDeleted);
        _unitOfWork.Save();

        return RedirectToAction("Index");
    }
}