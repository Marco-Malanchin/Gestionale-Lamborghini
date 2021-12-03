using Microsoft.EntityFrameworkCore.Migrations;

namespace LamborghiniAuto.Data.Migrations
{
    public partial class Dipendente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "mestiere",
                table: "Persona",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "stipendio",
                table: "Persona",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Persona",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "mestiere",
                table: "Persona");

            migrationBuilder.DropColumn(
                name: "stipendio",
                table: "Persona");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Persona");
        }
    }
}
