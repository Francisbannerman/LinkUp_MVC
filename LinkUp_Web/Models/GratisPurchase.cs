using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;


namespace LinkUp_Web.Models;

public class GratisPurchase
{
    [Key]
    public int gratisPurchaseId { get; set; }
    public int gratisPointQuantity { get; set; }
    public double amountForGratisPoint { get; set; }
    public DateTimeOffset datePurchased { get; set; }
    public string? paymentStatus { get; set; }
    public string? sessionId { get; set; }
    public string? paymentIntentId { get; set; }
    public string applicationUser { get; set; }
    
}