using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LinkUp_Web.Migrations
{
    /// <inheritdoc />
    public partial class adEverythingAgains : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationUsers");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "productId",
                keyValue: new Guid("335048f1-8b64-4f53-ae23-42bd5c9e7c59"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "productId",
                keyValue: new Guid("b39bab29-c994-4527-a1b4-5ce239d8e86a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "productId",
                keyValue: new Guid("d6a5ad25-df3d-4aad-9e21-84636254d221"));

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "AspNetUsers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "AspNetUsers",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "AspNetUsers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "AspNetUsers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Region",
                table: "AspNetUsers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StreetAddress",
                table: "AspNetUsers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "userDateJoined",
                table: "AspNetUsers",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "City", "CompanyId", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "Gender", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Region", "SecurityStamp", "StreetAddress", "TwoFactorEnabled", "UserName", "userDateJoined" },
                values: new object[,]
                {
                    { "38e0652b-cac5-4d42-ac13-bea73eb0aa97", 0, "AdminCity", 1, "52325418-54de-4168-ac52-f03c027213f8", "ApplicationUser", null, false, "Male", false, null, "Admin", null, null, null, null, false, "AdminRegion", "fab6233d-9a7a-49e4-95af-eab24d69e5d0", "AdminHome", false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { "57cf04cd-8a44-44ce-b6f5-e85f6b082c5e", 0, "Admin1City", 2, "2b69f7ba-6fca-4692-bf24-a708791e207c", "ApplicationUser", null, false, "Male", false, null, "Admin1", null, null, null, null, false, "Admin1Region", "7662e9c2-d74e-4355-b4d5-d1c16a703781", "Admin1Home", false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { "c3e14032-200e-437f-b77b-27e632750e77", 0, "Admin2City", 1, "8b19b33a-6679-4bc5-b5ee-405dc20b1fe6", "ApplicationUser", null, false, "Male", false, null, "Admin2", null, null, null, null, false, "Admin2Region", "0fd95fd2-39d0-4e32-98b4-61f2f84a3002", "Admin2Home", false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "productId", "CategoryId", "CompanyId", "DisplayPrice", "ImageUrl", "MaxUsers", "MinUsers", "productDateAdded", "productDescription", "productEndDate", "productHighlights", "productLocation", "productStartDate", "productTitle", "supplierPrice" },
                values: new object[,]
                {
                    { new Guid("1cd5c007-b95b-4294-9a37-1d8dcb56b264"), 2, 2, 120.0, "1dkhdhdhjhvdjh", 11, 3, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "This is an Admin1 product", new DateTimeOffset(new DateTime(2023, 10, 4, 1, 47, 3, 541, DateTimeKind.Unspecified).AddTicks(9370), new TimeSpan(0, 0, 0, 0, 0)), "Admin1 magic content", "Admin1Location", new DateTimeOffset(new DateTime(2023, 9, 27, 1, 47, 3, 541, DateTimeKind.Unspecified).AddTicks(9370), new TimeSpan(0, 0, 0, 0, 0)), "Admin1Product", 90.0 },
                    { new Guid("e5d4f387-1e05-467b-8f97-b74b7b359ac3"), 3, 3, 130.0, "2dkhdhdhjhvdjh", 12, 4, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "This is an Admin2 product", new DateTimeOffset(new DateTime(2023, 10, 6, 1, 47, 3, 541, DateTimeKind.Unspecified).AddTicks(9370), new TimeSpan(0, 0, 0, 0, 0)), "Admin2 magic content", "Admin2Location", new DateTimeOffset(new DateTime(2023, 9, 27, 1, 47, 3, 541, DateTimeKind.Unspecified).AddTicks(9370), new TimeSpan(0, 0, 0, 0, 0)), "Admin2Product", 80.0 },
                    { new Guid("fe9fd2f1-1dea-49dc-87ae-3ee5aa4d949e"), 1, 1, 110.0, "dkhdhdhjhvdjh", 10, 2, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "This is an Admin product", new DateTimeOffset(new DateTime(2023, 10, 2, 1, 47, 3, 541, DateTimeKind.Unspecified).AddTicks(9370), new TimeSpan(0, 0, 0, 0, 0)), "Admin magic content", "AdminLocation", new DateTimeOffset(new DateTime(2023, 9, 27, 1, 47, 3, 541, DateTimeKind.Unspecified).AddTicks(9370), new TimeSpan(0, 0, 0, 0, 0)), "AdminProduct", 100.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_CompanyId",
                table: "AspNetUsers",
                column: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Companies_CompanyId",
                table: "AspNetUsers",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "CompanyId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Companies_CompanyId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_CompanyId",
                table: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "38e0652b-cac5-4d42-ac13-bea73eb0aa97");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "57cf04cd-8a44-44ce-b6f5-e85f6b082c5e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3e14032-200e-437f-b77b-27e632750e77");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "productId",
                keyValue: new Guid("1cd5c007-b95b-4294-9a37-1d8dcb56b264"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "productId",
                keyValue: new Guid("e5d4f387-1e05-467b-8f97-b74b7b359ac3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "productId",
                keyValue: new Guid("fe9fd2f1-1dea-49dc-87ae-3ee5aa4d949e"));

            migrationBuilder.DropColumn(
                name: "City",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Region",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "StreetAddress",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "userDateJoined",
                table: "AspNetUsers");

            migrationBuilder.CreateTable(
                name: "ApplicationUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CompanyId = table.Column<int>(type: "integer", nullable: true),
                    City = table.Column<string>(type: "text", nullable: true),
                    Gender = table.Column<string>(type: "text", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Region = table.Column<string>(type: "text", nullable: true),
                    StreetAddress = table.Column<string>(type: "text", nullable: true),
                    userDateJoined = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ApplicationUsers_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "CompanyId");
                });

            migrationBuilder.InsertData(
                table: "ApplicationUsers",
                columns: new[] { "Id", "City", "CompanyId", "Gender", "Name", "Region", "StreetAddress", "userDateJoined" },
                values: new object[,]
                {
                    { 1, "AdminCity", 1, "Male", "Admin", "AdminRegion", "AdminHome", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 2, "Admin1City", 2, "Male", "Admin1", "Admin1Region", "Admin1Home", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 3, "Admin2City", 1, "Male", "Admin2", "Admin2Region", "Admin2Home", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "productId", "CategoryId", "CompanyId", "DisplayPrice", "ImageUrl", "MaxUsers", "MinUsers", "productDateAdded", "productDescription", "productEndDate", "productHighlights", "productLocation", "productStartDate", "productTitle", "supplierPrice" },
                values: new object[,]
                {
                    { new Guid("335048f1-8b64-4f53-ae23-42bd5c9e7c59"), 2, 2, 120.0, "1dkhdhdhjhvdjh", 11, 3, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "This is an Admin1 product", new DateTimeOffset(new DateTime(2023, 10, 4, 0, 50, 49, 428, DateTimeKind.Unspecified).AddTicks(6820), new TimeSpan(0, 0, 0, 0, 0)), "Admin1 magic content", "Admin1Location", new DateTimeOffset(new DateTime(2023, 9, 27, 0, 50, 49, 428, DateTimeKind.Unspecified).AddTicks(6820), new TimeSpan(0, 0, 0, 0, 0)), "Admin1Product", 90.0 },
                    { new Guid("b39bab29-c994-4527-a1b4-5ce239d8e86a"), 3, 3, 130.0, "2dkhdhdhjhvdjh", 12, 4, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "This is an Admin2 product", new DateTimeOffset(new DateTime(2023, 10, 6, 0, 50, 49, 428, DateTimeKind.Unspecified).AddTicks(6820), new TimeSpan(0, 0, 0, 0, 0)), "Admin2 magic content", "Admin2Location", new DateTimeOffset(new DateTime(2023, 9, 27, 0, 50, 49, 428, DateTimeKind.Unspecified).AddTicks(6820), new TimeSpan(0, 0, 0, 0, 0)), "Admin2Product", 80.0 },
                    { new Guid("d6a5ad25-df3d-4aad-9e21-84636254d221"), 1, 1, 110.0, "dkhdhdhjhvdjh", 10, 2, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "This is an Admin product", new DateTimeOffset(new DateTime(2023, 10, 2, 0, 50, 49, 428, DateTimeKind.Unspecified).AddTicks(6820), new TimeSpan(0, 0, 0, 0, 0)), "Admin magic content", "AdminLocation", new DateTimeOffset(new DateTime(2023, 9, 27, 0, 50, 49, 428, DateTimeKind.Unspecified).AddTicks(6820), new TimeSpan(0, 0, 0, 0, 0)), "AdminProduct", 100.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUsers_CompanyId",
                table: "ApplicationUsers",
                column: "CompanyId");
        }
    }
}
