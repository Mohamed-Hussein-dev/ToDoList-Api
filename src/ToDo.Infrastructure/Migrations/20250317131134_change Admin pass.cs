using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ToDo.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class changeAdminpass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "5b8ddc8f-286e-4e6a-b05a-a0767d001d4b", null, "user", "User" },
                    { "9643459d-6520-4005-bfff-854ef08037f5", null, "admin", "Admin" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "ImageUrl", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "cb8e826b-1f6f-44ba-90dc-d3d89903d4ac", 0, "d7952b08-67c3-46e7-997b-20716a69ebf6", "admin@admin.com", true, "Mohamed", "http//imag@img.com", "Hussein", false, null, null, null, "AQAAAAIAAYagAAAAENj8WDQBwT7c/T25AkEzB6dYwOkTfmT72TSZe4WrmrgKDSJAXTszcIQEO6oli3zfFA==", null, false, "9c83c7f2-c63c-4d92-a772-0186b94934cc", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "9643459d-6520-4005-bfff-854ef08037f5", "cb8e826b-1f6f-44ba-90dc-d3d89903d4ac" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5b8ddc8f-286e-4e6a-b05a-a0767d001d4b");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9643459d-6520-4005-bfff-854ef08037f5", "cb8e826b-1f6f-44ba-90dc-d3d89903d4ac" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9643459d-6520-4005-bfff-854ef08037f5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cb8e826b-1f6f-44ba-90dc-d3d89903d4ac");

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
    }
}
