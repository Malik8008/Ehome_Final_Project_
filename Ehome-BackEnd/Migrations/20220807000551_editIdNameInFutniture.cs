using Microsoft.EntityFrameworkCore.Migrations;

namespace Ehome_BackEnd.Migrations
{
    public partial class editIdNameInFutniture : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FurnitureImages_Futnitures_FutnitureId",
                table: "FurnitureImages");

            migrationBuilder.DropColumn(
                name: "FurnitureId",
                table: "FurnitureImages");

            migrationBuilder.AlterColumn<int>(
                name: "FutnitureId",
                table: "FurnitureImages",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_FurnitureImages_Futnitures_FutnitureId",
                table: "FurnitureImages",
                column: "FutnitureId",
                principalTable: "Futnitures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FurnitureImages_Futnitures_FutnitureId",
                table: "FurnitureImages");

            migrationBuilder.AlterColumn<int>(
                name: "FutnitureId",
                table: "FurnitureImages",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "FurnitureId",
                table: "FurnitureImages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_FurnitureImages_Futnitures_FutnitureId",
                table: "FurnitureImages",
                column: "FutnitureId",
                principalTable: "Futnitures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
