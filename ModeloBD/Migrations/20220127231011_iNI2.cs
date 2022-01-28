using Microsoft.EntityFrameworkCore.Migrations;

namespace ModeloBD.Migrations
{
    public partial class iNI2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_postulaciones_ofertas_OfertaId",
                table: "postulaciones");

            migrationBuilder.AlterColumn<int>(
                name: "OfertaId",
                table: "postulaciones",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_postulaciones_ofertas_OfertaId",
                table: "postulaciones",
                column: "OfertaId",
                principalTable: "ofertas",
                principalColumn: "OfertaId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_postulaciones_ofertas_OfertaId",
                table: "postulaciones");

            migrationBuilder.AlterColumn<int>(
                name: "OfertaId",
                table: "postulaciones",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_postulaciones_ofertas_OfertaId",
                table: "postulaciones",
                column: "OfertaId",
                principalTable: "ofertas",
                principalColumn: "OfertaId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
