using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ToDo.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class updatedataseeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5f889104-6ddc-4e43-baca-58ff48f88d69");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "88e1d778-6d56-4b86-9496-1c1554566cb9", "7a34f08e-2535-498e-b16e-fb03babfd34c" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "88e1d778-6d56-4b86-9496-1c1554566cb9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7a34f08e-2535-498e-b16e-fb03babfd34c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "c42aea0b-60c3-4679-b62b-98dbf2e20a14", null, "user", "User" },
                    { "f4822d0a-4dd6-4c4f-910a-0bf635cd97c8", null, "admin", "Admin" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "ImageUrl", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "87c607af-2a25-4ee6-81ed-07232677f017", 0, "ae3f0e60-e0a5-449f-ae47-e381ecec09fa", "admin@admin.com", true, "Mohamed", "http//imag@img.com", "Hussein", false, null, null, null, "AQAAAAIAAYagAAAAEDAMG9XT+CJ6WtAhONB2Wj0VS4UOTsZw0WJlu+KQD2+Txh4UH3hAiycvfMzY16x+RQ==", null, false, "22bbae3c-4331-49fc-8418-1c56d0ebb531", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "f4822d0a-4dd6-4c4f-910a-0bf635cd97c8", "87c607af-2a25-4ee6-81ed-07232677f017" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c42aea0b-60c3-4679-b62b-98dbf2e20a14");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f4822d0a-4dd6-4c4f-910a-0bf635cd97c8", "87c607af-2a25-4ee6-81ed-07232677f017" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f4822d0a-4dd6-4c4f-910a-0bf635cd97c8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "87c607af-2a25-4ee6-81ed-07232677f017");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5f889104-6ddc-4e43-baca-58ff48f88d69", null, "user", "User" },
                    { "88e1d778-6d56-4b86-9496-1c1554566cb9", null, "admin", "Admin" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "ImageUrl", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "7a34f08e-2535-498e-b16e-fb03babfd34c", 0, "2d5c1bbb-045a-479b-87a1-61d9f2b8b7ab", "admin@admin.com", true, "Mohamed", "http//imag@img.com", "Hussein", false, null, null, null, "AQAAAAIAAYagAAAAEEnza7J4OP0ZHtcSmf4F6+OV0o6P0C5q0iooGv3lASjyfyyr6wUEuHLkRmSuevEOWg==", null, false, "92519302-fb16-42d9-8fe5-186d175c0892", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "88e1d778-6d56-4b86-9496-1c1554566cb9", "7a34f08e-2535-498e-b16e-fb03babfd34c" });
        }
    }
}
