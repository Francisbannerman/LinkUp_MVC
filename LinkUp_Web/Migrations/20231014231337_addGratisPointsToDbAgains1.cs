using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LinkUp_Web.Migrations
{
    /// <inheritdoc />
    public partial class addGratisPointsToDbAgains1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "city", "gender", "gratisPoint", "name", "referralCode", "region", "role", "streetAddress", "userDateJoined" },
                values: new object[,]
                {
                    { "480605e2-bd63-4d7d-adc4-ee6c2e8eb557", 0, "efd4ac29-329e-4b9e-93a8-f1cb3e37d64f", "ApplicationUser", null, false, false, null, null, null, null, null, false, "94422d97-85c5-4e7a-92b6-d48e28003362", false, null, "Admin1City", "Male", 0, "Admin1", null, "Admin1Region", null, "Admin1Home", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { "e5cd6940-2c18-47a6-a358-c1e31f2e9d2a", 0, "c79c8903-04ab-45b9-86cc-57720af12d64", "ApplicationUser", null, false, false, null, null, null, null, null, false, "4907b95c-0b65-43da-a948-dfa041c1bf14", false, null, "Admin2City", "Male", 0, "Admin2", null, "Admin2Region", null, "Admin2Home", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { "fe058020-82a3-4310-9407-87136170135d", 0, "904ef363-98cb-4a60-9f69-7b3dc3caf82a", "ApplicationUser", null, false, false, null, null, null, null, null, false, "c65af397-d317-49d6-aa6e-c008cccb7768", false, null, "AdminCity", "Male", 0, "Admin", null, "AdminRegion", null, "AdminHome", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "productId", "CategoryId", "categoryId", "displayPrice", "imageUrl", "plusOnesAllowed", "productDateAdded", "productDescription", "productHighlights", "productLocation", "productTitle", "supplierPrice" },
                values: new object[,]
                {
                    { new Guid("127442fc-9540-4129-bc2a-769905c54298"), null, 3, 130.0, "2dkhdhdhjhvdjh", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "This is an Admin2 product", "Admin2 magic content", "Admin2Location", "Admin2Product", 80.0 },
                    { new Guid("a39171a7-423e-45ae-8167-3db17cc68e67"), null, 2, 120.0, "1dkhdhdhjhvdjh", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "This is an Admin1 product", "Admin1 magic content", "Admin1Location", "Admin1Product", 90.0 },
                    { new Guid("d4b52926-e221-4457-88b5-ba1f0eb65810"), null, 1, 110.0, "dkhdhdhjhvdjh", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "This is an Admin product", "Admin magic content", "AdminLocation", "AdminProduct", 100.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "480605e2-bd63-4d7d-adc4-ee6c2e8eb557");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e5cd6940-2c18-47a6-a358-c1e31f2e9d2a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fe058020-82a3-4310-9407-87136170135d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "productId",
                keyValue: new Guid("127442fc-9540-4129-bc2a-769905c54298"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "productId",
                keyValue: new Guid("a39171a7-423e-45ae-8167-3db17cc68e67"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "productId",
                keyValue: new Guid("d4b52926-e221-4457-88b5-ba1f0eb65810"));

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
    }
}
