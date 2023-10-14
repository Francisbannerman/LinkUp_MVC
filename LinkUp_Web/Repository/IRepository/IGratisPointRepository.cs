using LinkUp_Web.Models;

namespace LinkUp_Web.Repository.IRepository;

public interface IGratisPointRepository : IRepository<GratisPoint>
{
    void Update(GratisPoint obj);
}