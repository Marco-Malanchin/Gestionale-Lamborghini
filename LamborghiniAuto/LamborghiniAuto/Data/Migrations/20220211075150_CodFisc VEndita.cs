using Microsoft.EntityFrameworkCore.Migrations;

namespace LamborghiniAuto.Data.Migrations
{
    public partial class CodFiscVEndita : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "codFisc",
                table: "Vendita",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "codFisc",
                table: "Vendita");
        }
    }
}
