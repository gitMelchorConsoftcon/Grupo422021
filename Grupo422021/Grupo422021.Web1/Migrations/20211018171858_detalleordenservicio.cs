using Microsoft.EntityFrameworkCore.Migrations;

namespace Grupo422021.Web1.Migrations
{
    public partial class detalleordenservicio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OrdenServicioDetalle",
                columns: table => new
                {
                    IdOrdenServicioDetalle = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdOrdenServicio = table.Column<int>(type: "int", nullable: false),
                    IdServicio = table.Column<int>(type: "int", nullable: false),
                    Cantidad = table.Column<decimal>(type: "decimal(6,2)", nullable: false),
                    Costo = table.Column<decimal>(type: "decimal(6,2)", nullable: false),
                    Observaciones = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdenServicioDetalle", x => x.IdOrdenServicioDetalle);
                    table.ForeignKey(
                        name: "FK_OrdenServicioDetalle_OrdenServicio_IdOrdenServicio",
                        column: x => x.IdOrdenServicio,
                        principalTable: "OrdenServicio",
                        principalColumn: "IdOrdenServicio",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrdenServicioDetalle_Servicios_IdServicio",
                        column: x => x.IdServicio,
                        principalTable: "Servicios",
                        principalColumn: "IdServicio",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrdenServicioDetalle_IdOrdenServicio",
                table: "OrdenServicioDetalle",
                column: "IdOrdenServicio");

            migrationBuilder.CreateIndex(
                name: "IX_OrdenServicioDetalle_IdServicio",
                table: "OrdenServicioDetalle",
                column: "IdServicio");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrdenServicioDetalle");
        }
    }
}
