using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace LinkUp_Web.Models;

public class Booking
{
    public int Id { get; set; }
    
    public Guid ProductId { get; set; }
    
    [ForeignKey("ProductId")]
    [ValidateNever]
    public Product product { get; set; }
    
    [Range(1,1000,ErrorMessage = "Please pick a number between 1 and 99")]
    public int plusOne { get; set; }
    
    public string applicationUserId { get; set; }
    
    [ForeignKey("ApplicationUserId")]
    [ValidateNever]
    public ApplicationUser applicationUser { get; set; }
    
    [NotMapped]
    public double price { get; set; }
}