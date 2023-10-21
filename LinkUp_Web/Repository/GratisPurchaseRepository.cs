using LinkUp_Web.Models;
using LinkUp_Web.Repository.IRepository;

namespace LinkUp_Web.Repository;

public class GratisPurchaseRepository : Repository<GratisPurchase>, IGratisPurchaseRepository
{
    private readonly ApplicationDbContext _db;

    public GratisPurchaseRepository(ApplicationDbContext db) : base(db)
    {
        _db = db;
    }

    public void Update(GratisPurchase obj)
    {
        _db.GratisPurchases.Update(obj);
    }
    
    public void UpdateStatus(int id, string orderStatus, string? paymentStatus = null)
    {
        var orderFromDb = _db.GratisPurchases.FirstOrDefault(u => u.gratisPurchaseId == id);
        if (orderFromDb != null)
        {
            if (!string.IsNullOrEmpty(paymentStatus))
            {
                orderFromDb.paymentStatus = paymentStatus;
            }
        }
    }
    
    public void UpdateStripePaymentID(int id, string sessionId, string paymentIntentId)
    {
        var orderFromDb = _db.GratisPurchases.FirstOrDefault(u => u.gratisPurchaseId == id);
        if (!string.IsNullOrEmpty(sessionId))
        {
            orderFromDb.sessionId = sessionId;
        }
        if (!string.IsNullOrEmpty(paymentIntentId))
        {
            orderFromDb.paymentIntentId = paymentIntentId;
            orderFromDb.datePurchased = DateTime.UtcNow;
        }
    }
}