using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UniversityRooms.UI.Migrations
{
    public partial class @new : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_cathedras_buildings_building_id",
                table: "cathedras");

            migrationBuilder.AlterColumn<int>(
                name: "building_id",
                table: "cathedras",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddForeignKey(
                name: "fk_cathedras_buildings_building_id",
                table: "cathedras",
                column: "building_id",
                principalTable: "buildings",
                principalColumn: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_cathedras_buildings_building_id",
                table: "cathedras");

            migrationBuilder.AlterColumn<int>(
                name: "building_id",
                table: "cathedras",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "fk_cathedras_buildings_building_id",
                table: "cathedras",
                column: "building_id",
                principalTable: "buildings",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
