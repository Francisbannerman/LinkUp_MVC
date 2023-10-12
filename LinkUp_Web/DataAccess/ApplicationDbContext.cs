using LinkUp_Web.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
// using Services;

namespace LinkUp_Web;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
        : base(options)
    {
    }
    public DbSet<ApplicationUser> ApplicationUsers { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Booking> Bookings { get; set; }
    public DbSet<Company> Companies { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<BookingDetail> BookingDetails { get; set; }
    public DbSet<BookingHeader> BookingHeaders { get; set; }


    public List<ApplicationUser> applicationUserList()
    {
        List<ApplicationUser> applicationUsers = new List<ApplicationUser>();
        applicationUsers.Add(new ApplicationUser{ Name = "Admin", StreetAddress = "AdminHome", City = "AdminCity", 
            Region = "AdminRegion", Gender = "Male", CompanyId = 1, Company = null});
        applicationUsers.Add(new ApplicationUser{ Name = "Admin1", StreetAddress = "Admin1Home", City = "Admin1City", 
            Region = "Admin1Region", Gender = "Male", CompanyId = 2, Company = null});
        applicationUsers.Add(new ApplicationUser{ Name = "Admin2", StreetAddress = "Admin2Home", City = "Admin2City", 
            Region = "Admin2Region", Gender = "Male", CompanyId = 1, Company = null});
    
        return applicationUsers;
    }
    
    public List<Category> categoryList()
    {
        List<Category> categories = new List<Category>();
        categories.Add(new Category {
            CategoryId = 1, Name = "Date4Two", DisplayOrder = 1 });
        categories.Add(new Category {
            CategoryId = 2, Name = "DateWithTwo", DisplayOrder = 2 });
        categories.Add(new Category {
            CategoryId = 3, Name = "DateFromTwo", DisplayOrder = 3 });
        return categories;
    }
    
    public List<Company> companyList()
    {
        List<Company> companies = new List<Company>();
        companies.Add(new Company {CompanyId = 1, Name = "AdminCompany",
            StreetAddress = "AdminStreet", City = "AdminCity", Bio = "AdminRegion",
            PhoneNumber = "0550762466" });
        companies.Add(new Company {CompanyId = 2, Name = "Admin1Company",
            StreetAddress = "Admin1Street", City = "Admin1City", Bio = "Admin1Region",
            PhoneNumber = "0267067953" });
        companies.Add(new Company {CompanyId = 3, Name = "Admin2Company",
            StreetAddress = "Admin2Street", City = "Admin2City", Bio = "Admin2Region",
            PhoneNumber = "0550767953" });
        
        return companies;
    }
    
    public List<Product> productList()
    {
        DateTime utcDateTime = DateTime.UtcNow; // Get the current UTC time
    
        List<Product> products = new List<Product>();
        products.Add(new Product { productId = Guid.NewGuid(), productTitle = "AdminProduct",
            productDescription = "This is an Admin product", productHighlights ="Admin magic content",
            supplierPrice = 100, DisplayPrice = 110, CategoryId = 1, Category = null, ImageUrl = "dkhdhdhjhvdjh",
            productStartDate = utcDateTime , productEndDate = utcDateTime.AddDays(5),
            CompanyId = 1,  Company = null, productLocation = "AdminLocation", MinUsers = 2, MaxUsers = 10});
        products.Add(new Product { productId = Guid.NewGuid(), productTitle = "Admin1Product",
            productDescription = "This is an Admin1 product", productHighlights ="Admin1 magic content",
            supplierPrice = 90, DisplayPrice = 120, CategoryId = 2, Category = null, ImageUrl = "1dkhdhdhjhvdjh",
            productStartDate = utcDateTime, productEndDate = utcDateTime.AddDays(7),
            CompanyId = 2,  Company = null, productLocation = "Admin1Location", MinUsers = 3, MaxUsers = 11});
        products.Add(new Product { productId = Guid.NewGuid(), productTitle = "Admin2Product",
            productDescription = "This is an Admin2 product", productHighlights ="Admin2 magic content",
            supplierPrice = 80, DisplayPrice = 130, CategoryId = 3, Category = null, ImageUrl = "2dkhdhdhjhvdjh",
            productStartDate = utcDateTime, productEndDate = utcDateTime.AddDays(9),
            CompanyId = 3,  Company = null, productLocation = "Admin2Location", MinUsers = 4, MaxUsers = 12});
    
        return products;
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        modelBuilder.Entity<ApplicationUser>().HasData(applicationUserList());
        modelBuilder.Entity<Category>().HasData(categoryList());
        modelBuilder.Entity<Company>().HasData(companyList());
        modelBuilder.Entity<Product>().HasData(productList());
    }
}