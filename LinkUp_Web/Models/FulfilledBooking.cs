using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace LinkUp_Web.Models;

public class FulfilledBooking
{
    [Key]
    [Required]
    public Guid Id { get; set; }
    
    public Guid BookingHeaderId { get; set; }
    [ForeignKey("BookingHeaderId")]
    [ValidateNever]
    public BookingHeader BookingHeader { get; set; }

    public Guid CustumerId { get; set; }
    [ForeignKey("CustomerId")]
    [ValidateNever]
    public ApplicationUser ApplicationUser { get; set; }

    public string ManagedBy { get; set; }
    public DateTime ManagedDate { get; set; }
    public string FinalStatus { get; set; }
}