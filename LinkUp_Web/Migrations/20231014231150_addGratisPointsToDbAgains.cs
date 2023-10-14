using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LinkUp_Web.Migrations
{
    /// <inheritdoc />
    public partial class addGratisPointsToDbAgains : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "08051514-fe00-4c8d-8f8f-508504fc2ff5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b625ebdf-ee5c-422a-9e27-a586ea87ba95");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "caecae79-a32f-4a24-9a50-9911aa55c730");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "productId",
                keyValue: new Guid("303b53eb-888f-45ca-8aa4-728c7281f776"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "productId",
                keyValue: new Guid("aa759df0-bed4-4741-ba74-5caa33acf76a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "productId",
                keyValue: new Guid("b869f5b7-b840-4895-ba6a-e3e02d0a563c"));

            migrationBuilder.AddColumn<int>(
                name: "gratisPoint",
                table: "AspNetUsers",
                type: "integer",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "city", "gender", "gratisPoint", "name", "referralCode", "region", "role", "streetAddress", "userDateJoined" },
                values: new object[,]
                {
                    { "37a5e1fd-3fa9-4f51-94c5-fa9ba7971d40", 0, "1ee4498f-73e5-4b82-b78f-c568df14b020", "ApplicationUser", null, false, false, null, null, null, null, null, false, "a01892e8-22a7-48f5-ad29-3d750b724bbc", false, null, "Admin2City", "Male", 0, "Admin2", null, "Admin2Region", null, "Admin2Home", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { "f3ea56eb-d177-4012-8bfc-b187d98f22e8", 0, "9e109040-75f2-4a6f-bad7-e4371ed2d397", "ApplicationUser", null, false, false, null, null, null, null, null, false, "7973ac65-b479-4a88-85c2-6334e63edb3c", false, null, "Admin1City", "Male", 0, "Admin1", null, "Admin1Region", null, "Admin1Home", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { "f6e7a07e-eb25-4057-8c39-8bb1f639f368", 0, "aa3bdfb2-9292-44fd-bc7a-b7080ed1844f", "ApplicationUser", null, false, false, null, null, null, null, null, false, "d1e3999f-ce1c-4398-ad12-ef4b3d693e0b", false, null, "AdminCity", "Male", 0, "Admin", null, "AdminRegion", null, "AdminHome", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "productId", "CategoryId", "categoryId", "displayPrice", "imageUrl", "plusOnesAllowed", "productDateAdded", "productDescription", "productHighlights", "productLocation", "productTitle", "supplierPrice" },
                values: new object[,]
                {
                    { new Guid("a5147279-7f3e-4e17-b487-4e85ab2fd7ad"), null, 3, 130.0, "2dkhdhdhjhvdjh", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "This is an Admin2 product", "Admin2 magic content", "Admin2Location", "Admin2Product", 80.0 },
                    { new Guid("b8d848aa-2b40-4e80-a72b-7821e88a3961"), null, 1, 110.0, "dkhdhdhjhvdjh", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "This is an Admin product", "Admin magic content", "AdminLocation", "AdminProduct", 100.0 },
                    { new Guid("e65dc14e-a2bc-4896-8afd-59fd27e68245"), null, 2, 120.0, "1dkhdhdhjhvdjh", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "This is an Admin1 product", "Admin1 magic content", "Admin1Location", "Admin1Product", 90.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "37a5e1fd-3fa9-4f51-94c5-fa9ba7971d40");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f3ea56eb-d177-4012-8bfc-b187d98f22e8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f6e7a07e-eb25-4057-8c39-8bb1f639f368");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "productId",
                keyValue: new Guid("a5147279-7f3e-4e17-b487-4e85ab2fd7ad"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "productId",
                keyValue: new Guid("b8d848aa-2b40-4e80-a72b-7821e88a3961"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "productId",
                keyValue: new Guid("e65dc14e-a2bc-4896-8afd-59fd27e68245"));

            migrationBuilder.DropColumn(
                name: "gratisPoint",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "city", "gender", "name", "referralCode", "region", "role", "streetAddress", "userDateJoined" },
                values: new object[,]
                {
                    { "08051514-fe00-4c8d-8f8f-508504fc2ff5", 0, "3ee23ce6-3dbb-406f-8254-a9280e4a85e0", "ApplicationUser", null, false, false, null, null, null, null, null, false, "089e7096-35c2-43e4-993e-f41cc272496b", false, null, "Admin1City", "Male", "Admin1", null, "Admin1Region", null, "Admin1Home", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { "b625ebdf-ee5c-422a-9e27-a586ea87ba95", 0, "640ce5ef-6955-4493-b6a5-6d6eece90a93", "ApplicationUser", null, false, false, null, null, null, null, null, false, "b00e4a12-733b-42a3-8e6f-01b76a63909c", false, null, "Admin2City", "Male", "Admin2", null, "Admin2Region", null, "Admin2Home", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { "caecae79-a32f-4a24-9a50-9911aa55c730", 0, "f7b0bce9-d012-4120-87b1-b6247bd2a744", "ApplicationUser", null, false, false, null, null, null, null, null, false, "930b670a-04dd-4ab4-818f-4a5e97b49079", false, null, "AdminCity", "Male", "Admin", null, "AdminRegion", null, "AdminHome", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "productId", "CategoryId", "categoryId", "displayPrice", "imageUrl", "plusOnesAllowed", "productDateAdded", "productDescription", "productHighlights", "productLocation", "productTitle", "supplierPrice" },
                values: new object[,]
                {
                    { new Guid("303b53eb-888f-45ca-8aa4-728c7281f776"), null, 2, 120.0, "1dkhdhdhjhvdjh", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "This is an Admin1 product", "Admin1 magic content", "Admin1Location", "Admin1Product", 90.0 },
                    { new Guid("aa759df0-bed4-4741-ba74-5caa33acf76a"), null, 3, 130.0, "2dkhdhdhjhvdjh", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "This is an Admin2 product", "Admin2 magic content", "Admin2Location", "Admin2Product", 80.0 },
                    { new Guid("b869f5b7-b840-4895-ba6a-e3e02d0a563c"), null, 1, 110.0, "dkhdhdhjhvdjh", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "This is an Admin product", "Admin magic content", "AdminLocation", "AdminProduct", 100.0 }
                });
        }
    }
}
