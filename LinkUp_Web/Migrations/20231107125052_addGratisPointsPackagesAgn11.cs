using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LinkUp_Web.Migrations
{
    /// <inheritdoc />
    public partial class addGratisPointsPackagesAgn11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14f6a069-059c-482f-ad35-a1c7fd3daf09");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "55d26ab7-da37-407f-9bfd-7287688a24c0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b82f8032-33be-4e61-80b5-c8252809637e");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "productId",
                keyValue: new Guid("08bcd912-ae4b-46eb-a6cf-98a4ef71a2cf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "productId",
                keyValue: new Guid("463514bf-ca80-49bf-bad4-0e9d434fa1e9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "productId",
                keyValue: new Guid("bdbe2b5f-d676-44ab-a3fd-d2a0073e66b8"));

            migrationBuilder.AddColumn<int>(
                name: "referredUsers",
                table: "AspNetUsers",
                type: "integer",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "city", "gender", "gratisPoint", "name", "referralCode", "referredCode", "referredUsers", "region", "role", "streetAddress", "userDateJoined" },
                values: new object[,]
                {
                    { "5d1da9d8-2da1-429d-9d35-cca0aa0e2fd7", 0, "6111036b-9456-464f-99fc-2b627ff71f54", "ApplicationUser", null, false, false, null, null, null, null, null, false, "4d0b2487-df4f-4f43-96bb-328c4a1885c7", false, null, "AdminCity", "Male", 0, "Admin", null, null, 0, "AdminRegion", null, "AdminHome", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { "7e4c66c2-bd07-4549-8b44-3736a92ee996", 0, "754b743c-3677-4645-ae9f-259aac18fead", "ApplicationUser", null, false, false, null, null, null, null, null, false, "b7c5cfe8-4c88-4ecc-aea5-68642d10fd08", false, null, "Admin2City", "Male", 0, "Admin2", null, null, 0, "Admin2Region", null, "Admin2Home", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { "c2da4801-f37d-4b83-aa59-a9892d6f1c0c", 0, "516c3308-179e-476c-b91e-35a33ffc09e3", "ApplicationUser", null, false, false, null, null, null, null, null, false, "51764bef-49a8-44ff-90b7-28e6a883ef27", false, null, "Admin1City", "Male", 0, "Admin1", null, null, 0, "Admin1Region", null, "Admin1Home", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "productId", "CategoryId", "categoryId", "displayPrice", "imageUrl", "plusOnesAllowed", "productDateAdded", "productDescription", "productHighlights", "productLocation", "productTitle", "supplierPrice" },
                values: new object[,]
                {
                    { new Guid("3d76356d-34d9-442d-9330-fbae88ab3e30"), null, 1, 110.0, "dkhdhdhjhvdjh", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "This is an Admin product", "Admin magic content", "AdminLocation", "AdminProduct", 100.0 },
                    { new Guid("b9bc844a-2caf-45b4-8798-f697b4ad7366"), null, 2, 120.0, "1dkhdhdhjhvdjh", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "This is an Admin1 product", "Admin1 magic content", "Admin1Location", "Admin1Product", 90.0 },
                    { new Guid("fa5d19b7-81de-41b4-ac1b-fbcae7c98c9e"), null, 3, 130.0, "2dkhdhdhjhvdjh", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "This is an Admin2 product", "Admin2 magic content", "Admin2Location", "Admin2Product", 80.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5d1da9d8-2da1-429d-9d35-cca0aa0e2fd7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7e4c66c2-bd07-4549-8b44-3736a92ee996");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c2da4801-f37d-4b83-aa59-a9892d6f1c0c");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "productId",
                keyValue: new Guid("3d76356d-34d9-442d-9330-fbae88ab3e30"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "productId",
                keyValue: new Guid("b9bc844a-2caf-45b4-8798-f697b4ad7366"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "productId",
                keyValue: new Guid("fa5d19b7-81de-41b4-ac1b-fbcae7c98c9e"));

            migrationBuilder.DropColumn(
                name: "referredUsers",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "city", "gender", "gratisPoint", "name", "referralCode", "referredCode", "region", "role", "streetAddress", "userDateJoined" },
                values: new object[,]
                {
                    { "14f6a069-059c-482f-ad35-a1c7fd3daf09", 0, "c9382e2e-83c5-4bb7-be9e-4757bb5d888f", "ApplicationUser", null, false, false, null, null, null, null, null, false, "f3133097-b1cb-4fc9-9d83-6a30a6680897", false, null, "Admin2City", "Male", 0, "Admin2", null, null, "Admin2Region", null, "Admin2Home", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { "55d26ab7-da37-407f-9bfd-7287688a24c0", 0, "43f3e59d-fdfd-484c-b096-87be27cec516", "ApplicationUser", null, false, false, null, null, null, null, null, false, "b0e39ad1-1ff1-42e1-870d-435219bb93e5", false, null, "Admin1City", "Male", 0, "Admin1", null, null, "Admin1Region", null, "Admin1Home", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { "b82f8032-33be-4e61-80b5-c8252809637e", 0, "5c9c41a6-d744-4f26-a207-c3b1a7e586f7", "ApplicationUser", null, false, false, null, null, null, null, null, false, "1b52b754-28fb-4cfc-bbbc-1123e5a8a22a", false, null, "AdminCity", "Male", 0, "Admin", null, null, "AdminRegion", null, "AdminHome", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "productId", "CategoryId", "categoryId", "displayPrice", "imageUrl", "plusOnesAllowed", "productDateAdded", "productDescription", "productHighlights", "productLocation", "productTitle", "supplierPrice" },
                values: new object[,]
                {
                    { new Guid("08bcd912-ae4b-46eb-a6cf-98a4ef71a2cf"), null, 3, 130.0, "2dkhdhdhjhvdjh", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "This is an Admin2 product", "Admin2 magic content", "Admin2Location", "Admin2Product", 80.0 },
                    { new Guid("463514bf-ca80-49bf-bad4-0e9d434fa1e9"), null, 2, 120.0, "1dkhdhdhjhvdjh", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "This is an Admin1 product", "Admin1 magic content", "Admin1Location", "Admin1Product", 90.0 },
                    { new Guid("bdbe2b5f-d676-44ab-a3fd-d2a0073e66b8"), null, 1, 110.0, "dkhdhdhjhvdjh", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "This is an Admin product", "Admin magic content", "AdminLocation", "AdminProduct", 100.0 }
                });
        }
    }
}
