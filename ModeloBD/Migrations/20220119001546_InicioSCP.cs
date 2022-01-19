using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ModeloBD.Migrations
{
    public partial class InicioSCP : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "periodos",
                columns: table => new
                {
                    PeriodoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaFin = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_periodos", x => x.PeriodoId);
                });

            migrationBuilder.CreateTable(
                name: "productos",
                columns: table => new
                {
                    ProductoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Unidad = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productos", x => x.ProductoId);
                });

            migrationBuilder.CreateTable(
                name: "proveedores",
                columns: table => new
                {
                    ProveedorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ruc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Correo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_proveedores", x => x.ProveedorId);
                });

            migrationBuilder.CreateTable(
                name: "configuracion",
                columns: table => new
                {
                    ConfiguracionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NotaMinima = table.Column<float>(type: "real", nullable: false),
                    PesoNota1 = table.Column<float>(type: "real", nullable: false),
                    PesoNota2 = table.Column<float>(type: "real", nullable: false),
                    PesoNota3 = table.Column<float>(type: "real", nullable: false),
                    PesoNota4 = table.Column<float>(type: "real", nullable: false),
                    PesoNota5 = table.Column<float>(type: "real", nullable: false),
                    PesoNota6 = table.Column<float>(type: "real", nullable: false),
                    PesoNota7 = table.Column<float>(type: "real", nullable: false),
                    PeriodoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_configuracion", x => x.ConfiguracionId);
                    table.ForeignKey(
                        name: "FK_configuracion_periodos_PeriodoId",
                        column: x => x.PeriodoId,
                        principalTable: "periodos",
                        principalColumn: "PeriodoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ofertas",
                columns: table => new
                {
                    OfertaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Precio = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LoteMinimo = table.Column<float>(type: "real", nullable: false),
                    Descuento = table.Column<float>(type: "real", nullable: false),
                    Garantia = table.Column<bool>(type: "bit", nullable: false),
                    TiempoEntrefa = table.Column<int>(type: "int", nullable: false),
                    ScoreBuro = table.Column<int>(type: "int", nullable: false),
                    ProductoId = table.Column<int>(type: "int", nullable: false),
                    ProveedorId = table.Column<int>(type: "int", nullable: false),
                    PeriodoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ofertas", x => x.OfertaId);
                    table.ForeignKey(
                        name: "FK_ofertas_periodos_PeriodoId",
                        column: x => x.PeriodoId,
                        principalTable: "periodos",
                        principalColumn: "PeriodoId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ofertas_productos_ProductoId",
                        column: x => x.ProductoId,
                        principalTable: "productos",
                        principalColumn: "ProductoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ofertas_proveedores_ProveedorId",
                        column: x => x.ProveedorId,
                        principalTable: "proveedores",
                        principalColumn: "ProveedorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "postulaciones",
                columns: table => new
                {
                    PostulacionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProveedorId = table.Column<int>(type: "int", nullable: false),
                    PeriodoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_postulaciones", x => x.PostulacionId);
                    table.ForeignKey(
                        name: "FK_postulaciones_periodos_PeriodoId",
                        column: x => x.PeriodoId,
                        principalTable: "periodos",
                        principalColumn: "PeriodoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_postulaciones_proveedores_ProveedorId",
                        column: x => x.ProveedorId,
                        principalTable: "proveedores",
                        principalColumn: "ProveedorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "postulaciones_det",
                columns: table => new
                {
                    Postulacion_DetId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostulacionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_postulaciones_det", x => x.Postulacion_DetId);
                    table.ForeignKey(
                        name: "FK_postulaciones_det_postulaciones_PostulacionId",
                        column: x => x.PostulacionId,
                        principalTable: "postulaciones",
                        principalColumn: "PostulacionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "calificaciones",
                columns: table => new
                {
                    CalificacionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nota1 = table.Column<float>(type: "real", nullable: false),
                    Nota2 = table.Column<float>(type: "real", nullable: false),
                    Nota3 = table.Column<float>(type: "real", nullable: false),
                    Nota4 = table.Column<float>(type: "real", nullable: false),
                    Nota5 = table.Column<float>(type: "real", nullable: false),
                    Nota6 = table.Column<float>(type: "real", nullable: false),
                    Nota7 = table.Column<float>(type: "real", nullable: false),
                    Postulacion_DetId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_calificaciones", x => x.CalificacionId);
                    table.ForeignKey(
                        name: "FK_calificaciones_postulaciones_det_Postulacion_DetId",
                        column: x => x.Postulacion_DetId,
                        principalTable: "postulaciones_det",
                        principalColumn: "Postulacion_DetId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_calificaciones_Postulacion_DetId",
                table: "calificaciones",
                column: "Postulacion_DetId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_configuracion_PeriodoId",
                table: "configuracion",
                column: "PeriodoId");

            migrationBuilder.CreateIndex(
                name: "IX_ofertas_PeriodoId",
                table: "ofertas",
                column: "PeriodoId");

            migrationBuilder.CreateIndex(
                name: "IX_ofertas_ProductoId",
                table: "ofertas",
                column: "ProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_ofertas_ProveedorId",
                table: "ofertas",
                column: "ProveedorId");

            migrationBuilder.CreateIndex(
                name: "IX_postulaciones_PeriodoId",
                table: "postulaciones",
                column: "PeriodoId");

            migrationBuilder.CreateIndex(
                name: "IX_postulaciones_ProveedorId",
                table: "postulaciones",
                column: "ProveedorId");

            migrationBuilder.CreateIndex(
                name: "IX_postulaciones_det_PostulacionId",
                table: "postulaciones_det",
                column: "PostulacionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "calificaciones");

            migrationBuilder.DropTable(
                name: "configuracion");

            migrationBuilder.DropTable(
                name: "ofertas");

            migrationBuilder.DropTable(
                name: "postulaciones_det");

            migrationBuilder.DropTable(
                name: "productos");

            migrationBuilder.DropTable(
                name: "postulaciones");

            migrationBuilder.DropTable(
                name: "periodos");

            migrationBuilder.DropTable(
                name: "proveedores");
        }
    }
}
