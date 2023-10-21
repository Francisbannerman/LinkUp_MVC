using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LinkUp_Web.Migrations
{
    /// <inheritdoc />
    public partial class addGratisPointsPackages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "applicationUserId",
                table: "GratisPoints");

            migrationBuilder.RenameColumn(
                name: "Points",
                table: "GratisPoints",
                newName: "gratisPointQuantity");

            migrationBuilder.AddColumn<int>(
                name: "gratisPointPackagesId",
                table: "GratisPoints",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<double>(
                name: "AmountForGratisPoint",
                table: "GratisPoints",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "gratisPointPackagesId",
                table: "GratisPoints");

            migrationBuilder.DropColumn(
                name: "AmountForGratisPoint",
                table: "GratisPoints");

            migrationBuilder.RenameColumn(
                name: "gratisPointQuantity",
                table: "GratisPoints",
                newName: "Points");

            migrationBuilder.AddColumn<string>(
                name: "applicationUserId",
                table: "GratisPoints",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GratisPoints",
                table: "GratisPoints",
                column: "applicationUserId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_GratisPoints_AspNetUsers_applicationUserId",
                table: "GratisPoints",
                column: "applicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
