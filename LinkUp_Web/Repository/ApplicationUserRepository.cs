using LinkUp_Web.Models;
using LinkUp_Web.Repository.IRepository;

namespace LinkUp_Web.Repository;

public class ApplicationUserRepository : Repository<ApplicationUser>, IApplicationUserRepository
{
    private readonly ApplicationDbContext _db;

    public ApplicationUserRepository(ApplicationDbContext db) : base(db)
    {
        _db = db;
    }

    public void Update(ApplicationUser obj)
    {
        _db.ApplicationUsers.Update(obj);
    }

    public void UpdateGratisPoints(string userId, int newGratisPointsBought)
    {
        var users = _db.ApplicationUsers.FirstOrDefault(u => u.Id == userId);

        var currentGratisPoint = users.gratisPoint += newGratisPointsBought;
        users.gratisPoint = currentGratisPoint;
    }
}