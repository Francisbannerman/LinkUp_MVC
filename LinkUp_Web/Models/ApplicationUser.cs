using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using LinkUp_Web.Utility;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace LinkUp_Web.Models;

public class ApplicationUser : IdentityUser
{
    [Required]
    public string name { get; set; }
    public string? streetAddress { get; set; }
    public string? city { get; set; }
    public string? region { get; set; }
    public string? gender { get; set; }
    public DateTimeOffset userDateJoined { get; set; }
    public string? role { get; set; }
    public int gratisPoint { get; set; }
    public string? referralCode { get; set; }

    public ApplicationUser()
    {
        gratisPoint = 0;
    }
}