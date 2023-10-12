using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LinkUp_Web.Migrations
{
    /// <inheritdoc />
    public partial class addBookingsToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5d3eb5b5-7dc7-46e8-9d5d-35ecfeefcbfe");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "858213ed-20a5-4054-8492-af0b33963889");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "87626cb3-bd75-4e5d-a647-8c63ee85f742");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "productId",
                keyValue: new Guid("0149c89b-6ec2-441f-b260-46e39dc52afc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "productId",
                keyValue: new Guid("8c03e780-9182-4a08-a257-f7a556a3fcca"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "productId",
                keyValue: new Guid("dada43c9-58f7-4c3d-95a2-5b6cdb052a41"));

            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ProductId = table.Column<Guid>(type: "uuid", nullable: false),
                    Count = table.Column<int>(type: "integer", nullable: false),
                    ApplicationUserId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bookings_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bookings_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "productId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "City", "CompanyId", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "Gender", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Region", "Role", "SecurityStamp", "StreetAddress", "TwoFactorEnabled", "UserName", "userDateJoined" },
                values: new object[,]
                {
                    { "530a5666-26a9-4772-b5cd-8a0aebba522a", 0, "Admin1City", 2, "400bad36-5201-45c9-a7a5-a5527c76ec79", "ApplicationUser", null, false, "Male", false, null, "Admin1", null, null, null, null, false, "Admin1Region", null, "a3af8f68-2441-48fd-8c91-13a74e5e9f5e", "Admin1Home", false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { "add43c0c-38f4-4015-a906-b6d89e75e75c", 0, "Admin2City", 1, "d1ed33cb-411e-4b67-afe6-92ea5a76765c", "ApplicationUser", null, false, "Male", false, null, "Admin2", null, null, null, null, false, "Admin2Region", null, "234a63af-79f9-49bb-a01f-4ff748138ecf", "Admin2Home", false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { "d551fb02-d3d9-48ad-a2f4-b6d25f0ed48f", 0, "AdminCity", 1, "09c68071-bfa6-4df3-ae93-d0030af04b39", "ApplicationUser", null, false, "Male", false, null, "Admin", null, null, null, null, false, "AdminRegion", null, "716c7223-70ba-499b-9013-c7c5f21beed5", "AdminHome", false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "productId", "CategoryId", "CompanyId", "DisplayPrice", "ImageUrl", "MaxUsers", "MinUsers", "productDateAdded", "productDescription", "productEndDate", "productHighlights", "productLocation", "productStartDate", "productTitle", "supplierPrice" },
                values: new object[,]
                {
                    { new Guid("0fb88e0c-dd8c-4dc9-a818-4da02b76fc1c"), 2, 2, 120.0, "1dkhdhdhjhvdjh", 11, 3, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "This is an Admin1 product", new DateTimeOffset(new DateTime(2023, 10, 9, 23, 47, 22, 2, DateTimeKind.Unspecified).AddTicks(8410), new TimeSpan(0, 0, 0, 0, 0)), "Admin1 magic content", "Admin1Location", new DateTimeOffset(new DateTime(2023, 10, 2, 23, 47, 22, 2, DateTimeKind.Unspecified).AddTicks(8410), new TimeSpan(0, 0, 0, 0, 0)), "Admin1Product", 90.0 },
                    { new Guid("9511f372-a446-48e8-a3dd-95fb63362ed6"), 1, 1, 110.0, "dkhdhdhjhvdjh", 10, 2, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "This is an Admin product", new DateTimeOffset(new DateTime(2023, 10, 7, 23, 47, 22, 2, DateTimeKind.Unspecified).AddTicks(8410), new TimeSpan(0, 0, 0, 0, 0)), "Admin magic content", "AdminLocation", new DateTimeOffset(new DateTime(2023, 10, 2, 23, 47, 22, 2, DateTimeKind.Unspecified).AddTicks(8410), new TimeSpan(0, 0, 0, 0, 0)), "AdminProduct", 100.0 },
                    { new Guid("f4cd817c-f588-40b8-be6e-9394fd46882f"), 3, 3, 130.0, "2dkhdhdhjhvdjh", 12, 4, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "This is an Admin2 product", new DateTimeOffset(new DateTime(2023, 10, 11, 23, 47, 22, 2, DateTimeKind.Unspecified).AddTicks(8410), new TimeSpan(0, 0, 0, 0, 0)), "Admin2 magic content", "Admin2Location", new DateTimeOffset(new DateTime(2023, 10, 2, 23, 47, 22, 2, DateTimeKind.Unspecified).AddTicks(8410), new TimeSpan(0, 0, 0, 0, 0)), "Admin2Product", 80.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_ApplicationUserId",
                table: "Bookings",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_ProductId",
                table: "Bookings",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "530a5666-26a9-4772-b5cd-8a0aebba522a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "add43c0c-38f4-4015-a906-b6d89e75e75c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d551fb02-d3d9-48ad-a2f4-b6d25f0ed48f");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "productId",
                keyValue: new Guid("0fb88e0c-dd8c-4dc9-a818-4da02b76fc1c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "productId",
                keyValue: new Guid("9511f372-a446-48e8-a3dd-95fb63362ed6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "productId",
                keyValue: new Guid("f4cd817c-f588-40b8-be6e-9394fd46882f"));

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "City", "CompanyId", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "Gender", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Region", "Role", "SecurityStamp", "StreetAddress", "TwoFactorEnabled", "UserName", "userDateJoined" },
                values: new object[,]
                {
                    { "5d3eb5b5-7dc7-46e8-9d5d-35ecfeefcbfe", 0, "AdminCity", 1, "69218efe-b7d6-40d5-abdc-c69f605cb7f8", "ApplicationUser", null, false, "Male", false, null, "Admin", null, null, null, null, false, "AdminRegion", null, "e50d6dae-d637-4f19-87ea-bd27d51d7534", "AdminHome", false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { "858213ed-20a5-4054-8492-af0b33963889", 0, "Admin1City", 2, "77213e29-5397-4d2d-a523-16e1d8774e0a", "ApplicationUser", null, false, "Male", false, null, "Admin1", null, null, null, null, false, "Admin1Region", null, "73720af9-a15d-4834-bfcb-23e684a24931", "Admin1Home", false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { "87626cb3-bd75-4e5d-a647-8c63ee85f742", 0, "Admin2City", 1, "fb401de4-a3bc-43d8-b6a4-4ef48dbc195a", "ApplicationUser", null, false, "Male", false, null, "Admin2", null, null, null, null, false, "Admin2Region", null, "74c44af3-76cd-471c-b08a-215a1e924323", "Admin2Home", false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "productId", "CategoryId", "CompanyId", "DisplayPrice", "ImageUrl", "MaxUsers", "MinUsers", "productDateAdded", "productDescription", "productEndDate", "productHighlights", "productLocation", "productStartDate", "productTitle", "supplierPrice" },
                values: new object[,]
                {
                    { new Guid("0149c89b-6ec2-441f-b260-46e39dc52afc"), 2, 2, 120.0, "1dkhdhdhjhvdjh", 11, 3, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "This is an Admin1 product", new DateTimeOffset(new DateTime(2023, 10, 5, 23, 25, 55, 810, DateTimeKind.Unspecified).AddTicks(4560), new TimeSpan(0, 0, 0, 0, 0)), "Admin1 magic content", "Admin1Location", new DateTimeOffset(new DateTime(2023, 9, 28, 23, 25, 55, 810, DateTimeKind.Unspecified).AddTicks(4560), new TimeSpan(0, 0, 0, 0, 0)), "Admin1Product", 90.0 },
                    { new Guid("8c03e780-9182-4a08-a257-f7a556a3fcca"), 3, 3, 130.0, "2dkhdhdhjhvdjh", 12, 4, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "This is an Admin2 product", new DateTimeOffset(new DateTime(2023, 10, 7, 23, 25, 55, 810, DateTimeKind.Unspecified).AddTicks(4560), new TimeSpan(0, 0, 0, 0, 0)), "Admin2 magic content", "Admin2Location", new DateTimeOffset(new DateTime(2023, 9, 28, 23, 25, 55, 810, DateTimeKind.Unspecified).AddTicks(4560), new TimeSpan(0, 0, 0, 0, 0)), "Admin2Product", 80.0 },
                    { new Guid("dada43c9-58f7-4c3d-95a2-5b6cdb052a41"), 1, 1, 110.0, "dkhdhdhjhvdjh", 10, 2, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "This is an Admin product", new DateTimeOffset(new DateTime(2023, 10, 3, 23, 25, 55, 810, DateTimeKind.Unspecified).AddTicks(4560), new TimeSpan(0, 0, 0, 0, 0)), "Admin magic content", "AdminLocation", new DateTimeOffset(new DateTime(2023, 9, 28, 23, 25, 55, 810, DateTimeKind.Unspecified).AddTicks(4560), new TimeSpan(0, 0, 0, 0, 0)), "AdminProduct", 100.0 }
                });
        }
    }
}
