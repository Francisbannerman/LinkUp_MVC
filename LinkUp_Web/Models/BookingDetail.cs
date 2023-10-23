using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace LinkUp_Web.Models;

// public class BookingDetail
// {
//     public int Id { get; set; }
//
//     [Required]
//     public int BookingHeaderId { get; set; }
//
//     [ForeignKey("BookingHeaderId")]
//     [ValidateNever]
//     public BookingHeader bookingHeader { get; set; }
//
//     [Required]
//     public Guid productId { get; set; }
//
//     [ForeignKey("productId")]
//     [ValidateNever]
//     public Product product { get; set; }
//
//     public int plusOnes { get; set; }
//     public double price { get; set; }
// }