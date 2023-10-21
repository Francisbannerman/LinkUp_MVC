using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LinkUp_Web.Migrations
{
    /// <inheritdoc />
    public partial class addGratisPointsPackagesAgn : Migration
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
                keyValue: "0ff53213-982d-422d-8b40-e2fe25452290");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2ad0777e-8d8f-4021-a4f5-09a3fee6f4d6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5c7ba06c-c390-459c-988c-515442f41d05");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "productId",
                keyValue: new Guid("0aa6d15e-5aa9-4f67-ae20-34531fb8bff5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "productId",
                keyValue: new Guid("7ba93590-aec9-4155-a67b-070e0c370543"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "productId",
                keyValue: new Guid("80917bb8-759d-41b5-8e82-0972e6f80b5d"));

            migrationBuilder.RenameTable(
                name: "GratisPoints",
                newName: "GratisPointPackages");

            migrationBuilder.AddColumn<string>(
                name: "addedByWhosID",
                table: "GratisPointPackages",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "dateAdded",
                table: "GratisPointPackages",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddPrimaryKey(
                name: "PK_GratisPointPackages",
                table: "GratisPointPackages",
                column: "gratisPointPackagesId");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "city", "gender", "gratisPoint", "name", "referralCode", "region", "role", "streetAddress", "userDateJoined" },
                values: new object[,]
                {
                    { "7cfdb995-7595-47fc-8829-7575479014e8", 0, "290ca9a7-dc99-4f5a-ad48-8d23b82b05d0", "ApplicationUser", null, false, false, null, null, null, null, null, false, "7e081a2f-7b55-4cf8-8765-1c9f16d84911", false, null, "AdminCity", "Male", 0, "Admin", null, "AdminRegion", null, "AdminHome", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { "f1790a7a-df37-4827-a952-d3987589869b", 0, "1012968a-1d48-4ef2-86b3-386f96db698c", "ApplicationUser", null, false, false, null, null, null, null, null, false, "d2ec9db6-80d1-45f9-b345-dc2203eefc43", false, null, "Admin2City", "Male", 0, "Admin2", null, "Admin2Region", null, "Admin2Home", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { "faa3b805-ccea-4927-a1fe-73f79839646c", 0, "791b4e64-00a0-4f6d-bc6c-575baa3233d8", "ApplicationUser", null, false, false, null, null, null, null, null, false, "eb0bc56b-3a00-48e8-a11a-a62251f01a92", false, null, "Admin1City", "Male", 0, "Admin1", null, "Admin1Region", null, "Admin1Home", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "productId", "CategoryId", "categoryId", "displayPrice", "imageUrl", "plusOnesAllowed", "productDateAdded", "productDescription", "productHighlights", "productLocation", "productTitle", "supplierPrice" },
                values: new object[,]
                {
                    { new Guid("580575a8-079b-4396-8d86-2d160b178bdb"), null, 1, 110.0, "dkhdhdhjhvdjh", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "This is an Admin product", "Admin magic content", "AdminLocation", "AdminProduct", 100.0 },
                    { new Guid("68007400-084d-452c-aecc-805ca3a4db21"), null, 2, 120.0, "1dkhdhdhjhvdjh", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "This is an Admin1 product", "Admin1 magic content", "Admin1Location", "Admin1Product", 90.0 },
                    { new Guid("e12ccad5-f28f-42fe-a976-34885c9503b5"), null, 3, 130.0, "2dkhdhdhjhvdjh", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "This is an Admin2 product", "Admin2 magic content", "Admin2Location", "Admin2Product", 80.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_GratisPointPackages_addedByWhosID",
                table: "GratisPointPackages",
                column: "addedByWhosID");

            migrationBuilder.AddForeignKey(
                name: "FK_GratisPointPackages_AspNetUsers_addedByWhosID",
                table: "GratisPointPackages",
                column: "addedByWhosID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GratisPointPackages_AspNetUsers_addedByWhosID",
                table: "GratisPointPackages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GratisPointPackages",
                table: "GratisPointPackages");

            migrationBuilder.DropIndex(
                name: "IX_GratisPointPackages_addedByWhosID",
                table: "GratisPointPackages");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7cfdb995-7595-47fc-8829-7575479014e8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f1790a7a-df37-4827-a952-d3987589869b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "faa3b805-ccea-4927-a1fe-73f79839646c");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "productId",
                keyValue: new Guid("580575a8-079b-4396-8d86-2d160b178bdb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "productId",
                keyValue: new Guid("68007400-084d-452c-aecc-805ca3a4db21"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "productId",
                keyValue: new Guid("e12ccad5-f28f-42fe-a976-34885c9503b5"));

            migrationBuilder.DropColumn(
                name: "addedByWhosID",
                table: "GratisPointPackages");

            migrationBuilder.DropColumn(
                name: "dateAdded",
                table: "GratisPointPackages");

            migrationBuilder.RenameTable(
                name: "GratisPointPackages",
                newName: "GratisPoints");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GratisPoints",
                table: "GratisPoints",
                column: "gratisPointPackagesId");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "city", "gender", "gratisPoint", "name", "referralCode", "region", "role", "streetAddress", "userDateJoined" },
                values: new object[,]
                {
                    { "0ff53213-982d-422d-8b40-e2fe25452290", 0, "6227cd59-bbd3-443b-87cd-f1d4060a5214", "ApplicationUser", null, false, false, null, null, null, null, null, false, "4f5f018e-7c85-493e-bc4f-d39de249fcca", false, null, "Admin1City", "Male", 0, "Admin1", null, "Admin1Region", null, "Admin1Home", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { "2ad0777e-8d8f-4021-a4f5-09a3fee6f4d6", 0, "f6dbe2db-9921-405a-a56d-d02ce9b61e30", "ApplicationUser", null, false, false, null, null, null, null, null, false, "aedfdccf-6dee-427b-a4b8-431b6170a807", false, null, "AdminCity", "Male", 0, "Admin", null, "AdminRegion", null, "AdminHome", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { "5c7ba06c-c390-459c-988c-515442f41d05", 0, "bfc24cc8-c03e-4d11-bfce-baa1cb95ac95", "ApplicationUser", null, false, false, null, null, null, null, null, false, "fa04c04d-1ca2-4640-bdc9-f7fe8dc2a168", false, null, "Admin2City", "Male", 0, "Admin2", null, "Admin2Region", null, "Admin2Home", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "productId", "CategoryId", "categoryId", "displayPrice", "imageUrl", "plusOnesAllowed", "productDateAdded", "productDescription", "productHighlights", "productLocation", "productTitle", "supplierPrice" },
                values: new object[,]
                {
                    { new Guid("0aa6d15e-5aa9-4f67-ae20-34531fb8bff5"), null, 3, 130.0, "2dkhdhdhjhvdjh", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "This is an Admin2 product", "Admin2 magic content", "Admin2Location", "Admin2Product", 80.0 },
                    { new Guid("7ba93590-aec9-4155-a67b-070e0c370543"), null, 2, 120.0, "1dkhdhdhjhvdjh", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "This is an Admin1 product", "Admin1 magic content", "Admin1Location", "Admin1Product", 90.0 },
                    { new Guid("80917bb8-759d-41b5-8e82-0972e6f80b5d"), null, 1, 110.0, "dkhdhdhjhvdjh", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "This is an Admin product", "Admin magic content", "AdminLocation", "AdminProduct", 100.0 }
                });
        }
    }
}
