// using LinkUp_Web.Models;
// using LinkUp_Web.Repository.IRepository;
//
// namespace LinkUp_Web.Repository;
//
// public class BookingDetailRepository: Repository<BookingDetail>, IBookingDetailRepository
// {
//     private readonly ApplicationDbContext _db;
//
//     public BookingDetailRepository(ApplicationDbContext db) : base(db)
//     {
//         _db = db;
//     }
//
//     public void Update(BookingDetail obj)
//     {
//         _db.BookingDetails.Update(obj);
//     }
// }