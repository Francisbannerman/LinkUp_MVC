using LinkUp_Web.Models;

namespace LinkUp_Web.Repository.IRepository;

public interface IApplicationUserRepository : IRepository<ApplicationUser>
{
    void Update(ApplicationUser obj);
}