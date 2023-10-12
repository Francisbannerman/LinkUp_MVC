using LinkUp_Web.Models;

namespace LinkUp_Web.Repository.IRepository;

public interface IProductRepository : IRepository<Product>
{
    void Update(Product obj);
}