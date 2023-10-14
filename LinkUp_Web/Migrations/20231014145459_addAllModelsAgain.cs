using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LinkUp_Web.Migrations
{
    /// <inheritdoc />
    public partial class addAllModelsAgain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "848b248e-4eb5-4733-9947-f1b6b5489fb0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c58d66e3-522c-4e91-a4b7-2b10371e4cf5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd641f2f-6e07-422e-b45d-4748e060bef1");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "productId",
                keyValue: new Guid("2e2f3573-ecc1-410e-ad37-5e690d6e56a6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "productId",
                keyValue: new Guid("54eb214e-c7be-41ee-a5d3-f87e3d31aa8d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "productId",
                keyValue: new Guid("8edb2677-2e86-468f-a4d9-537385632d13"));

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "city", "gender", "name", "region", "role", "streetAddress", "userDateJoined" },
                values: new object[,]
                {
                    { "5d0dc929-4602-4d52-bf96-d3ee25847356", 0, "e670dec5-d513-4e60-8ba9-cc373440b8ee", "ApplicationUser", null, false, false, null, null, null, null, null, false, "40a72777-9a28-40e3-8ae2-f4dddf872b7c", false, null, "AdminCity", "Male", "Admin", "AdminRegion", null, "AdminHome", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { "64eb86c6-4f8d-4ad9-b927-18efc20f0b80", 0, "8dafc31a-3b10-4cc9-825d-f8c5d844d4c2", "ApplicationUser", null, false, false, null, null, null, null, null, false, "7afd2407-312c-4d83-99af-2f79612afae8", false, null, "Admin1City", "Male", "Admin1", "Admin1Region", null, "Admin1Home", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { "a29794d4-203e-4e63-bcf2-c810e3597b80", 0, "62b3a21b-2496-4188-b5e5-14a76ef7cea6", "ApplicationUser", null, false, false, null, null, null, null, null, false, "a058c5cc-5c01-49c3-a623-7e198b328cf9", false, null, "Admin2City", "Male", "Admin2", "Admin2Region", null, "Admin2Home", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "productId", "CategoryId", "categoryId", "displayPrice", "imageUrl", "plusOnesAllowed", "productDateAdded", "productDescription", "productHighlights", "productLocation", "productTitle", "supplierPrice" },
                values: new object[,]
                {
                    { new Guid("61903d36-88ca-4af3-8167-68cf9aade2c0"), null, 1, 110.0, "dkhdhdhjhvdjh", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "This is an Admin product", "Admin magic content", "AdminLocation", "AdminProduct", 100.0 },
                    { new Guid("75234763-7da8-4136-b1f6-3d06fcb6220f"), null, 3, 130.0, "2dkhdhdhjhvdjh", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "This is an Admin2 product", "Admin2 magic content", "Admin2Location", "Admin2Product", 80.0 },
                    { new Guid("bbfcd74a-d9a7-43e1-b8c0-1bf80542e17c"), null, 2, 120.0, "1dkhdhdhjhvdjh", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "This is an Admin1 product", "Admin1 magic content", "Admin1Location", "Admin1Product", 90.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5d0dc929-4602-4d52-bf96-d3ee25847356");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "64eb86c6-4f8d-4ad9-b927-18efc20f0b80");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a29794d4-203e-4e63-bcf2-c810e3597b80");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "productId",
                keyValue: new Guid("61903d36-88ca-4af3-8167-68cf9aade2c0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "productId",
                keyValue: new Guid("75234763-7da8-4136-b1f6-3d06fcb6220f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "productId",
                keyValue: new Guid("bbfcd74a-d9a7-43e1-b8c0-1bf80542e17c"));

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "city", "gender", "name", "region", "role", "streetAddress", "userDateJoined" },
                values: new object[,]
                {
                    { "848b248e-4eb5-4733-9947-f1b6b5489fb0", 0, "5a342f01-1895-437e-a6e4-269e2db6d3ab", "ApplicationUser", null, false, false, null, null, null, null, null, false, "e2789892-09a1-499e-85f2-946b980579b1", false, null, "Admin2City", "Male", "Admin2", "Admin2Region", null, "Admin2Home", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { "c58d66e3-522c-4e91-a4b7-2b10371e4cf5", 0, "f50215f9-6652-44e1-ba13-019c403957fd", "ApplicationUser", null, false, false, null, null, null, null, null, false, "c5bcbd1a-ff79-425f-a668-a299cc14a013", false, null, "Admin1City", "Male", "Admin1", "Admin1Region", null, "Admin1Home", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { "fd641f2f-6e07-422e-b45d-4748e060bef1", 0, "f9082cca-8748-4ade-a08d-e63fff20a361", "ApplicationUser", null, false, false, null, null, null, null, null, false, "2d1a1357-54be-411f-973e-4436de2bba4d", false, null, "AdminCity", "Male", "Admin", "AdminRegion", null, "AdminHome", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "productId", "CategoryId", "categoryId", "displayPrice", "imageUrl", "plusOnesAllowed", "productDateAdded", "productDescription", "productHighlights", "productLocation", "productTitle", "supplierPrice" },
                values: new object[,]
                {
                    { new Guid("2e2f3573-ecc1-410e-ad37-5e690d6e56a6"), null, 3, 130.0, "2dkhdhdhjhvdjh", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "This is an Admin2 product", "Admin2 magic content", "Admin2Location", "Admin2Product", 80.0 },
                    { new Guid("54eb214e-c7be-41ee-a5d3-f87e3d31aa8d"), null, 1, 110.0, "dkhdhdhjhvdjh", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "This is an Admin product", "Admin magic content", "AdminLocation", "AdminProduct", 100.0 },
                    { new Guid("8edb2677-2e86-468f-a4d9-537385632d13"), null, 2, 120.0, "1dkhdhdhjhvdjh", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "This is an Admin1 product", "Admin1 magic content", "Admin1Location", "Admin1Product", 90.0 }
                });
        }
    }
}
