using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eFashionShop.Migrations
{
    public partial class updatecontact : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Default",
                table: "Contacts",
                type: "bit",
                nullable: true);

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
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash" },
                values: new object[] { "469fa8c0-bad1-4453-94dc-8e9ba51ebc43", "Cao", "Hung", "AQAAAAEAACcQAAAAEHqvVC0aCg3NdWfMSTZ84ESJtC054mZw8Kh3n1YycP2vDm+Yjb0KUV7UBhXNaK/MCg==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Default",
                table: "Contacts");

            migrationBuilder.UpdateData(
                table: "AppRole",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "b0ecaa3f-4489-4816-9f49-f28678cc7f32");

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash" },
                values: new object[] { "59ce5512-3946-4588-9b05-a7def71e29b8", "Toan", "Bach", "AQAAAAEAACcQAAAAEFJFZJMRBVIoJHPUKbZsbOnup7IOVEnTAs36A0lNv/Ee4UHWXSGmaod7lV+U5CUPAA==" });
        }
    }
}
