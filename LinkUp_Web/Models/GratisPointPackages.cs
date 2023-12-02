using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace LinkUp_Web.Models;

public class GratisPointPackages
{
    [Key]
    [Required]
    public Guid gratisPointPackagesId { get; set; }
    [Required]
    public int gratisPointQuantity { get; set; }
    [Required]
    public double AmountForGratisPoint { get; set; }
    public DateTimeOffset dateAdded { get; set; }
    
    public string? addedByWho { get; set; }
}