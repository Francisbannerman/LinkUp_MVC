using LinkUp_Web.Models;

namespace LinkUp_Web.Repository.IRepository;

public interface IGratisPointRepository : IRepository<GratisPointPackages>
{
    void Update(GratisPointPackages obj);
}