using System.ComponentModel.DataAnnotations;

namespace LinkUp_Web.Models;

public class Notification
{
    [Key]
    [Required]
    public Guid notificationId { get; set; }
    public string UserId { get; set; }
    public DateTime DateTimeSent { get; set; }
    public string Message { get; set; }
}