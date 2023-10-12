using LinkUp_Web.Models;

namespace LinkUp_Web.Repository.IRepository;

public interface IBookingRepository: IRepository<Booking>
{
    void Update(Booking obj);
}