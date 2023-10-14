using LinkUp_Web.Models;
using LinkUp_Web.Repository.IRepository;

namespace LinkUp_Web.Repository;

public class GratisPointRepository : Repository<GratisPoint>, IGratisPointRepository
{
    private readonly ApplicationDbContext _db;

    public GratisPointRepository(ApplicationDbContext db) : base(db)
    {
        _db = db;
    }

    public void Update(GratisPoint obj)
    {
        _db.GratisPoints.Update(obj);
    }
}