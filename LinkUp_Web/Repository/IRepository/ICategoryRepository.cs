using LinkUp_Web.Models;

namespace LinkUp_Web.Repository.IRepository;

public interface ICategoryRepository : IRepository<Category>
{
    void Update(Category obj);
}