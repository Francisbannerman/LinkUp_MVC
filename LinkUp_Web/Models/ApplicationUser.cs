using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using LinkUp_Web.Utility;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace LinkUp_Web.Models;

public class ApplicationUser : IdentityUser
{
    [Required]
    public string Name { get; set; }
    public string? StreetAddress { get; set; }
    public string? City { get; set; }
    public string? Region { get; set; }
    public string? Gender { get; set; }
    public DateTimeOffset userDateJoined { get; set; }
    public int? CompanyId { get; set; }
    public string? Role { get; set; }
    
    [ForeignKey("CompanyId")]
    [ValidateNever]
    public Company? Company { get; set; }
}