using LinkUp_Web.Models;
using LinkUp_Web.Repository.IRepository;
using LinkUp_Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace LinkUp_Web.Controllers;

public class NotificationController : Controller
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly GetUserIdService _getUserIdService;
    public NotificationController(IUnitOfWork unitOfWork, GetUserIdService getUserIdService)
    {
        _unitOfWork = unitOfWork;
        _getUserIdService = getUserIdService;
    }

    // GET
    public IActionResult Index()
    {
        List<Notification> usersNotifications = _unitOfWork.Notification.GetAll
            (u => u.UserId == _getUserIdService.GetCurrentUserId()).ToList();
        return View(usersNotifications);
    }
    
    public IActionResult Delete(Guid? id)
    {
        if (id == null)
        {
            return NotFound();
        }
        Notification? notificationFromDB = _unitOfWork.Notification.Get
            (u => u.notificationId == id);
        if (notificationFromDB == null)
        {
            return NotFound();
        }
        return View(notificationFromDB);
    }
    
    [HttpPost, ActionName("Delete")]
    public IActionResult DeletePost(Guid? id)
    {
        Notification? obj = _unitOfWork.Notification.Get
            (u => u.notificationId == id);
        if (obj == null)
        {
            return NotFound();
        }
        _unitOfWork.Notification.Remove(obj);
        _unitOfWork.Save();
        return RedirectToAction("Index");
    }
}