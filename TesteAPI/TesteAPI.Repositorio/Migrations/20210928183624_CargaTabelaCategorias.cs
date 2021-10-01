using Microsoft.EntityFrameworkCore.Migrations;

namespace TesteAPI.Repositorio.Migrations
{
    public partial class CargaTabelaCategorias : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "Codigo", "Descricao" },
                values: new object[] { 1, "Comportamental" });

            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "Codigo", "Descricao" },
                values: new object[] { 2, "Programação" });

            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "Codigo", "Descricao" },
                values: new object[] { 3, "Qualidade e Processos" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "Codigo",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "Codigo",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "Codigo",
                keyValue: 3);
        }
    }
}
