using LinkUp_Web.Models;
using LinkUp_Web.Repository.IRepository;

namespace LinkUp_Web.Repository;

public class FulfilledBookingRepository : Repository<FulfilledBooking>, IFulfilledBookingRepository
{
    private readonly ApplicationDbContext _db;
    
    public FulfilledBookingRepository(ApplicationDbContext db) : base(db)
    {
        _db = db;
    }
    public void Update(FulfilledBooking obj)
    {
        _db.FulfilledBookings.Update(obj);
    }
}