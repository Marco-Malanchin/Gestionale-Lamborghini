using Microsoft.EntityFrameworkCore.Migrations;

namespace LamborghiniAuto.Data.Migrations
{
    public partial class Cliente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Clienteid",
                table: "Auto",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Auto_Clienteid",
                table: "Auto",
                column: "Clienteid");

            migrationBuilder.AddForeignKey(
                name: "FK_Auto_Persona_Clienteid",
                table: "Auto",
                column: "Clienteid",
                principalTable: "Persona",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Auto_Persona_Clienteid",
                table: "Auto");

            migrationBuilder.DropIndex(
                name: "IX_Auto_Clienteid",
                table: "Auto");

            migrationBuilder.DropColumn(
                name: "Clienteid",
                table: "Auto");
        }
    }
}
