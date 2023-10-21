using LinkUp_Web.Models;

namespace LinkUp_Web.Repository.IRepository;

public interface IGratisPurchaseRepository : IRepository<GratisPurchase>
{
    void Update(GratisPurchase obj);
    public void UpdateStatus(int id, string orderStatus, string? paymentStatus = null);
    public void UpdateStripePaymentID(int id, string sessionId, string paymentIntentId);
}