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
    [Migration("20230927014703_adEverythingAgains")]
    partial class adEverythingAgains
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("LinkUp_Web.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("CategoryId"));

                    b.Property<int?>("DisplayOrder")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            DisplayOrder = 1,
                            Name = "Date4Two"
                        },
                        new
                        {
                            CategoryId = 2,
                            DisplayOrder = 2,
                            Name = "DateWithTwo"
                        },
                        new
                        {
                            CategoryId = 3,
                            DisplayOrder = 3,
                            Name = "DateFromTwo"
                        });
                });

            modelBuilder.Entity("LinkUp_Web.Models.Company", b =>
                {
                    b.Property<int>("CompanyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("CompanyId"));

                    b.Property<string>("Bio")
                        .HasColumnType("text");

                    b.Property<string>("City")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<string>("StreetAddress")
                        .HasColumnType("text");

                    b.Property<DateTimeOffset>("companyDateJoined")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("CompanyId");

                    b.ToTable("Companies");

                    b.HasData(
                        new
                        {
                            CompanyId = 1,
                            Bio = "AdminRegion",
                            City = "AdminCity",
                            Name = "AdminCompany",
                            PhoneNumber = "0550762466",
                            StreetAddress = "AdminStreet",
                            companyDateJoined = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0))
                        },
                        new
                        {
                            CompanyId = 2,
                            Bio = "Admin1Region",
                            City = "Admin1City",
                            Name = "Admin1Company",
                            PhoneNumber = "0267067953",
                            StreetAddress = "Admin1Street",
                            companyDateJoined = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0))
                        },
                        new
                        {
                            CompanyId = 3,
                            Bio = "Admin2Region",
                            City = "Admin2City",
                            Name = "Admin2Company",
                            PhoneNumber = "0550767953",
                            StreetAddress = "Admin2Street",
                            companyDateJoined = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0))
                        });
                });

            modelBuilder.Entity("LinkUp_Web.Models.Product", b =>
                {
                    b.Property<Guid>("productId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("CategoryId")
                        .HasColumnType("integer");

                    b.Property<int?>("CompanyId")
                        .HasColumnType("integer");

                    b.Property<double>("DisplayPrice")
                        .HasColumnType("double precision");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("text");

                    b.Property<int>("MaxUsers")
                        .HasColumnType("integer");

                    b.Property<int>("MinUsers")
                        .HasColumnType("integer");

                    b.Property<DateTimeOffset>("productDateAdded")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("productDescription")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTimeOffset?>("productEndDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("productHighlights")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("productLocation")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTimeOffset?>("productStartDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("productTitle")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("supplierPrice")
                        .HasColumnType("double precision");

                    b.HasKey("productId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("CompanyId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            productId = new Guid("fe9fd2f1-1dea-49dc-87ae-3ee5aa4d949e"),
                            CategoryId = 1,
                            CompanyId = 1,
                            DisplayPrice = 110.0,
                            ImageUrl = "dkhdhdhjhvdjh",
                            MaxUsers = 10,
                            MinUsers = 2,
                            productDateAdded = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            productDescription = "This is an Admin product",
                            productEndDate = new DateTimeOffset(new DateTime(2023, 10, 2, 1, 47, 3, 541, DateTimeKind.Unspecified).AddTicks(9370), new TimeSpan(0, 0, 0, 0, 0)),
                            productHighlights = "Admin magic content",
                            productLocation = "AdminLocation",
                            productStartDate = new DateTimeOffset(new DateTime(2023, 9, 27, 1, 47, 3, 541, DateTimeKind.Unspecified).AddTicks(9370), new TimeSpan(0, 0, 0, 0, 0)),
                            productTitle = "AdminProduct",
                            supplierPrice = 100.0
                        },
                        new
                        {
                            productId = new Guid("1cd5c007-b95b-4294-9a37-1d8dcb56b264"),
                            CategoryId = 2,
                            CompanyId = 2,
                            DisplayPrice = 120.0,
                            ImageUrl = "1dkhdhdhjhvdjh",
                            MaxUsers = 11,
                            MinUsers = 3,
                            productDateAdded = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            productDescription = "This is an Admin1 product",
                            productEndDate = new DateTimeOffset(new DateTime(2023, 10, 4, 1, 47, 3, 541, DateTimeKind.Unspecified).AddTicks(9370), new TimeSpan(0, 0, 0, 0, 0)),
                            productHighlights = "Admin1 magic content",
                            productLocation = "Admin1Location",
                            productStartDate = new DateTimeOffset(new DateTime(2023, 9, 27, 1, 47, 3, 541, DateTimeKind.Unspecified).AddTicks(9370), new TimeSpan(0, 0, 0, 0, 0)),
                            productTitle = "Admin1Product",
                            supplierPrice = 90.0
                        },
                        new
                        {
                            productId = new Guid("e5d4f387-1e05-467b-8f97-b74b7b359ac3"),
                            CategoryId = 3,
                            CompanyId = 3,
                            DisplayPrice = 130.0,
                            ImageUrl = "2dkhdhdhjhvdjh",
                            MaxUsers = 12,
                            MinUsers = 4,
                            productDateAdded = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            productDescription = "This is an Admin2 product",
                            productEndDate = new DateTimeOffset(new DateTime(2023, 10, 6, 1, 47, 3, 541, DateTimeKind.Unspecified).AddTicks(9370), new TimeSpan(0, 0, 0, 0, 0)),
                            productHighlights = "Admin2 magic content",
                            productLocation = "Admin2Location",
                            productStartDate = new DateTimeOffset(new DateTime(2023, 9, 27, 1, 47, 3, 541, DateTimeKind.Unspecified).AddTicks(9370), new TimeSpan(0, 0, 0, 0, 0)),
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
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

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
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("LinkUp_Web.Models.ApplicationUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("City")
                        .HasColumnType("text");

                    b.Property<int?>("CompanyId")
                        .HasColumnType("integer");

                    b.Property<string>("Gender")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Region")
                        .HasColumnType("text");

                    b.Property<string>("StreetAddress")
                        .HasColumnType("text");

                    b.Property<DateTimeOffset>("userDateJoined")
                        .HasColumnType("timestamp with time zone");

                    b.HasIndex("CompanyId");

                    b.HasDiscriminator().HasValue("ApplicationUser");

                    b.HasData(
                        new
                        {
                            Id = "38e0652b-cac5-4d42-ac13-bea73eb0aa97",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "52325418-54de-4168-ac52-f03c027213f8",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "fab6233d-9a7a-49e4-95af-eab24d69e5d0",
                            TwoFactorEnabled = false,
                            City = "AdminCity",
                            CompanyId = 1,
                            Gender = "Male",
                            Name = "Admin",
                            Region = "AdminRegion",
                            StreetAddress = "AdminHome",
                            userDateJoined = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0))
                        },
                        new
                        {
                            Id = "57cf04cd-8a44-44ce-b6f5-e85f6b082c5e",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "2b69f7ba-6fca-4692-bf24-a708791e207c",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "7662e9c2-d74e-4355-b4d5-d1c16a703781",
                            TwoFactorEnabled = false,
                            City = "Admin1City",
                            CompanyId = 2,
                            Gender = "Male",
                            Name = "Admin1",
                            Region = "Admin1Region",
                            StreetAddress = "Admin1Home",
                            userDateJoined = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0))
                        },
                        new
                        {
                            Id = "c3e14032-200e-437f-b77b-27e632750e77",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "8b19b33a-6679-4bc5-b5ee-405dc20b1fe6",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "0fd95fd2-39d0-4e32-98b4-61f2f84a3002",
                            TwoFactorEnabled = false,
                            City = "Admin2City",
                            CompanyId = 1,
                            Gender = "Male",
                            Name = "Admin2",
                            Region = "Admin2Region",
                            StreetAddress = "Admin2Home",
                            userDateJoined = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0))
                        });
                });

            modelBuilder.Entity("LinkUp_Web.Models.Product", b =>
                {
                    b.HasOne("LinkUp_Web.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LinkUp_Web.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId");

                    b.Navigation("Category");

                    b.Navigation("Company");
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

            modelBuilder.Entity("LinkUp_Web.Models.ApplicationUser", b =>
                {
                    b.HasOne("LinkUp_Web.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId");

                    b.Navigation("Company");
                });
#pragma warning restore 612, 618
        }
    }
}
