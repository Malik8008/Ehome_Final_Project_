using Microsoft.EntityFrameworkCore.Migrations;

namespace Ehome_BackEnd.Migrations
{
    public partial class createFurnitureImageTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FurnitureImages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(nullable: true),
                    IsMain = table.Column<bool>(nullable: false),
                    FutnitureId = table.Column<int>(nullable: true),
                    FurnitureId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FurnitureImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FurnitureImages_Futnitures_FutnitureId",
                        column: x => x.FutnitureId,
                        principalTable: "Futnitures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FurnitureImages_FutnitureId",
                table: "FurnitureImages",
                column: "FutnitureId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FurnitureImages");
        }
    }
}
