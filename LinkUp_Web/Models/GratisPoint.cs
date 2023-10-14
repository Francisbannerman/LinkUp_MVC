using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LinkUp_Web.Models;

public class GratisPoint
{
    [Key]
    [ForeignKey("applicationUser")]
    public string applicationUserId { get; set; }
    public ApplicationUser applicationUser { get; set; }
    public int Points { get; set; }

    public GratisPoint()
    {
        Points = applicationUser.gratisPoint;
    }
}