using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LinkUp_Web.Migrations
{
    /// <inheritdoc />
    public partial class addGratisPointsPackagesAgn7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "09bc1e7a-216b-4f1c-8ee8-59d1d7c5095d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32abdb54-4d25-4040-92fe-b312e3a1f400");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "54288bca-7f63-4aa2-903a-6f908f38d977");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "productId",
                keyValue: new Guid("07044046-6729-4055-a87b-2c7cb4049798"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "productId",
                keyValue: new Guid("a1e956d7-515d-4de5-b6ae-74e567eac704"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "productId",
                keyValue: new Guid("cfafb92c-efa0-4b13-9804-fb2f4b4ea2f6"));

            migrationBuilder.AddColumn<double>(
                name: "price",
                table: "Bookings",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "city", "gender", "gratisPoint", "name", "referralCode", "region", "role", "streetAddress", "userDateJoined" },
                values: new object[,]
                {
                    { "77209cdd-730f-42b5-a0e9-b11c87e93b1a", 0, "ffb1d13d-c726-4b5d-a8f9-7c27a02287a5", "ApplicationUser", null, false, false, null, null, null, null, null, false, "46a28ea5-5b40-48d4-97d6-8d2e7a5ad910", false, null, "AdminCity", "Male", 0, "Admin", null, "AdminRegion", null, "AdminHome", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { "c3a86495-6cea-4622-b049-ecd3c63e2023", 0, "6d4ca2e8-2377-478b-bdd1-26f1184abe93", "ApplicationUser", null, false, false, null, null, null, null, null, false, "35a66c9e-f22f-4c4e-9d2a-2d9e335b8438", false, null, "Admin1City", "Male", 0, "Admin1", null, "Admin1Region", null, "Admin1Home", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { "e695c55a-e195-4dbf-a5a2-bf0ff291876d", 0, "9f4250c9-8f9a-4d54-8e9a-fc374d77abdc", "ApplicationUser", null, false, false, null, null, null, null, null, false, "4ea88016-36cb-4061-afd3-d4eee5e95ea3", false, null, "Admin2City", "Male", 0, "Admin2", null, "Admin2Region", null, "Admin2Home", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "productId", "CategoryId", "categoryId", "displayPrice", "imageUrl", "plusOnesAllowed", "productDateAdded", "productDescription", "productHighlights", "productLocation", "productTitle", "supplierPrice" },
                values: new object[,]
                {
                    { new Guid("46e80a85-8839-4933-8ac9-c461442be9aa"), null, 2, 120.0, "1dkhdhdhjhvdjh", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "This is an Admin1 product", "Admin1 magic content", "Admin1Location", "Admin1Product", 90.0 },
                    { new Guid("8138a0a0-8896-4a34-aedf-0720835fa9b9"), null, 1, 110.0, "dkhdhdhjhvdjh", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "This is an Admin product", "Admin magic content", "AdminLocation", "AdminProduct", 100.0 },
                    { new Guid("82919801-6aca-4366-9c27-af1dec586423"), null, 3, 130.0, "2dkhdhdhjhvdjh", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "This is an Admin2 product", "Admin2 magic content", "Admin2Location", "Admin2Product", 80.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "77209cdd-730f-42b5-a0e9-b11c87e93b1a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3a86495-6cea-4622-b049-ecd3c63e2023");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e695c55a-e195-4dbf-a5a2-bf0ff291876d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "productId",
                keyValue: new Guid("46e80a85-8839-4933-8ac9-c461442be9aa"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "productId",
                keyValue: new Guid("8138a0a0-8896-4a34-aedf-0720835fa9b9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "productId",
                keyValue: new Guid("82919801-6aca-4366-9c27-af1dec586423"));

            migrationBuilder.DropColumn(
                name: "price",
                table: "Bookings");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "city", "gender", "gratisPoint", "name", "referralCode", "region", "role", "streetAddress", "userDateJoined" },
                values: new object[,]
                {
                    { "09bc1e7a-216b-4f1c-8ee8-59d1d7c5095d", 0, "24e1b905-6afd-4ac5-8331-64a23f3092d4", "ApplicationUser", null, false, false, null, null, null, null, null, false, "d0b494be-a996-4425-be6f-feb9e3f4d727", false, null, "AdminCity", "Male", 0, "Admin", null, "AdminRegion", null, "AdminHome", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { "32abdb54-4d25-4040-92fe-b312e3a1f400", 0, "22537769-0cdb-4749-aee5-ff3f83be067a", "ApplicationUser", null, false, false, null, null, null, null, null, false, "2280cef0-69a0-4d57-b630-78ef348bf285", false, null, "Admin2City", "Male", 0, "Admin2", null, "Admin2Region", null, "Admin2Home", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { "54288bca-7f63-4aa2-903a-6f908f38d977", 0, "90949ba7-816e-47a6-b949-b9af28f76f37", "ApplicationUser", null, false, false, null, null, null, null, null, false, "6470daa0-b8f5-465f-8817-041c6886999f", false, null, "Admin1City", "Male", 0, "Admin1", null, "Admin1Region", null, "Admin1Home", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "productId", "CategoryId", "categoryId", "displayPrice", "imageUrl", "plusOnesAllowed", "productDateAdded", "productDescription", "productHighlights", "productLocation", "productTitle", "supplierPrice" },
                values: new object[,]
                {
                    { new Guid("07044046-6729-4055-a87b-2c7cb4049798"), null, 2, 120.0, "1dkhdhdhjhvdjh", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "This is an Admin1 product", "Admin1 magic content", "Admin1Location", "Admin1Product", 90.0 },
                    { new Guid("a1e956d7-515d-4de5-b6ae-74e567eac704"), null, 1, 110.0, "dkhdhdhjhvdjh", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "This is an Admin product", "Admin magic content", "AdminLocation", "AdminProduct", 100.0 },
                    { new Guid("cfafb92c-efa0-4b13-9804-fb2f4b4ea2f6"), null, 3, 130.0, "2dkhdhdhjhvdjh", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "This is an Admin2 product", "Admin2 magic content", "Admin2Location", "Admin2Product", 80.0 }
                });
        }
    }
}
