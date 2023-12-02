namespace LinkUp_Web.Models;

public class ResultItem
{
    public Guid BookingHeaderId { get; set; }
    public List<string> ProductName { get; set; }
    public List<Guid> ProductIds { get; set; }
}