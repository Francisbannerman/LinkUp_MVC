using System.Security.Claims;
using LinkUp_Web.Models;
using LinkUp_Web.Repository.IRepository;

namespace LinkUp_Web.Services;

public class NotificationService
{
    private readonly IUnitOfWork _unitOfWork;

    public NotificationService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    
    public void AddNotification(string? notificationMsg, string? userId)
    {
        var notification = new Notification
        {
            DateTimeSent = DateTime.UtcNow,
            UserId = userId,
            Message = notificationMsg
        };
        _unitOfWork.Notification.Add(notification);
    }

    public void ProcessingNotification(BookingHeader BookingHeader)
    {
        bool processingEncountered = false;
        var msg = "Your Booking is being processed at the moment. Stay tuned as " +
                  "Booking confirmation doesn't take long after processing starts";
        var msg2 = "Your Booking Has Been Confirm To Go On As You Booked It";
        if (BookingHeader.orderStatus == "Processing")
        {
            if (!processingEncountered)
            {
                AddNotification(msg, BookingHeader.applicationUserId);
                processingEncountered = true;
            }
        }
        else if (BookingHeader.orderStatus == "Completed")
        {
            processingEncountered = false;
            if (!processingEncountered)
            {
                AddNotification(msg2, BookingHeader.applicationUserId);
                processingEncountered = true;
            }
        }
    }
}