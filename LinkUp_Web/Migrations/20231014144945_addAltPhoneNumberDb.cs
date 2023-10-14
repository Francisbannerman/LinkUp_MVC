using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LinkUp_Web.Migrations
{
    /// <inheritdoc />
    public partial class addAltPhoneNumberDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1ff411e3-187d-4d9b-9882-bc60a98637e9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3912ff0d-5979-4534-8a07-ff05ddaba705");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8151dd49-7c39-42eb-8a5e-1bae92893513");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "productId",
                keyValue: new Guid("0a70b967-bd24-40c5-90ac-56bebca6d848"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "productId",
                keyValue: new Guid("31af0d11-f262-4c8e-96d5-9c29eb963857"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "productId",
                keyValue: new Guid("565cdabb-6431-4915-9c11-6225ce56b6d1"));

            migrationBuilder.DropColumn(
                name: "AlternativePhoneNumber",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "streetAddress",
                table: "BookingHeaders",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "region",
                table: "BookingHeaders",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "postalCode",
                table: "BookingHeaders",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "BookingHeaders",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "streetAddress",
                table: "BookingHeaders",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "region",
                table: "BookingHeaders",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "postalCode",
                table: "BookingHeaders",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "BookingHeaders",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AlternativePhoneNumber",
                table: "AspNetUsers",
                type: "text",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AlternativePhoneNumber", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "city", "gender", "name", "region", "role", "streetAddress", "userDateJoined" },
                values: new object[,]
                {
                    { "1ff411e3-187d-4d9b-9882-bc60a98637e9", 0, null, "546be20d-2379-4744-8bcd-58c212ca25e5", "ApplicationUser", null, false, false, null, null, null, null, null, false, "97b27520-9c74-4125-9f1a-d49e56f815ff", false, null, "Admin1City", "Male", "Admin1", "Admin1Region", null, "Admin1Home", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { "3912ff0d-5979-4534-8a07-ff05ddaba705", 0, null, "2d754b1d-c6ee-4698-840f-550dc9ca09f9", "ApplicationUser", null, false, false, null, null, null, null, null, false, "0805cf35-0ce9-406b-af29-adc238e04e3b", false, null, "AdminCity", "Male", "Admin", "AdminRegion", null, "AdminHome", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { "8151dd49-7c39-42eb-8a5e-1bae92893513", 0, null, "18ec6c5c-ca9c-400a-9e58-c03388fc2007", "ApplicationUser", null, false, false, null, null, null, null, null, false, "8ce1007c-f51c-40ab-8e39-c8e23015bc21", false, null, "Admin2City", "Male", "Admin2", "Admin2Region", null, "Admin2Home", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "productId", "CategoryId", "categoryId", "displayPrice", "imageUrl", "plusOnesAllowed", "productDateAdded", "productDescription", "productHighlights", "productLocation", "productTitle", "supplierPrice" },
                values: new object[,]
                {
                    { new Guid("0a70b967-bd24-40c5-90ac-56bebca6d848"), null, 3, 130.0, "2dkhdhdhjhvdjh", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "This is an Admin2 product", "Admin2 magic content", "Admin2Location", "Admin2Product", 80.0 },
                    { new Guid("31af0d11-f262-4c8e-96d5-9c29eb963857"), null, 1, 110.0, "dkhdhdhjhvdjh", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "This is an Admin product", "Admin magic content", "AdminLocation", "AdminProduct", 100.0 },
                    { new Guid("565cdabb-6431-4915-9c11-6225ce56b6d1"), null, 2, 120.0, "1dkhdhdhjhvdjh", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "This is an Admin1 product", "Admin1 magic content", "Admin1Location", "Admin1Product", 90.0 }
                });
        }
    }
}
