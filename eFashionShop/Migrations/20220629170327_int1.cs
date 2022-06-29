using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eFashionShop.Migrations
{
    public partial class int1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ViewCount",
                table: "Products");

            migrationBuilder.AddColumn<double>(
                name: "Area",
                table: "Products",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Customer",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Localtion",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AppRole",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "ca758036-61b6-47a2-9618-654aa214f89f");

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "318e838d-6a6f-47d4-90a7-da24b82ed4c7", "AQAAAAEAACcQAAAAEFqhcDuzp9SMpjLcjXIA6wmUs2Uwk0qlx5Rb1MH8bkwBzmlFvZyIWSbt2tM0eRs5tQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Area",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Customer",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Localtion",
                table: "Products");

            migrationBuilder.AddColumn<int>(
                name: "ViewCount",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AppRole",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "b1c81679-e4e4-4fe8-8fe6-e06c889ddd44");

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "253cf960-9271-4da9-8cb2-035b77d1d7ef", "AQAAAAEAACcQAAAAEHMN9d1rmmAFxzX+8asS0PTYaFjFV0ScnEuRqn62mOOwbJsl1JsFTzQYSdNHN19p3Q==" });
        }
    }
}
