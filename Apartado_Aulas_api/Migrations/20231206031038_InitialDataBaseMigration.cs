using Microsoft.EntityFrameworkCore.Migrations;

namespace Apartado_Aulas_api.Migrations
{
    public partial class InitialDataBaseMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Edificios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeroEdificio = table.Column<int>(type: "int", nullable: false),
                    NombreEdificio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Encargado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CantAulas = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Edificios", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Edificios");
        }
    }
}
