using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class TiposAudienciasEstadisticas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "sexoPeticionario",
                table: "peticionario",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "tipoAtencion",
                table: "citas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "materiaLegal",
                table: "archivo",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "sexoPeticionario",
                table: "peticionario");

            migrationBuilder.DropColumn(
                name: "tipoAtencion",
                table: "citas");

            migrationBuilder.DropColumn(
                name: "materiaLegal",
                table: "archivo");
        }
    }
}
