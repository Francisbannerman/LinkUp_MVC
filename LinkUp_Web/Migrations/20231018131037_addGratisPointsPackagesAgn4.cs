using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LinkUp_Web.Migrations
{
    /// <inheritdoc />
    public partial class addGratisPointsPackagesAgn4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8fafef80-7d5e-42d4-b63a-f3866ca03a63");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bc009560-3e92-4a13-987d-24208a441a1b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e97b649a-8d5f-4297-8107-4d137b7dc496");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "productId",
                keyValue: new Guid("0fc2e368-5ff3-4c33-9c5f-831bd07528d8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "productId",
                keyValue: new Guid("a6653d45-e804-436a-98f9-9e5ddda0c658"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "productId",
                keyValue: new Guid("f8ed7a46-b1db-4cdb-85fb-91863e042faf"));

            migrationBuilder.DropColumn(
                name: "paymentIntentId",
                table: "BookingHeaders");

            migrationBuilder.DropColumn(
                name: "paymentStatus",
                table: "BookingHeaders");

            migrationBuilder.DropColumn(
                name: "sessionId",
                table: "BookingHeaders");

            migrationBuilder.CreateTable(
                name: "GratisPurchases",
                columns: table => new
                {
                    gratisPurchaseId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    gratisPointQuantity = table.Column<int>(type: "integer", nullable: false),
                    amountForGratisPoint = table.Column<int>(type: "integer", nullable: false),
                    datePurchased = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    paymentStatus = table.Column<string>(type: "text", nullable: true),
                    sessionId = table.Column<string>(type: "text", nullable: true),
                    paymentIntentId = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GratisPurchases", x => x.gratisPurchaseId);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "city", "gender", "gratisPoint", "name", "referralCode", "region", "role", "streetAddress", "userDateJoined" },
                values: new object[,]
                {
                    { "061f615f-1ba8-4e37-9c22-d9d5c098cde8", 0, "00316e0a-f22a-4e24-b57b-26723dce9056", "ApplicationUser", null, false, false, null, null, null, null, null, false, "500bae0b-244b-4466-a934-d3653ab092eb", false, null, "Admin1City", "Male", 0, "Admin1", null, "Admin1Region", null, "Admin1Home", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { "06a6d5bb-09ed-41b3-99c3-6d389b0dc655", 0, "f05ae7bf-2664-4c84-bb4c-bc32716bca65", "ApplicationUser", null, false, false, null, null, null, null, null, false, "0d4b6f0d-e3ba-420a-9a44-24b6219e3b82", false, null, "Admin2City", "Male", 0, "Admin2", null, "Admin2Region", null, "Admin2Home", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { "779cd6c8-7038-48e5-8ba6-61eed2217656", 0, "39174fde-9f50-4b9c-b7be-6604d9235e38", "ApplicationUser", null, false, false, null, null, null, null, null, false, "c2563a08-9153-4f4b-bdd0-8e20b4c4d8a6", false, null, "AdminCity", "Male", 0, "Admin", null, "AdminRegion", null, "AdminHome", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "productId", "CategoryId", "categoryId", "displayPrice", "imageUrl", "plusOnesAllowed", "productDateAdded", "productDescription", "productHighlights", "productLocation", "productTitle", "supplierPrice" },
                values: new object[,]
                {
                    { new Guid("10827db7-4de5-46e0-8506-5dd4ec4c0e62"), null, 1, 110.0, "dkhdhdhjhvdjh", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "This is an Admin product", "Admin magic content", "AdminLocation", "AdminProduct", 100.0 },
                    { new Guid("2b1eee9f-251f-421b-806a-dbfd8fbbff2d"), null, 2, 120.0, "1dkhdhdhjhvdjh", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "This is an Admin1 product", "Admin1 magic content", "Admin1Location", "Admin1Product", 90.0 },
                    { new Guid("b4d849ae-59ea-4525-b63c-ab5c6ba43e5c"), null, 3, 130.0, "2dkhdhdhjhvdjh", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "This is an Admin2 product", "Admin2 magic content", "Admin2Location", "Admin2Product", 80.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GratisPurchases");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "061f615f-1ba8-4e37-9c22-d9d5c098cde8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "06a6d5bb-09ed-41b3-99c3-6d389b0dc655");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "779cd6c8-7038-48e5-8ba6-61eed2217656");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "productId",
                keyValue: new Guid("10827db7-4de5-46e0-8506-5dd4ec4c0e62"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "productId",
                keyValue: new Guid("2b1eee9f-251f-421b-806a-dbfd8fbbff2d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "productId",
                keyValue: new Guid("b4d849ae-59ea-4525-b63c-ab5c6ba43e5c"));

            migrationBuilder.AddColumn<string>(
                name: "paymentIntentId",
                table: "BookingHeaders",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "paymentStatus",
                table: "BookingHeaders",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "sessionId",
                table: "BookingHeaders",
                type: "text",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "city", "gender", "gratisPoint", "name", "referralCode", "region", "role", "streetAddress", "userDateJoined" },
                values: new object[,]
                {
                    { "8fafef80-7d5e-42d4-b63a-f3866ca03a63", 0, "3932230b-80fc-4cae-a88f-19a0e4a51d26", "ApplicationUser", null, false, false, null, null, null, null, null, false, "39ce8fcd-a2d3-4628-abcd-88d574744a28", false, null, "Admin1City", "Male", 0, "Admin1", null, "Admin1Region", null, "Admin1Home", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { "bc009560-3e92-4a13-987d-24208a441a1b", 0, "4fc4b142-b655-4d78-ad02-a33bc769dc78", "ApplicationUser", null, false, false, null, null, null, null, null, false, "ee4eba52-372c-445e-a7c2-08392394584a", false, null, "AdminCity", "Male", 0, "Admin", null, "AdminRegion", null, "AdminHome", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { "e97b649a-8d5f-4297-8107-4d137b7dc496", 0, "2d2ba7a3-8037-4c98-b540-a0529b88f39a", "ApplicationUser", null, false, false, null, null, null, null, null, false, "a28f91c1-7c5c-498d-a366-c2023092794b", false, null, "Admin2City", "Male", 0, "Admin2", null, "Admin2Region", null, "Admin2Home", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "productId", "CategoryId", "categoryId", "displayPrice", "imageUrl", "plusOnesAllowed", "productDateAdded", "productDescription", "productHighlights", "productLocation", "productTitle", "supplierPrice" },
                values: new object[,]
                {
                    { new Guid("0fc2e368-5ff3-4c33-9c5f-831bd07528d8"), null, 3, 130.0, "2dkhdhdhjhvdjh", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "This is an Admin2 product", "Admin2 magic content", "Admin2Location", "Admin2Product", 80.0 },
                    { new Guid("a6653d45-e804-436a-98f9-9e5ddda0c658"), null, 1, 110.0, "dkhdhdhjhvdjh", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "This is an Admin product", "Admin magic content", "AdminLocation", "AdminProduct", 100.0 },
                    { new Guid("f8ed7a46-b1db-4cdb-85fb-91863e042faf"), null, 2, 120.0, "1dkhdhdhjhvdjh", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "This is an Admin1 product", "Admin1 magic content", "Admin1Location", "Admin1Product", 90.0 }
                });
        }
    }
}
