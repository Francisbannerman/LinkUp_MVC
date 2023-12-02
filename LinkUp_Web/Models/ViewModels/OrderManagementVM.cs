
namespace LinkUp_Web.Models.ViewModels;

public class OrderManagementVM
{
    public List<BookingHeader>? BookingHeaderList { get; set; }
    public List<BookedProduct>? BookedProductList { get; set; }
    public List<Product>? ProductList { get; set; }
    public List<ResultItem>? Result { get; set; }
    public BookingHeader? BookingHeader { get; set; }
    public Dictionary<Guid, int>? NumberOfUsersMap { get; set; }
}