using LinkUp_Web.Models;
using LinkUp_Web.Repository.IRepository;

namespace LinkUp_Web.Repository;

public class BookedProductRepository : Repository<BookedProduct>, IBookedProductRepository
{
    private readonly ApplicationDbContext _db;

    public BookedProductRepository(ApplicationDbContext db) : base(db)
    {
        _db = db;
    }
    public void Update(BookedProduct obj)
    {
        _db.BookedProducts.Update(obj);
    }
}