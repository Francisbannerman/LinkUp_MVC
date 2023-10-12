using LinkUp_Web.Models;

namespace LinkUp_Web.Repository.IRepository;

public interface IBookingDetailRepository: IRepository<BookingDetail>
{
    void Update(BookingDetail obj);
}