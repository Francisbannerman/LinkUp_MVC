using LinkUp_Web.Models;
using LinkUp_Web.Repository.IRepository;

namespace LinkUp_Web.Repository;

public class NotificationRepository : Repository<Notification>, INotificationRepository
{
    private readonly ApplicationDbContext _db;

    public NotificationRepository(ApplicationDbContext db) : base(db)
    {
        _db = db;
    }

    public void Update(Notification obj)
    {
        _db.Notifications.Update(obj);
    }

    public void Add(Notification obj)
    {
        _db.Notifications.Add(obj);
    }

    public void Remove(Notification obj)
    {
        _db.Notifications.Remove(obj);
    }
}