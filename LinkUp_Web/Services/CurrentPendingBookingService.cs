using LinkUp_Web.Models;
using LinkUp_Web.Repository.IRepository;

namespace LinkUp_Web.Services;

public class CurrentPendingBookingService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly GetUserIdService _getUserIdService;

    public CurrentPendingBookingService(IUnitOfWork unitOfWork, GetUserIdService getUserIdService)
    {
        _unitOfWork = unitOfWork;
        _getUserIdService = getUserIdService;
    }
    public List<Booking> GetCurrentUsersCurrentBookings()
    {
        return _unitOfWork.Booking.GetAll(u => u.applicationUserId == _getUserIdService.GetCurrentUserId(), includeProperties: "product").ToList();
    }
}