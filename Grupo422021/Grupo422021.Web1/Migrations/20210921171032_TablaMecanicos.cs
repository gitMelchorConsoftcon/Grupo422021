using Microsoft.EntityFrameworkCore.Migrations;

namespace Grupo422021.Web1.Migrations
{
    public partial class TablaMecanicos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Mecanicos",
                columns: table => new
                {
                    IdMecanico = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: false),
                    ApellidoPaterno = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: false),
                    ApellidoMaterno = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: true),
                    Telefono = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mecanicos", x => x.IdMecanico);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Mecanicos");
        }
    }
}
