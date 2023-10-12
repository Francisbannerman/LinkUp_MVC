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

    public void UpdateStatus(int id, string orderStatus, string? paymentStatus = null)
    {
        var orderFromDb = _db.BookingHeaders.FirstOrDefault(u => u.Id == id);
        if (orderFromDb != null)
        {
            orderFromDb.OrderStatus = orderStatus;
            if (!string.IsNullOrEmpty(paymentStatus))
            {
                orderFromDb.PaymentStatus = paymentStatus;
            }
        }
    }

    public void UpdateStripePaymentID(int id, string sessionId, string paymentIntentId)
    {
        var orderFromDb = _db.BookingHeaders.FirstOrDefault(u => u.Id == id);
        if (!string.IsNullOrEmpty(sessionId))
        {
            orderFromDb.SessionId = sessionId;
        }
        if (!string.IsNullOrEmpty(paymentIntentId))
        {
            orderFromDb.PaymentIntentId = paymentIntentId;
            orderFromDb.PaymentDate = DateTime.UtcNow;
        }
    }
}