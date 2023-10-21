using LinkUp_Web.Models;
using LinkUp_Web.Repository.IRepository;

namespace LinkUp_Web.Repository;

public class BookingHeaderRepository: Repository<BookingHeader>, IBookingHeaderRepository
{
    private readonly ApplicationDbContext _db;

    public BookingHeaderRepository(ApplicationDbContext db) : base(db)
    {
        _db = db;
    }

    public void Update(BookingHeader obj)
    {
        _db.BookingHeaders.Update(obj);
    }
}