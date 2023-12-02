using System.ComponentModel.DataAnnotations;

namespace LinkUp_Web.Models;

public class TempBookedProduct
{ 
    [Key]
    [Required]
    public Guid id { get; set; }
    public string applicationUserId { get; set; }
    public string productId { get; set; }
    public string bookingHeaderId { get; set; }
}