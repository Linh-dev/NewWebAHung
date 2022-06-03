using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eFashionShop.Migrations
{
    public partial class _11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Default",
                table: "Contacts",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AppRole",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "c2bc43b8-3eba-420b-837d-df0c80145e20");

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7b61ec1f-cbf3-47e3-8532-2144916cdaa9", "AQAAAAEAACcQAAAAEAvcSsj6/XKUnOa3uYcHULZbIeZrA06p4q0B0umFQkt00vkuxDRamSU1lZp8DfVybQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Default",
                table: "Contacts",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.UpdateData(
                table: "AppRole",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "83f42de7-7614-4601-8293-f1d6afa89f74");

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "469fa8c0-bad1-4453-94dc-8e9ba51ebc43", "AQAAAAEAACcQAAAAEHqvVC0aCg3NdWfMSTZ84ESJtC054mZw8Kh3n1YycP2vDm+Yjb0KUV7UBhXNaK/MCg==" });
        }
    }
}
