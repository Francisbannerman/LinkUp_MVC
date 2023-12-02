using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace LinkUp_Web.Models;

public class BookedProduct
{
    [Key]
    [Required]
    public Guid id { get; set; }
    public string applicationUserId { get; set; }
    public Guid productId { get; set; }
    public string bookingHeaderId { get; set; }
    public DateTimeOffset productDateBooked { get; set; }
    public int numberOfAttendees { get; set; }
    
    [ForeignKey("productId")]
    [ValidateNever]
    public Product Product { get; set; }
}