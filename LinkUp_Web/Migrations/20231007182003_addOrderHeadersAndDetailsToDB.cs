using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LinkUp_Web.Migrations
{
    /// <inheritdoc />
    public partial class addOrderHeadersAndDetailsToDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "BookingHeaders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ApplicationUserId = table.Column<string>(type: "text", nullable: false),
                    DateBooked = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    BookingDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    OrderTotal = table.Column<double>(type: "double precision", nullable: false),
                    OrderStatus = table.Column<string>(type: "text", nullable: true),
                    PaymentStatus = table.Column<string>(type: "text", nullable: true),
                    SeatTableNumber = table.Column<string>(type: "text", nullable: true),
                    Attendee = table.Column<string>(type: "text", nullable: true),
                    PaymentDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    SessionId = table.Column<string>(type: "text", nullable: true),
                    PaymentIntentId = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: false),
                    StreetAddress = table.Column<string>(type: "text", nullable: false),
                    City = table.Column<string>(type: "text", nullable: false),
                    State = table.Column<string>(type: "text", nullable: false),
                    PostalCode = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookingHeaders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookingHeaders_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookingDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    BookingHeaderId = table.Column<int>(type: "integer", nullable: false),
                    OrderHeaderId = table.Column<int>(type: "integer", nullable: false),
                    ProductId = table.Column<Guid>(type: "uuid", nullable: false),
                    Count = table.Column<int>(type: "integer", nullable: false),
                    Price = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookingDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookingDetails_BookingHeaders_OrderHeaderId",
                        column: x => x.OrderHeaderId,
                        principalTable: "BookingHeaders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookingDetails_Products_ProductId",
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
                    { "2d989643-80b9-4a80-95a7-75e4dbdb200a", 0, "Admin1City", 2, "138d0e59-6c06-443e-bc54-56ea5ab43430", "ApplicationUser", null, false, "Male", false, null, "Admin1", null, null, null, null, false, "Admin1Region", null, "b2667d28-5285-4742-85db-f64da5d000e2", "Admin1Home", false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { "499412db-f8c2-4ead-b9f6-645a9dd50a9c", 0, "AdminCity", 1, "040c8cbe-658f-4970-b5ad-d74882119c0e", "ApplicationUser", null, false, "Male", false, null, "Admin", null, null, null, null, false, "AdminRegion", null, "ed3b3e15-247d-416f-bbad-2a745f843816", "AdminHome", false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { "a8257fab-f18b-4607-9783-dfeab0c8c9b3", 0, "Admin2City", 1, "9fce77da-ac90-417b-bf6b-286417aedc20", "ApplicationUser", null, false, "Male", false, null, "Admin2", null, null, null, null, false, "Admin2Region", null, "2a0d5f4b-c944-4c2d-b672-91b7aa949c07", "Admin2Home", false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "productId", "CategoryId", "CompanyId", "DisplayPrice", "ImageUrl", "MaxUsers", "MinUsers", "productDateAdded", "productDescription", "productEndDate", "productHighlights", "productLocation", "productStartDate", "productTitle", "supplierPrice" },
                values: new object[,]
                {
                    { new Guid("19318628-9983-4d50-bdd5-96b8bd115438"), 3, 3, 130.0, "2dkhdhdhjhvdjh", 12, 4, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "This is an Admin2 product", new DateTimeOffset(new DateTime(2023, 10, 16, 18, 20, 3, 497, DateTimeKind.Unspecified).AddTicks(2100), new TimeSpan(0, 0, 0, 0, 0)), "Admin2 magic content", "Admin2Location", new DateTimeOffset(new DateTime(2023, 10, 7, 18, 20, 3, 497, DateTimeKind.Unspecified).AddTicks(2100), new TimeSpan(0, 0, 0, 0, 0)), "Admin2Product", 80.0 },
                    { new Guid("5d5b342c-c477-4d12-bab0-c59d9ba8b119"), 2, 2, 120.0, "1dkhdhdhjhvdjh", 11, 3, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "This is an Admin1 product", new DateTimeOffset(new DateTime(2023, 10, 14, 18, 20, 3, 497, DateTimeKind.Unspecified).AddTicks(2100), new TimeSpan(0, 0, 0, 0, 0)), "Admin1 magic content", "Admin1Location", new DateTimeOffset(new DateTime(2023, 10, 7, 18, 20, 3, 497, DateTimeKind.Unspecified).AddTicks(2100), new TimeSpan(0, 0, 0, 0, 0)), "Admin1Product", 90.0 },
                    { new Guid("d0f164fc-8e2a-472a-a3f0-1c9d2df58aa5"), 1, 1, 110.0, "dkhdhdhjhvdjh", 10, 2, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "This is an Admin product", new DateTimeOffset(new DateTime(2023, 10, 12, 18, 20, 3, 497, DateTimeKind.Unspecified).AddTicks(2100), new TimeSpan(0, 0, 0, 0, 0)), "Admin magic content", "AdminLocation", new DateTimeOffset(new DateTime(2023, 10, 7, 18, 20, 3, 497, DateTimeKind.Unspecified).AddTicks(2100), new TimeSpan(0, 0, 0, 0, 0)), "AdminProduct", 100.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookingDetails_OrderHeaderId",
                table: "BookingDetails",
                column: "OrderHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_BookingDetails_ProductId",
                table: "BookingDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_BookingHeaders_ApplicationUserId",
                table: "BookingHeaders",
                column: "ApplicationUserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookingDetails");

            migrationBuilder.DropTable(
                name: "BookingHeaders");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2d989643-80b9-4a80-95a7-75e4dbdb200a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "499412db-f8c2-4ead-b9f6-645a9dd50a9c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a8257fab-f18b-4607-9783-dfeab0c8c9b3");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "productId",
                keyValue: new Guid("19318628-9983-4d50-bdd5-96b8bd115438"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "productId",
                keyValue: new Guid("5d5b342c-c477-4d12-bab0-c59d9ba8b119"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "productId",
                keyValue: new Guid("d0f164fc-8e2a-472a-a3f0-1c9d2df58aa5"));

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
        }
    }
}
