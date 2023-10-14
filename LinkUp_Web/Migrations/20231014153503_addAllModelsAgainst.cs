using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LinkUp_Web.Migrations
{
    /// <inheritdoc />
    public partial class addAllModelsAgainst : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookingDetails_Products_ProductId",
                table: "BookingDetails");

            migrationBuilder.DropIndex(
                name: "IX_BookingDetails_ProductId",
                table: "BookingDetails");

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

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "BookingDetails");

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

            migrationBuilder.CreateIndex(
                name: "IX_BookingDetails_productId",
                table: "BookingDetails",
                column: "productId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookingDetails_Products_productId",
                table: "BookingDetails",
                column: "productId",
                principalTable: "Products",
                principalColumn: "productId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookingDetails_Products_productId",
                table: "BookingDetails");

            migrationBuilder.DropIndex(
                name: "IX_BookingDetails_productId",
                table: "BookingDetails");

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

            migrationBuilder.AddColumn<Guid>(
                name: "ProductId",
                table: "BookingDetails",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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

            migrationBuilder.CreateIndex(
                name: "IX_BookingDetails_ProductId",
                table: "BookingDetails",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookingDetails_Products_ProductId",
                table: "BookingDetails",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "productId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
