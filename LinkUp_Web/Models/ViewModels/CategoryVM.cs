
namespace LinkUp_Web.Models.ViewModels;

public class CategoryVM
{
    public Category Category { get; set; }
    public List<Category> CategoryList { get; set; }
    public int DisplayOrder { get; set; }
}