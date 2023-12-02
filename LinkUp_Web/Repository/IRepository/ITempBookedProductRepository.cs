using LinkUp_Web.Models;

namespace LinkUp_Web.Repository.IRepository;

public interface ITempBookedProductRepository : IRepository<TempBookedProduct>
{
    void Update(TempBookedProduct obj);
}