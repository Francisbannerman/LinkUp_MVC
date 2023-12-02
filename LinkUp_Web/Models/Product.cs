using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace LinkUp_Web.Models;

public class Product
{
    [Key]
    [Required]
    public Guid productId { get; set; }
    
    [Required]
    public string productTitle { get; set; }
    
    public string productDescription { get; set; }
    
    [Required]
    public string productHighlights { get; set; }

    [Required]
    [Range(1, 1000)]
    public double supplierPrice { get; set; }

    [Required]
    [Range(1, 1000)]
    public double displayPrice { get; set; }

    public Guid categoryId { get; set; }
    
    [ForeignKey("CategoryId")]
    [ValidateNever]
    public Category? category { get; set; }
    
    [ValidateNever]
    public string? imageUrl { get; set; }
    
    public DateTimeOffset productDateAdded { get; set; }

    public string productLocation { get; set; }
    
    public int? NumberOfAttendees { get; set; }
    
    public DateTimeOffset? productDateBooked { get; set; }
}