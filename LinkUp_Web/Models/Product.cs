using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace LinkUp_Web.Models;

public class Product
{
    [Key]
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
    public double DisplayPrice { get; set; }

    public int CategoryId { get; set; }
    
    [ForeignKey("CategoryId")]
    [ValidateNever]
    public Category? Category { get; set; }
    
    [ValidateNever]
    public string? ImageUrl { get; set; }
    
    public DateTimeOffset productDateAdded { get; set; }
    
    public DateTimeOffset? productStartDate { get; set; }
    
    public DateTimeOffset? productEndDate { get; set; }
    
    public int? CompanyId { get; set; }
    
    [ForeignKey("CompanyId")]
    [ValidateNever]
    public Company? Company { get; set; }
    
    public string productLocation { get; set; }
    
    public int MinUsers { get; set; }
    
    public int MaxUsers { get; set; }
}