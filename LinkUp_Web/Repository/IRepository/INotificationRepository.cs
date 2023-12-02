using LinkUp_Web.Models;

namespace LinkUp_Web.Repository.IRepository;

public interface INotificationRepository : IRepository<Notification>
{
    void Update(Notification obj);

}