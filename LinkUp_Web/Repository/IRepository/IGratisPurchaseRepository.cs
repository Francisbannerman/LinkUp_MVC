using LinkUp_Web.Models;

namespace LinkUp_Web.Repository.IRepository;

public interface IGratisPurchaseRepository : IRepository<GratisPurchase>
{
    void Update(GratisPurchase obj);
    public void UpdateStatus(Guid id, string orderStatus, string? paymentStatus = null);
    public void UpdateStripePaymentID(Guid id, string sessionId, string paymentIntentId);
}