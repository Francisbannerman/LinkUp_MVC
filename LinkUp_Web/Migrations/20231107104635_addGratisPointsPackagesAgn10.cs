using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LinkUp_Web.Migrations
{
    /// <inheritdoc />
    public partial class addGratisPointsPackagesAgn10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2aacd358-7944-4534-9f57-9d83c65d3563");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "78400991-1163-4938-bb02-e1e35db7c6eb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c5ba4061-af21-4f47-bcd9-a829d389a839");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "productId",
                keyValue: new Guid("5c9fd3b4-7db6-4ad5-9e4b-fc93ab4b3c97"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "productId",
                keyValue: new Guid("c94e39b0-1782-416a-b3e8-4323e288f076"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "productId",
                keyValue: new Guid("d26c6553-7d63-4c8f-9022-f75cb14d3c53"));

            migrationBuilder.AddColumn<string>(
                name: "referredCode",
                table: "AspNetUsers",
                type: "text",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "referredCode",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "city", "gender", "gratisPoint", "name", "referralCode", "region", "role", "streetAddress", "userDateJoined" },
                values: new object[,]
                {
                    { "2aacd358-7944-4534-9f57-9d83c65d3563", 0, "25650002-8dfc-467d-9b86-8dc930bca7b0", "ApplicationUser", null, false, false, null, null, null, null, null, false, "2fcca26e-b53f-4868-b955-65f022ba0465", false, null, "Admin1City", "Male", 0, "Admin1", null, "Admin1Region", null, "Admin1Home", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { "78400991-1163-4938-bb02-e1e35db7c6eb", 0, "7f94c3ef-32f9-40e4-9b5f-1addd8731e6a", "ApplicationUser", null, false, false, null, null, null, null, null, false, "451ea15a-c282-4591-8be2-1461a004d43d", false, null, "Admin2City", "Male", 0, "Admin2", null, "Admin2Region", null, "Admin2Home", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { "c5ba4061-af21-4f47-bcd9-a829d389a839", 0, "d1b03149-42a9-4932-88e9-d5a918c09f24", "ApplicationUser", null, false, false, null, null, null, null, null, false, "47a84ccb-0c47-4765-96dd-1960c5fa1d40", false, null, "AdminCity", "Male", 0, "Admin", null, "AdminRegion", null, "AdminHome", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "productId", "CategoryId", "categoryId", "displayPrice", "imageUrl", "plusOnesAllowed", "productDateAdded", "productDescription", "productHighlights", "productLocation", "productTitle", "supplierPrice" },
                values: new object[,]
                {
                    { new Guid("5c9fd3b4-7db6-4ad5-9e4b-fc93ab4b3c97"), null, 3, 130.0, "2dkhdhdhjhvdjh", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "This is an Admin2 product", "Admin2 magic content", "Admin2Location", "Admin2Product", 80.0 },
                    { new Guid("c94e39b0-1782-416a-b3e8-4323e288f076"), null, 2, 120.0, "1dkhdhdhjhvdjh", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "This is an Admin1 product", "Admin1 magic content", "Admin1Location", "Admin1Product", 90.0 },
                    { new Guid("d26c6553-7d63-4c8f-9022-f75cb14d3c53"), null, 1, 110.0, "dkhdhdhjhvdjh", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "This is an Admin product", "Admin magic content", "AdminLocation", "AdminProduct", 100.0 }
                });
        }
    }
}
