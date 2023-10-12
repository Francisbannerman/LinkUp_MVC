using LinkUp_Web.Models;
using LinkUp_Web.Repository.IRepository;

namespace LinkUp_Web.Repository;

public class BookingRepository: Repository<Booking>, IBookingRepository
{
    private readonly ApplicationDbContext _db;

    public BookingRepository(ApplicationDbContext db) : base(db)
    {
        _db = db;
    }

    public void Update(Booking obj)
    {
        _db.Bookings.Update(obj);
    }
}