using LinkUp_Web.Models;

namespace LinkUp_Web.Repository.IRepository;

public interface IBookedProductRepository : IRepository<BookedProduct>
{
    void Update(BookedProduct obj);
}