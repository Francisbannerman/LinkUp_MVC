using LinkUp_Web.Models;

namespace LinkUp_Web.Repository.IRepository;

public interface IFulfilledBookingRepository : IRepository<FulfilledBooking>
{
    void Update(FulfilledBooking obj);
}