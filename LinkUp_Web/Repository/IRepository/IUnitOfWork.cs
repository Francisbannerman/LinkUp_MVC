namespace LinkUp_Web.Repository.IRepository;

public interface IUnitOfWork
{
    IApplicationUserRepository ApplicationUser { get; }
    ICategoryRepository Category { get; }
    IProductRepository Product { get; }
    IBookingRepository Booking { get; }
    //IBookingDetailRepository BookingDetail { get; }
    IBookingHeaderRepository BookingHeader { get; }
    IGratisPointRepository GratisPointPackages { get; }
    IGratisPurchaseRepository GratisPurchase { get; }
    void Save();
}