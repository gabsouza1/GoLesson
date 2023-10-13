using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infra.Migrations
{
    /// <inheritdoc />
    public partial class CompraCursos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CursoId",
                table: "Compras",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Compras_CursoId",
                table: "Compras",
                column: "CursoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Compras_Cursos_CursoId",
                table: "Compras",
                column: "CursoId",
                principalTable: "Cursos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Compras_Cursos_CursoId",
                table: "Compras");

            migrationBuilder.DropIndex(
                name: "IX_Compras_CursoId",
                table: "Compras");

            migrationBuilder.DropColumn(
                name: "CursoId",
                table: "Compras");
        }
    }
}
