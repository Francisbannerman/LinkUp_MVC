using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LinkUp_Web.Migrations
{
    /// <inheritdoc />
    public partial class changeStateToRegion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2d989643-80b9-4a80-95a7-75e4dbdb200a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "499412db-f8c2-4ead-b9f6-645a9dd50a9c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a8257fab-f18b-4607-9783-dfeab0c8c9b3");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "productId",
                keyValue: new Guid("19318628-9983-4d50-bdd5-96b8bd115438"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "productId",
                keyValue: new Guid("5d5b342c-c477-4d12-bab0-c59d9ba8b119"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "productId",
                keyValue: new Guid("d0f164fc-8e2a-472a-a3f0-1c9d2df58aa5"));

            migrationBuilder.RenameColumn(
                name: "State",
                table: "BookingHeaders",
                newName: "Region");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "City", "CompanyId", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "Gender", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Region", "Role", "SecurityStamp", "StreetAddress", "TwoFactorEnabled", "UserName", "userDateJoined" },
                values: new object[,]
                {
                    { "0ff8d8d7-aa07-47a2-9770-73d35e2dfa57", 0, "Admin2City", 1, "9a035629-bd30-4451-8d1b-9400cf329111", "ApplicationUser", null, false, "Male", false, null, "Admin2", null, null, null, null, false, "Admin2Region", null, "705dc3a3-6d1e-4d28-9885-5491a254594e", "Admin2Home", false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { "c7419d8f-ab20-4753-9de9-1a31cb694049", 0, "Admin1City", 2, "59759186-b0d2-4181-83df-98df10f91bf4", "ApplicationUser", null, false, "Male", false, null, "Admin1", null, null, null, null, false, "Admin1Region", null, "91d6d702-33e9-4fa3-8e35-aa11299fc34a", "Admin1Home", false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { "de9d6854-a02f-46a7-9b1f-95582fa9a816", 0, "AdminCity", 1, "a49310d6-9281-4890-ad61-6538292751bb", "ApplicationUser", null, false, "Male", false, null, "Admin", null, null, null, null, false, "AdminRegion", null, "13dc8ce7-c781-4f5e-aa58-e6ecd4c47779", "AdminHome", false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "productId", "CategoryId", "CompanyId", "DisplayPrice", "ImageUrl", "MaxUsers", "MinUsers", "productDateAdded", "productDescription", "productEndDate", "productHighlights", "productLocation", "productStartDate", "productTitle", "supplierPrice" },
                values: new object[,]
                {
                    { new Guid("0caa65f6-abac-4fd1-b782-5ae332a92000"), 2, 2, 120.0, "1dkhdhdhjhvdjh", 11, 3, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "This is an Admin1 product", new DateTimeOffset(new DateTime(2023, 10, 15, 0, 38, 11, 543, DateTimeKind.Unspecified).AddTicks(2370), new TimeSpan(0, 0, 0, 0, 0)), "Admin1 magic content", "Admin1Location", new DateTimeOffset(new DateTime(2023, 10, 8, 0, 38, 11, 543, DateTimeKind.Unspecified).AddTicks(2370), new TimeSpan(0, 0, 0, 0, 0)), "Admin1Product", 90.0 },
                    { new Guid("555b1332-fb69-4b47-a427-7f848efca56f"), 3, 3, 130.0, "2dkhdhdhjhvdjh", 12, 4, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "This is an Admin2 product", new DateTimeOffset(new DateTime(2023, 10, 17, 0, 38, 11, 543, DateTimeKind.Unspecified).AddTicks(2370), new TimeSpan(0, 0, 0, 0, 0)), "Admin2 magic content", "Admin2Location", new DateTimeOffset(new DateTime(2023, 10, 8, 0, 38, 11, 543, DateTimeKind.Unspecified).AddTicks(2370), new TimeSpan(0, 0, 0, 0, 0)), "Admin2Product", 80.0 },
                    { new Guid("c7f95dbd-6b37-423e-bb81-a8b846600b58"), 1, 1, 110.0, "dkhdhdhjhvdjh", 10, 2, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "This is an Admin product", new DateTimeOffset(new DateTime(2023, 10, 13, 0, 38, 11, 543, DateTimeKind.Unspecified).AddTicks(2370), new TimeSpan(0, 0, 0, 0, 0)), "Admin magic content", "AdminLocation", new DateTimeOffset(new DateTime(2023, 10, 8, 0, 38, 11, 543, DateTimeKind.Unspecified).AddTicks(2370), new TimeSpan(0, 0, 0, 0, 0)), "AdminProduct", 100.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0ff8d8d7-aa07-47a2-9770-73d35e2dfa57");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c7419d8f-ab20-4753-9de9-1a31cb694049");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "de9d6854-a02f-46a7-9b1f-95582fa9a816");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "productId",
                keyValue: new Guid("0caa65f6-abac-4fd1-b782-5ae332a92000"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "productId",
                keyValue: new Guid("555b1332-fb69-4b47-a427-7f848efca56f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "productId",
                keyValue: new Guid("c7f95dbd-6b37-423e-bb81-a8b846600b58"));

            migrationBuilder.RenameColumn(
                name: "Region",
                table: "BookingHeaders",
                newName: "State");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "City", "CompanyId", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "Gender", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Region", "Role", "SecurityStamp", "StreetAddress", "TwoFactorEnabled", "UserName", "userDateJoined" },
                values: new object[,]
                {
                    { "2d989643-80b9-4a80-95a7-75e4dbdb200a", 0, "Admin1City", 2, "138d0e59-6c06-443e-bc54-56ea5ab43430", "ApplicationUser", null, false, "Male", false, null, "Admin1", null, null, null, null, false, "Admin1Region", null, "b2667d28-5285-4742-85db-f64da5d000e2", "Admin1Home", false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { "499412db-f8c2-4ead-b9f6-645a9dd50a9c", 0, "AdminCity", 1, "040c8cbe-658f-4970-b5ad-d74882119c0e", "ApplicationUser", null, false, "Male", false, null, "Admin", null, null, null, null, false, "AdminRegion", null, "ed3b3e15-247d-416f-bbad-2a745f843816", "AdminHome", false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { "a8257fab-f18b-4607-9783-dfeab0c8c9b3", 0, "Admin2City", 1, "9fce77da-ac90-417b-bf6b-286417aedc20", "ApplicationUser", null, false, "Male", false, null, "Admin2", null, null, null, null, false, "Admin2Region", null, "2a0d5f4b-c944-4c2d-b672-91b7aa949c07", "Admin2Home", false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "productId", "CategoryId", "CompanyId", "DisplayPrice", "ImageUrl", "MaxUsers", "MinUsers", "productDateAdded", "productDescription", "productEndDate", "productHighlights", "productLocation", "productStartDate", "productTitle", "supplierPrice" },
                values: new object[,]
                {
                    { new Guid("19318628-9983-4d50-bdd5-96b8bd115438"), 3, 3, 130.0, "2dkhdhdhjhvdjh", 12, 4, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "This is an Admin2 product", new DateTimeOffset(new DateTime(2023, 10, 16, 18, 20, 3, 497, DateTimeKind.Unspecified).AddTicks(2100), new TimeSpan(0, 0, 0, 0, 0)), "Admin2 magic content", "Admin2Location", new DateTimeOffset(new DateTime(2023, 10, 7, 18, 20, 3, 497, DateTimeKind.Unspecified).AddTicks(2100), new TimeSpan(0, 0, 0, 0, 0)), "Admin2Product", 80.0 },
                    { new Guid("5d5b342c-c477-4d12-bab0-c59d9ba8b119"), 2, 2, 120.0, "1dkhdhdhjhvdjh", 11, 3, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "This is an Admin1 product", new DateTimeOffset(new DateTime(2023, 10, 14, 18, 20, 3, 497, DateTimeKind.Unspecified).AddTicks(2100), new TimeSpan(0, 0, 0, 0, 0)), "Admin1 magic content", "Admin1Location", new DateTimeOffset(new DateTime(2023, 10, 7, 18, 20, 3, 497, DateTimeKind.Unspecified).AddTicks(2100), new TimeSpan(0, 0, 0, 0, 0)), "Admin1Product", 90.0 },
                    { new Guid("d0f164fc-8e2a-472a-a3f0-1c9d2df58aa5"), 1, 1, 110.0, "dkhdhdhjhvdjh", 10, 2, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "This is an Admin product", new DateTimeOffset(new DateTime(2023, 10, 12, 18, 20, 3, 497, DateTimeKind.Unspecified).AddTicks(2100), new TimeSpan(0, 0, 0, 0, 0)), "Admin magic content", "AdminLocation", new DateTimeOffset(new DateTime(2023, 10, 7, 18, 20, 3, 497, DateTimeKind.Unspecified).AddTicks(2100), new TimeSpan(0, 0, 0, 0, 0)), "AdminProduct", 100.0 }
                });
        }
    }
}
