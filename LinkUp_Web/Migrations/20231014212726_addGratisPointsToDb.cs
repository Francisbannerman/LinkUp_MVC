using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LinkUp_Web.Migrations
{
    /// <inheritdoc />
    public partial class addGratisPointsToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33d74700-bb62-4dcc-81de-851b6dae1eb2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e4ae5e64-0b99-4c22-a34c-e88c0626b0ff");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fc872909-db5a-4adf-a3cc-aedb8a0c45ef");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "productId",
                keyValue: new Guid("def47063-5a59-492b-8ac4-ae548a8cf55e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "productId",
                keyValue: new Guid("e9f8c47b-779b-48f8-b612-87b18f1fd35b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "productId",
                keyValue: new Guid("fd5691f5-fc09-47f0-a68d-cdd75b5d460f"));

            migrationBuilder.CreateTable(
                name: "GratisPoints",
                columns: table => new
                {
                    gratisId = table.Column<Guid>(type: "uuid", nullable: false),
                    Points = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GratisPoints", x => x.gratisId);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "city", "gender", "name", "region", "role", "streetAddress", "userDateJoined" },
                values: new object[,]
                {
                    { "50f1126b-fcd0-4a04-9fb7-983641296c99", 0, "fb34b1a3-cf88-45d1-8848-54eb731ef04f", "ApplicationUser", null, false, false, null, null, null, null, null, false, "615a6e0a-15b6-4f33-bee0-a082f0d96886", false, null, "Admin1City", "Male", "Admin1", "Admin1Region", null, "Admin1Home", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { "d944cc1c-7795-4646-9078-dfa75c2071d3", 0, "0ee468f1-f7eb-4a83-82ef-68b8314c0efe", "ApplicationUser", null, false, false, null, null, null, null, null, false, "d605eb4e-df47-4701-b7db-72a58ab48af2", false, null, "AdminCity", "Male", "Admin", "AdminRegion", null, "AdminHome", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { "f6831143-4e23-40d7-b5bd-7297daa90d06", 0, "05cf959f-2f42-496b-b91f-f4811fc4554c", "ApplicationUser", null, false, false, null, null, null, null, null, false, "7e259c86-1df0-4357-aab8-6f7f9063f536", false, null, "Admin2City", "Male", "Admin2", "Admin2Region", null, "Admin2Home", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "productId", "CategoryId", "categoryId", "displayPrice", "imageUrl", "plusOnesAllowed", "productDateAdded", "productDescription", "productHighlights", "productLocation", "productTitle", "supplierPrice" },
                values: new object[,]
                {
                    { new Guid("daaaeebd-44b2-449c-b69b-f4c3d11cdbde"), null, 1, 110.0, "dkhdhdhjhvdjh", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "This is an Admin product", "Admin magic content", "AdminLocation", "AdminProduct", 100.0 },
                    { new Guid("e90da3c0-d4db-4b43-a971-22f69b74ec88"), null, 2, 120.0, "1dkhdhdhjhvdjh", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "This is an Admin1 product", "Admin1 magic content", "Admin1Location", "Admin1Product", 90.0 },
                    { new Guid("fd34e02b-581e-4d06-a44a-328f0b129142"), null, 3, 130.0, "2dkhdhdhjhvdjh", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "This is an Admin2 product", "Admin2 magic content", "Admin2Location", "Admin2Product", 80.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GratisPoints");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "50f1126b-fcd0-4a04-9fb7-983641296c99");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d944cc1c-7795-4646-9078-dfa75c2071d3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f6831143-4e23-40d7-b5bd-7297daa90d06");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "productId",
                keyValue: new Guid("daaaeebd-44b2-449c-b69b-f4c3d11cdbde"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "productId",
                keyValue: new Guid("e90da3c0-d4db-4b43-a971-22f69b74ec88"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "productId",
                keyValue: new Guid("fd34e02b-581e-4d06-a44a-328f0b129142"));

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "city", "gender", "name", "region", "role", "streetAddress", "userDateJoined" },
                values: new object[,]
                {
                    { "33d74700-bb62-4dcc-81de-851b6dae1eb2", 0, "c87d52d3-0d84-47a6-91b2-e2b7b4e417a3", "ApplicationUser", null, false, false, null, null, null, null, null, false, "d4374685-3646-46be-9fb8-b6dc1e439c7b", false, null, "Admin2City", "Male", "Admin2", "Admin2Region", null, "Admin2Home", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { "e4ae5e64-0b99-4c22-a34c-e88c0626b0ff", 0, "0745b8f5-9aae-41ff-a99d-693659ed4e49", "ApplicationUser", null, false, false, null, null, null, null, null, false, "93f446ae-ebf5-4766-a68d-5e86dc16c264", false, null, "AdminCity", "Male", "Admin", "AdminRegion", null, "AdminHome", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { "fc872909-db5a-4adf-a3cc-aedb8a0c45ef", 0, "6675c1e5-f329-4c40-bd6d-d020f3bb1b9a", "ApplicationUser", null, false, false, null, null, null, null, null, false, "44e93f92-c720-403c-81c7-3eafd59947c6", false, null, "Admin1City", "Male", "Admin1", "Admin1Region", null, "Admin1Home", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "productId", "CategoryId", "categoryId", "displayPrice", "imageUrl", "plusOnesAllowed", "productDateAdded", "productDescription", "productHighlights", "productLocation", "productTitle", "supplierPrice" },
                values: new object[,]
                {
                    { new Guid("def47063-5a59-492b-8ac4-ae548a8cf55e"), null, 1, 110.0, "dkhdhdhjhvdjh", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "This is an Admin product", "Admin magic content", "AdminLocation", "AdminProduct", 100.0 },
                    { new Guid("e9f8c47b-779b-48f8-b612-87b18f1fd35b"), null, 3, 130.0, "2dkhdhdhjhvdjh", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "This is an Admin2 product", "Admin2 magic content", "Admin2Location", "Admin2Product", 80.0 },
                    { new Guid("fd5691f5-fc09-47f0-a68d-cdd75b5d460f"), null, 2, 120.0, "1dkhdhdhjhvdjh", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "This is an Admin1 product", "Admin1 magic content", "Admin1Location", "Admin1Product", 90.0 }
                });
        }
    }
}
