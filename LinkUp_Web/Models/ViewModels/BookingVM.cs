namespace LinkUp_Web.Models.ViewModels;

public class BookingVM
{
    public IEnumerable<Booking> BookingList { get; set; }
    public BookingHeader BookingHeader { get; set; }
    // public double BookingsTotal { get; set; }
}