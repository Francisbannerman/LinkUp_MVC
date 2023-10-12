namespace LinkUp_Web.Models.ViewModels;

public class CompanyVM
{
    public Company Company { get; set; }
    public List<Company> CompanyList { get; set; }
    public int DisplayOrder { get; set; }
}