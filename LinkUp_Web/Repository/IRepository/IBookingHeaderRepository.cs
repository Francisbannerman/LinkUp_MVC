using LinkUp_Web.Models;

namespace LinkUp_Web.Repository.IRepository;

public interface IBookingHeaderRepository: IRepository<BookingHeader>
{
    void Update(BookingHeader obj);
}