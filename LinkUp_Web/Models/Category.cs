using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LinkUp_Web.Models;

public class Category
{
    [Key]
    [Required]
    public Guid categoryId { get; set; }

    [Required]
    [MaxLength(30)]
    [DisplayName("Category Name")]
    public string name { get; set; }

    [DisplayName("Display Order")]
    [Range(1, 100, ErrorMessage = "There is an error in this field")]
    public int? displayOrder { get; set; }
}