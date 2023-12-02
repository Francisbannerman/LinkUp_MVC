using LinkUp_Web.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LinkUp_Web;

public class ApplicationDbContext : IdentityDbContext
{
    private Guid guid1 = Guid.NewGuid();
    private Guid guid2 = Guid.NewGuid();
    private Guid guid3 = Guid.NewGuid();
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
        : base(options)
    {
    }
    public DbSet<ApplicationUser> ApplicationUsers { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Booking> Bookings { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<BookingHeader> BookingHeaders { get; set; }
    public DbSet<GratisPointPackages> GratisPointPackages { get; set; }
    public DbSet<GratisPurchase> GratisPurchases { get; set; }
    public DbSet<Notification> Notifications { get; set; }
    public DbSet<BookedProduct> BookedProducts { get; set; }
    public DbSet<FulfilledBooking> FulfilledBookings { get; set; }
    public DbSet<TempBookedProduct> TempBookedProducts { get; set; }


    public List<ApplicationUser> applicationUserList()
    {
        List<ApplicationUser> applicationUsers = new List<ApplicationUser>();
        applicationUsers.Add(new ApplicationUser{ name = "Admin", streetAddress = "AdminHome", city = "AdminCity", 
            region = "AdminRegion", gender = "Male", gratisPoint = 0});
        applicationUsers.Add(new ApplicationUser{ name = "Admin1", streetAddress = "Admin1Home", city = "Admin1City", 
            region = "Admin1Region", gender = "Male", gratisPoint = 0});
        applicationUsers.Add(new ApplicationUser{ name = "Admin2", streetAddress = "Admin2Home", city = "Admin2City", 
            region = "Admin2Region", gender = "Male", gratisPoint = 0});
    
        return applicationUsers;
    }
    
    public List<Category> categoryList()
    {
        List<Category> categories = new List<Category>();
        categories.Add(new Category {
            categoryId = guid1, name = "Date4Two", displayOrder = 1 });
        categories.Add(new Category {
            categoryId = guid2, name = "DateWithTwo", displayOrder = 2 });
        categories.Add(new Category {
            categoryId = guid3, name = "DateFromTwo", displayOrder = 3 });
        return categories;
    }

    public List<Product> productList()
    {
        DateTime utcDateTime = DateTime.UtcNow; // Get the current UTC time
    
        List<Product> products = new List<Product>();
        products.Add(new Product { productId = Guid.NewGuid(), productTitle = "AdminProduct",
            productDescription = "This is an Admin product", productHighlights ="Admin magic content",
            supplierPrice = 100, displayPrice = 110, categoryId = guid1, category = null, imageUrl = "dkhdhdhjhvdjh",
            productLocation = "AdminLocation"});
        products.Add(new Product { productId = Guid.NewGuid(), productTitle = "Admin1Product",
            productDescription = "This is an Admin1 product", productHighlights ="Admin1 magic content",
            supplierPrice = 90, displayPrice = 120, categoryId = guid2, category = null, imageUrl = "1dkhdhdhjhvdjh",
            productLocation = "Admin1Location"});
        products.Add(new Product { productId = Guid.NewGuid(), productTitle = "Admin2Product",
            productDescription = "This is an Admin2 product", productHighlights ="Admin2 magic content",
            supplierPrice = 80, displayPrice = 130, categoryId = guid3, category = null, imageUrl = "2dkhdhdhjhvdjh",
            productLocation = "Admin2Location"});
    
        return products;
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        modelBuilder.Entity<ApplicationUser>().HasData(applicationUserList());
        modelBuilder.Entity<Category>().HasData(categoryList());
        modelBuilder.Entity<Product>().HasData(productList());
    }
}