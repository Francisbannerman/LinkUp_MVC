using LinkUp_Web.Repository.IRepository;

namespace LinkUp_Web.Repository;

public class UnitOfWork : IUnitOfWork
{
    private readonly ApplicationDbContext _db;
    public IApplicationUserRepository ApplicationUser { get; private set; }
    public ICategoryRepository Category { get; private set; }
    public IProductRepository Product { get; private set; }
    public IBookingRepository Booking { get; private set; }
    public IBookingHeaderRepository BookingHeader { get; private set; }
    public IBookingDetailRepository BookingDetail { get; private set; }
    public IGratisPointRepository GratisPoint { get; private set; }

    public UnitOfWork(ApplicationDbContext db)
    {
        _db = db;
        ApplicationUser = new ApplicationUserRepository(_db);
        Category = new CategoryRepository(_db);
        Product = new ProductRepository(_db);
        Booking = new BookingRepository(_db);
        BookingHeader = new BookingHeaderRepository(_db);
        BookingDetail = new BookingDetailRepository(_db);
        GratisPoint = new GratisPointRepository(_db);
    }

    public void Save()
    {
        _db.SaveChanges();
    }
}