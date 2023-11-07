using LinkUp_Web.Models;

namespace LinkUp_Web.Repository.IRepository;

public interface IApplicationUserRepository : IRepository<ApplicationUser>
{
    void Update(ApplicationUser obj);
    public void BuyGratisPoints(string userId, int newGratisPointsBought);
    public void SpendGratisPoints(string userId, int newGratisPointsBought);
    public void UpdateReferredUsers(string userId);
}