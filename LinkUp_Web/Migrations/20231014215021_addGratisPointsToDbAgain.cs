using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LinkUp_Web.Migrations
{
    /// <inheritdoc />
    public partial class addGratisPointsToDbAgain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_GratisPoints",
                table: "GratisPoints");

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

            migrationBuilder.DropColumn(
                name: "gratisId",
                table: "GratisPoints");

            migrationBuilder.AddColumn<string>(
                name: "applicationUserId",
                table: "GratisPoints",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "referralCode",
                table: "AspNetUsers",
                type: "text",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_GratisPoints",
                table: "GratisPoints",
                column: "applicationUserId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_GratisPoints_AspNetUsers_applicationUserId",
                table: "GratisPoints",
                column: "applicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GratisPoints_AspNetUsers_applicationUserId",
                table: "GratisPoints");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GratisPoints",
                table: "GratisPoints");

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

            migrationBuilder.DropColumn(
                name: "applicationUserId",
                table: "GratisPoints");

            migrationBuilder.DropColumn(
                name: "referralCode",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<Guid>(
                name: "gratisId",
                table: "GratisPoints",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_GratisPoints",
                table: "GratisPoints",
                column: "gratisId");

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
    }
}
