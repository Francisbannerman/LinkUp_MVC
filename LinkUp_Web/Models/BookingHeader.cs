using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace LinkUp_Web.Models;

public class BookingHeader
{
    public int Id { get; set; }
    public string applicationUserId { get; set; }
    [ForeignKey("ApplicationUserId")]
    [ValidateNever]
    public ApplicationUser applicationUser { get; set; }

    //date user made the booking
    public DateTime dateBooked { get; set; }
    //day user made booking for
    public DateTime bookingDateTime { get; set; }
    public double orderTotal { get; set; }

    public string? orderStatus { get; set; }
    public string? seatTableNumber { get; set; }
    public string? attendee { get; set; }

    public DateTime? paymentDate { get; set; }

    public string? phoneNumber { get; set; }
    public string? streetAddress { get; set; }
    public string? city { get; set; }
    public string? region { get; set; }
    public string? postalCode { get; set; }
    public string? name { get; set; }
}