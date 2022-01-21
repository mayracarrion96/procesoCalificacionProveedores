using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ModeloBD.Migrations
{
    public partial class IniSCP : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "marcas",
                columns: table => new
                {
                    MarcaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_marcas", x => x.MarcaId);
                });

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
                name: "configuraciones",
                columns: table => new
                {
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
                    table.ForeignKey(
                        name: "FK_configuraciones_periodos_PeriodoId",
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
                    ScoreBuro = table.Column<int>(type: "int", nullable: false),
                    PeriodoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ofertas", x => x.OfertaId);
                    table.ForeignKey(
                        name: "FK_ofertas_periodos_PeriodoId",
                        column: x => x.PeriodoId,
                        principalTable: "periodos",
                        principalColumn: "PeriodoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "clasificaciones",
                columns: table => new
                {
                    MarcaId = table.Column<int>(type: "int", nullable: false),
                    ProductoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clasificaciones", x => new { x.MarcaId, x.ProductoId });
                    table.ForeignKey(
                        name: "FK_clasificaciones_marcas_MarcaId",
                        column: x => x.MarcaId,
                        principalTable: "marcas",
                        principalColumn: "MarcaId");
                    table.ForeignKey(
                        name: "FK_clasificaciones_productos_ProductoId",
                        column: x => x.ProductoId,
                        principalTable: "productos",
                        principalColumn: "ProductoId");
                });

            migrationBuilder.CreateTable(
                name: "ofertas_det",
                columns: table => new
                {
                    Oferta_DetId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Precio = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LoteMinimo = table.Column<float>(type: "real", nullable: false),
                    Descuento = table.Column<float>(type: "real", nullable: false),
                    Garantia = table.Column<bool>(type: "bit", nullable: false),
                    TiempoEntrega = table.Column<int>(type: "int", nullable: false),
                    OfertaId = table.Column<int>(type: "int", nullable: false),
                    ProductoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ofertas_det", x => x.Oferta_DetId);
                    table.ForeignKey(
                        name: "FK_ofertas_det_ofertas_OfertaId",
                        column: x => x.OfertaId,
                        principalTable: "ofertas",
                        principalColumn: "OfertaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ofertas_det_productos_ProductoId",
                        column: x => x.ProductoId,
                        principalTable: "productos",
                        principalColumn: "ProductoId",
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
                    OfertaId = table.Column<int>(type: "int", nullable: false),
                    PeriodoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_postulaciones", x => x.PostulacionId);
                    table.ForeignKey(
                        name: "FK_postulaciones_ofertas_OfertaId",
                        column: x => x.OfertaId,
                        principalTable: "ofertas",
                        principalColumn: "OfertaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_postulaciones_periodos_PeriodoId",
                        column: x => x.PeriodoId,
                        principalTable: "periodos",
                        principalColumn: "PeriodoId");
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
                name: "IX_clasificaciones_ProductoId",
                table: "clasificaciones",
                column: "ProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_configuraciones_PeriodoId",
                table: "configuraciones",
                column: "PeriodoId");

            migrationBuilder.CreateIndex(
                name: "IX_ofertas_PeriodoId",
                table: "ofertas",
                column: "PeriodoId");

            migrationBuilder.CreateIndex(
                name: "IX_ofertas_det_OfertaId",
                table: "ofertas_det",
                column: "OfertaId");

            migrationBuilder.CreateIndex(
                name: "IX_ofertas_det_ProductoId",
                table: "ofertas_det",
                column: "ProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_postulaciones_OfertaId",
                table: "postulaciones",
                column: "OfertaId");

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
                name: "clasificaciones");

            migrationBuilder.DropTable(
                name: "configuraciones");

            migrationBuilder.DropTable(
                name: "ofertas_det");

            migrationBuilder.DropTable(
                name: "postulaciones_det");

            migrationBuilder.DropTable(
                name: "marcas");

            migrationBuilder.DropTable(
                name: "productos");

            migrationBuilder.DropTable(
                name: "postulaciones");

            migrationBuilder.DropTable(
                name: "ofertas");

            migrationBuilder.DropTable(
                name: "proveedores");

            migrationBuilder.DropTable(
                name: "periodos");
        }
    }
}
