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
    public IGratisPointRepository GratisPointPackages { get; private set; }
    public IGratisPurchaseRepository GratisPurchase { get; private set; }
    public INotificationRepository Notification { get; private set; }
    public IBookedProductRepository BookedProduct { get; private set; }
    public IFulfilledBookingRepository FulfilledBooking { get; private set; }
    public ITempBookedProductRepository TempBookedProduct { get; private set; }

    public UnitOfWork(ApplicationDbContext db)
    {
        _db = db;
        ApplicationUser = new ApplicationUserRepository(_db);
        Category = new CategoryRepository(_db);
        Product = new ProductRepository(_db);
        Booking = new BookingRepository(_db);
        BookingHeader = new BookingHeaderRepository(_db);
        GratisPointPackages = new GratisPointRepository(_db);
        GratisPurchase = new GratisPurchaseRepository(_db);
        Notification = new NotificationRepository(_db);
        BookedProduct = new BookedProductRepository(_db);
        FulfilledBooking = new FulfilledBookingRepository(_db);
        TempBookedProduct = new TempBookedProductRepository(_db);
    }

    public void Save()
    {
        _db.SaveChanges();
    }
}