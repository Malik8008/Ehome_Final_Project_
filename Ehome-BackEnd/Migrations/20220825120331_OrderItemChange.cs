using Microsoft.EntityFrameworkCore.Migrations;

namespace Ehome_BackEnd.Migrations
{
    public partial class OrderItemChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Futnitures_FutnitureId",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "OrderItems");

            migrationBuilder.AlterColumn<int>(
                name: "FutnitureId",
                table: "OrderItems",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Futnitures_FutnitureId",
                table: "OrderItems",
                column: "FutnitureId",
                principalTable: "Futnitures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Futnitures_FutnitureId",
                table: "OrderItems");

            migrationBuilder.AlterColumn<int>(
                name: "FutnitureId",
                table: "OrderItems",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "OrderItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Futnitures_FutnitureId",
                table: "OrderItems",
                column: "FutnitureId",
                principalTable: "Futnitures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
