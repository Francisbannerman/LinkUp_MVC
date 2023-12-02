using LinkUp_Web.Repository.IRepository;

namespace LinkUp_Web.Services;

public class GratisPointService
{
    private readonly IUnitOfWork _unitOfWork;

    public GratisPointService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    public decimal GetUserGratisPointBalance(string userId)
    {
        var user = _unitOfWork.ApplicationUser.Get(u => u.Id == userId);
        return Convert.ToDecimal(user.gratisPoint);
    }
    public void UpdateUserGratisPoints(string userId, int newPointBalance)
    {
        _unitOfWork.ApplicationUser.SpendGratisPoints(userId, Convert.ToInt32(newPointBalance));
        // _unitOfWork.Save();
    }
}