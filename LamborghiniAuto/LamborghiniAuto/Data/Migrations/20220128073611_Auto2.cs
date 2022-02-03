using Microsoft.EntityFrameworkCore.Migrations;

namespace LamborghiniAuto.Data.Migrations
{
    public partial class Auto2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PezziVenduti",
                table: "Auto",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "pezziDisponibili",
                table: "Auto",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PezziVenduti",
                table: "Auto");

            migrationBuilder.DropColumn(
                name: "pezziDisponibili",
                table: "Auto");
        }
    }
}
