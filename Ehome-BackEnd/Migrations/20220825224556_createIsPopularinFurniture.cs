using Microsoft.EntityFrameworkCore.Migrations;

namespace Ehome_BackEnd.Migrations
{
    public partial class createIsPopularinFurniture : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsPopular",
                table: "Futnitures",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsPopular",
                table: "Futnitures");
        }
    }
}
