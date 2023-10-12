using LinkUp_Web.Models;

namespace LinkUp_Web.Repository.IRepository;

public interface IBookingHeaderRepository: IRepository<BookingHeader>
{
    void Update(BookingHeader obj);
    void UpdateStatus(int id, string orderStatus, string? paymentStatus = null);
    void UpdateStripePaymentID(int id, string sessionId, string paymentIntentId);
}