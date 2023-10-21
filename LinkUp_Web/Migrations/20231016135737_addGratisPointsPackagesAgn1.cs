using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LinkUp_Web.Migrations
{
    /// <inheritdoc />
    public partial class addGratisPointsPackagesAgn1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GratisPointPackages_AspNetUsers_addedByWhosID",
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

            migrationBuilder.RenameColumn(
                name: "addedByWhosID",
                table: "GratisPointPackages",
                newName: "addedByWho");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "city", "gender", "gratisPoint", "name", "referralCode", "region", "role", "streetAddress", "userDateJoined" },
                values: new object[,]
                {
                    { "2be1fa84-e6e0-45d3-a8f2-16ec8e0b9952", 0, "9fa29ca4-c01f-4b75-968b-d4ba53cfffc5", "ApplicationUser", null, false, false, null, null, null, null, null, false, "6eb83d0d-5e77-47cc-a215-35b573c8fcd0", false, null, "Admin1City", "Male", 0, "Admin1", null, "Admin1Region", null, "Admin1Home", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { "34771daa-d701-477e-bed4-017a9858624d", 0, "06f8db37-3b54-41dc-b75e-d0108888b3ba", "ApplicationUser", null, false, false, null, null, null, null, null, false, "a6ba85e3-27e1-458a-92fb-4127fbeab95a", false, null, "AdminCity", "Male", 0, "Admin", null, "AdminRegion", null, "AdminHome", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { "b05502ef-a232-44b6-9b4e-693fe1af8532", 0, "984d97a6-e043-43e5-991c-adac1c2adfb3", "ApplicationUser", null, false, false, null, null, null, null, null, false, "09963c50-20a0-4db0-8166-347dac1ab369", false, null, "Admin2City", "Male", 0, "Admin2", null, "Admin2Region", null, "Admin2Home", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "productId", "CategoryId", "categoryId", "displayPrice", "imageUrl", "plusOnesAllowed", "productDateAdded", "productDescription", "productHighlights", "productLocation", "productTitle", "supplierPrice" },
                values: new object[,]
                {
                    { new Guid("2250e7f7-b9cc-49c2-8c34-ad96762bab90"), null, 2, 120.0, "1dkhdhdhjhvdjh", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "This is an Admin1 product", "Admin1 magic content", "Admin1Location", "Admin1Product", 90.0 },
                    { new Guid("90af0a75-02b4-4136-9824-89bec006ecdf"), null, 1, 110.0, "dkhdhdhjhvdjh", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "This is an Admin product", "Admin magic content", "AdminLocation", "AdminProduct", 100.0 },
                    { new Guid("f9435cb5-2fe9-48f8-89ed-11333f74f202"), null, 3, 130.0, "2dkhdhdhjhvdjh", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "This is an Admin2 product", "Admin2 magic content", "Admin2Location", "Admin2Product", 80.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2be1fa84-e6e0-45d3-a8f2-16ec8e0b9952");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34771daa-d701-477e-bed4-017a9858624d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b05502ef-a232-44b6-9b4e-693fe1af8532");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "productId",
                keyValue: new Guid("2250e7f7-b9cc-49c2-8c34-ad96762bab90"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "productId",
                keyValue: new Guid("90af0a75-02b4-4136-9824-89bec006ecdf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "productId",
                keyValue: new Guid("f9435cb5-2fe9-48f8-89ed-11333f74f202"));

            migrationBuilder.RenameColumn(
                name: "addedByWho",
                table: "GratisPointPackages",
                newName: "addedByWhosID");

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
    }
}
