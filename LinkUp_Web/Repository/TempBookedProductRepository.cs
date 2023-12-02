using LinkUp_Web.Models;
using LinkUp_Web.Repository.IRepository;

namespace LinkUp_Web.Repository;

public class TempBookedProductRepository : Repository<TempBookedProduct>, ITempBookedProductRepository
{
    private readonly ApplicationDbContext _db;

    public TempBookedProductRepository(ApplicationDbContext db) : base(db)
    {
        _db = db;
    }

    public void Update(TempBookedProduct obj)
    {
        _db.TempBookedProducts.Update(obj);
    }
}