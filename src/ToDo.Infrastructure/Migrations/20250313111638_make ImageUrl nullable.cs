using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ToDo.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class makeImageUrlnullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e4a8c909-6639-4da3-bde8-c65fb4550965");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a4359195-ab68-45ff-9dd6-b7ae6da49197", "5110643b-7817-40f5-82ed-cc0a1fb75680" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a4359195-ab68-45ff-9dd6-b7ae6da49197");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5110643b-7817-40f5-82ed-cc0a1fb75680");

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a4359195-ab68-45ff-9dd6-b7ae6da49197", null, "admin", "Admin" },
                    { "e4a8c909-6639-4da3-bde8-c65fb4550965", null, "user", "User" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "ImageUrl", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "5110643b-7817-40f5-82ed-cc0a1fb75680", 0, "b0c3e810-24b6-4022-afe4-c4e7be7fb134", "admin@admin.com", true, "Mohamed", "http//imag@img.com", "Hussein", false, null, null, null, "AQAAAAIAAYagAAAAEJX3LbuhARAKQG/9lr9WHuGv441TZi7vTNaCZuTIEaiR3bjP+IjdCUKbHv1Mhbn4AQ==", null, false, "62bc2c69-034a-4dce-abfe-2bac86330e8f", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "a4359195-ab68-45ff-9dd6-b7ae6da49197", "5110643b-7817-40f5-82ed-cc0a1fb75680" });
        }
    }
}
