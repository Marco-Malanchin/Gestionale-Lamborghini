using Microsoft.EntityFrameworkCore.Migrations;

namespace LamborghiniAuto.Data.Migrations
{
    public partial class Finanze : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Finanza",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    entrate = table.Column<double>(nullable: false),
                    uscite = table.Column<double>(nullable: false),
                    ricavi = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Finanza", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Finanza");
        }
    }
}
