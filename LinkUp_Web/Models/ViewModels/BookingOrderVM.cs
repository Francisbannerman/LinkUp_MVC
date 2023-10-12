namespace LinkUp_Web.Models.ViewModels;

public class BookingOrderVM
{
    public BookingHeader bookingHeader { get; set; }
    public IEnumerable<BookingDetail> bookingDetail { get; set; }
}