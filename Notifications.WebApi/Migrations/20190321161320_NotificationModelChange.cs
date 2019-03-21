using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Notifications.WebApi.Migrations
{
    public partial class NotificationModelChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("2714997f-855b-4535-90a2-d1c6ac51d602"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("43308171-dbdb-4e81-901c-eb939f792f40"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("83649614-70c9-46f2-8bb6-cd8dba69c70d"));

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Notifications",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "UserName" },
                values: new object[] { new Guid("3e187b65-0e11-4071-be93-600c6f731d69"), "Mubeen" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "UserName" },
                values: new object[] { new Guid("cde80f96-cad1-42c0-9b6b-8604e321ea2b"), "Tahir" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "UserName" },
                values: new object[] { new Guid("7734c64b-4abb-4f83-aa57-dab952788f17"), "Cheema" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("3e187b65-0e11-4071-be93-600c6f731d69"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("7734c64b-4abb-4f83-aa57-dab952788f17"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("cde80f96-cad1-42c0-9b6b-8604e321ea2b"));

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Notifications");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "UserName" },
                values: new object[] { new Guid("83649614-70c9-46f2-8bb6-cd8dba69c70d"), "Mubeen" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "UserName" },
                values: new object[] { new Guid("2714997f-855b-4535-90a2-d1c6ac51d602"), "Tahir" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "UserName" },
                values: new object[] { new Guid("43308171-dbdb-4e81-901c-eb939f792f40"), "Cheema" });
        }
    }
}
