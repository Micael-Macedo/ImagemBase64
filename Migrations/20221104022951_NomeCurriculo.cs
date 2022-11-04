using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoBase64.Migrations
{
    public partial class NomeCurriculo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "Curriculos",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nome",
                table: "Curriculos");
        }
    }
}
