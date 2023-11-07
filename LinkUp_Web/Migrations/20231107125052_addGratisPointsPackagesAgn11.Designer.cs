﻿// <auto-generated />
using System;
using LinkUp_Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace LinkUp_Web.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231107125052_addGratisPointsPackagesAgn11")]
    partial class addGratisPointsPackagesAgn11
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("LinkUp_Web.Models.Booking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ApplicationUserId")
                        .HasColumnType("text");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uuid");

                    b.Property<string>("applicationUserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("plusOne")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("ProductId");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("LinkUp_Web.Models.BookingHeader", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ApplicationUserId")
                        .HasColumnType("text");

                    b.Property<string>("applicationUserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("attendee")
                        .HasColumnType("text");

                    b.Property<DateTime>("bookingDateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("city")
                        .HasColumnType("text");

                    b.Property<DateTime>("dateBooked")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("name")
                        .HasColumnType("text");

                    b.Property<string>("orderStatus")
                        .HasColumnType("text");

                    b.Property<double>("orderTotal")
                        .HasColumnType("double precision");

                    b.Property<DateTime?>("paymentDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("phoneNumber")
                        .HasColumnType("text");

                    b.Property<string>("postalCode")
                        .HasColumnType("text");

                    b.Property<string>("region")
                        .HasColumnType("text");

                    b.Property<string>("seatTableNumber")
                        .HasColumnType("text");

                    b.Property<string>("streetAddress")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.ToTable("BookingHeaders");
                });

            modelBuilder.Entity("LinkUp_Web.Models.Category", b =>
                {
                    b.Property<int>("categoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("categoryId"));

                    b.Property<int?>("displayOrder")
                        .HasColumnType("integer");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.HasKey("categoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            categoryId = 1,
                            displayOrder = 1,
                            name = "Date4Two"
                        },
                        new
                        {
                            categoryId = 2,
                            displayOrder = 2,
                            name = "DateWithTwo"
                        },
                        new
                        {
                            categoryId = 3,
                            displayOrder = 3,
                            name = "DateFromTwo"
                        });
                });

            modelBuilder.Entity("LinkUp_Web.Models.GratisPointPackages", b =>
                {
                    b.Property<int>("gratisPointPackagesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("gratisPointPackagesId"));

                    b.Property<double>("AmountForGratisPoint")
                        .HasColumnType("double precision");

                    b.Property<string>("addedByWho")
                        .HasColumnType("text");

                    b.Property<DateTimeOffset>("dateAdded")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("gratisPointQuantity")
                        .HasColumnType("integer");

                    b.HasKey("gratisPointPackagesId");

                    b.ToTable("GratisPointPackages");
                });

            modelBuilder.Entity("LinkUp_Web.Models.GratisPurchase", b =>
                {
                    b.Property<int>("gratisPurchaseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("gratisPurchaseId"));

                    b.Property<double>("amountForGratisPoint")
                        .HasColumnType("double precision");

                    b.Property<string>("applicationUser")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTimeOffset>("datePurchased")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("gratisPointQuantity")
                        .HasColumnType("integer");

                    b.Property<string>("paymentIntentId")
                        .HasColumnType("text");

                    b.Property<string>("paymentStatus")
                        .HasColumnType("text");

                    b.Property<string>("sessionId")
                        .HasColumnType("text");

                    b.HasKey("gratisPurchaseId");

                    b.ToTable("GratisPurchases");
                });

            modelBuilder.Entity("LinkUp_Web.Models.Product", b =>
                {
                    b.Property<Guid>("productId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("integer");

                    b.Property<int>("categoryId")
                        .HasColumnType("integer");

                    b.Property<double>("displayPrice")
                        .HasColumnType("double precision");

                    b.Property<string>("imageUrl")
                        .HasColumnType("text");

                    b.Property<int?>("plusOnesAllowed")
                        .HasColumnType("integer");

                    b.Property<DateTimeOffset>("productDateAdded")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("productDescription")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("productHighlights")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("productLocation")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("productTitle")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("supplierPrice")
                        .HasColumnType("double precision");

                    b.HasKey("productId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            productId = new Guid("3d76356d-34d9-442d-9330-fbae88ab3e30"),
                            categoryId = 1,
                            displayPrice = 110.0,
                            imageUrl = "dkhdhdhjhvdjh",
                            productDateAdded = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            productDescription = "This is an Admin product",
                            productHighlights = "Admin magic content",
                            productLocation = "AdminLocation",
                            productTitle = "AdminProduct",
                            supplierPrice = 100.0
                        },
                        new
                        {
                            productId = new Guid("b9bc844a-2caf-45b4-8798-f697b4ad7366"),
                            categoryId = 2,
                            displayPrice = 120.0,
                            imageUrl = "1dkhdhdhjhvdjh",
                            productDateAdded = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            productDescription = "This is an Admin1 product",
                            productHighlights = "Admin1 magic content",
                            productLocation = "Admin1Location",
                            productTitle = "Admin1Product",
                            supplierPrice = 90.0
                        },
                        new
                        {
                            productId = new Guid("fa5d19b7-81de-41b4-ac1b-fbcae7c98c9e"),
                            categoryId = 3,
                            displayPrice = 130.0,
                            imageUrl = "2dkhdhdhjhvdjh",
                            productDateAdded = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            productDescription = "This is an Admin2 product",
                            productHighlights = "Admin2 magic content",
                            productLocation = "Admin2Location",
                            productTitle = "Admin2Product",
                            supplierPrice = 80.0
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("LinkUp_Web.Models.ApplicationUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("city")
                        .HasColumnType("text");

                    b.Property<string>("gender")
                        .HasColumnType("text");

                    b.Property<int>("gratisPoint")
                        .HasColumnType("integer");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("referralCode")
                        .HasColumnType("text");

                    b.Property<string>("referredCode")
                        .HasColumnType("text");

                    b.Property<int>("referredUsers")
                        .HasColumnType("integer");

                    b.Property<string>("region")
                        .HasColumnType("text");

                    b.Property<string>("role")
                        .HasColumnType("text");

                    b.Property<string>("streetAddress")
                        .HasColumnType("text");

                    b.Property<DateTimeOffset>("userDateJoined")
                        .HasColumnType("timestamp with time zone");

                    b.HasDiscriminator().HasValue("ApplicationUser");

                    b.HasData(
                        new
                        {
                            Id = "5d1da9d8-2da1-429d-9d35-cca0aa0e2fd7",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "6111036b-9456-464f-99fc-2b627ff71f54",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "4d0b2487-df4f-4f43-96bb-328c4a1885c7",
                            TwoFactorEnabled = false,
                            city = "AdminCity",
                            gender = "Male",
                            gratisPoint = 0,
                            name = "Admin",
                            referredUsers = 0,
                            region = "AdminRegion",
                            streetAddress = "AdminHome",
                            userDateJoined = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0))
                        },
                        new
                        {
                            Id = "c2da4801-f37d-4b83-aa59-a9892d6f1c0c",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "516c3308-179e-476c-b91e-35a33ffc09e3",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "51764bef-49a8-44ff-90b7-28e6a883ef27",
                            TwoFactorEnabled = false,
                            city = "Admin1City",
                            gender = "Male",
                            gratisPoint = 0,
                            name = "Admin1",
                            referredUsers = 0,
                            region = "Admin1Region",
                            streetAddress = "Admin1Home",
                            userDateJoined = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0))
                        },
                        new
                        {
                            Id = "7e4c66c2-bd07-4549-8b44-3736a92ee996",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "754b743c-3677-4645-ae9f-259aac18fead",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "b7c5cfe8-4c88-4ecc-aea5-68642d10fd08",
                            TwoFactorEnabled = false,
                            city = "Admin2City",
                            gender = "Male",
                            gratisPoint = 0,
                            name = "Admin2",
                            referredUsers = 0,
                            region = "Admin2Region",
                            streetAddress = "Admin2Home",
                            userDateJoined = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0))
                        });
                });

            modelBuilder.Entity("LinkUp_Web.Models.Booking", b =>
                {
                    b.HasOne("LinkUp_Web.Models.ApplicationUser", "applicationUser")
                        .WithMany()
                        .HasForeignKey("ApplicationUserId");

                    b.HasOne("LinkUp_Web.Models.Product", "product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("applicationUser");

                    b.Navigation("product");
                });

            modelBuilder.Entity("LinkUp_Web.Models.BookingHeader", b =>
                {
                    b.HasOne("LinkUp_Web.Models.ApplicationUser", "applicationUser")
                        .WithMany()
                        .HasForeignKey("ApplicationUserId");

                    b.Navigation("applicationUser");
                });

            modelBuilder.Entity("LinkUp_Web.Models.Product", b =>
                {
                    b.HasOne("LinkUp_Web.Models.Category", "category")
                        .WithMany()
                        .HasForeignKey("CategoryId");

                    b.Navigation("category");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
