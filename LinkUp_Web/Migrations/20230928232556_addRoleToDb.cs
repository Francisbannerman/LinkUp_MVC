using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LinkUp_Web.Migrations
{
    /// <inheritdoc />
    public partial class addRoleToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(128)",
                oldMaxLength: 128);

            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "AspNetUsers",
                type: "text",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(128)",
                oldMaxLength: 128);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Role",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "character varying(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "character varying(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "character varying(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "character varying(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

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
        }
    }
}
