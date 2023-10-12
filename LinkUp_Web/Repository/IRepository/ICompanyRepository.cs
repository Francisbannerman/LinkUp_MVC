using LinkUp_Web.Models;

namespace LinkUp_Web.Repository.IRepository;

public interface ICompanyRepository : IRepository<Company>
{
    void Update(Company obj);
}