using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace LinkUp_Web.Models;

public class BookingDetail
{
    public int Id { get; set; }

    [Required]
    public int BookingHeaderId { get; set; }

    [ForeignKey("BookingHeaderId")]
    [ValidateNever]
    public BookingHeader BookingHeader { get; set; }

    [Required]
    public Guid ProductId { get; set; }

    [ForeignKey("ProductId")]
    [ValidateNever]
    public Product Product { get; set; }

    public int Count { get; set; }
    public double Price { get; set; }
}