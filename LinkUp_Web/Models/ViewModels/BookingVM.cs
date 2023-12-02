namespace LinkUp_Web.Models.ViewModels;

public class BookingVM
{
    public Booking Booking { get; set; }
    public List<Booking> BookingList { get; set; }
    public BookingHeader BookingHeader { get; set; }
    public List<BookingHeader> BookingHeaderList { get; set; }
    public BookedProduct BookedProduct { get; set; }
    public List<BookedProduct> BookedProductList { get; set; }
}