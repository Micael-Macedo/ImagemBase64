using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoBase64.Migrations
{
    public partial class RemoveFkUserInCurriculo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Curriculos_Usuarios_FkUsuario",
                table: "Curriculos");

            migrationBuilder.DropForeignKey(
                name: "FK_Fotos_Usuarios_FkUsuario",
                table: "Fotos");

            migrationBuilder.DropIndex(
                name: "IX_Fotos_FkUsuario",
                table: "Fotos");

            migrationBuilder.DropIndex(
                name: "IX_Curriculos_FkUsuario",
                table: "Curriculos");

            migrationBuilder.DropColumn(
                name: "FkUsuario",
                table: "Curriculos");

            migrationBuilder.DropColumn(
                name: "Foto",
                table: "Curriculos");

            migrationBuilder.RenameColumn(
                name: "FotoUsuario",
                table: "Fotos",
                newName: "FotoPerfil");

            migrationBuilder.RenameColumn(
                name: "FkUsuario",
                table: "Fotos",
                newName: "FkCurriculo");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Usuarios",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "FkCurrilo",
                table: "Usuarios",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FotoId",
                table: "Usuarios",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_FkCurrilo",
                table: "Usuarios",
                column: "FkCurrilo");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_FotoId",
                table: "Usuarios",
                column: "FotoId");

            migrationBuilder.CreateIndex(
                name: "IX_Fotos_FkCurriculo",
                table: "Fotos",
                column: "FkCurriculo");

            migrationBuilder.AddForeignKey(
                name: "FK_Fotos_Curriculos_FkCurriculo",
                table: "Fotos",
                column: "FkCurriculo",
                principalTable: "Curriculos",
                principalColumn: "CurriculoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Curriculos_FkCurrilo",
                table: "Usuarios",
                column: "FkCurrilo",
                principalTable: "Curriculos",
                principalColumn: "CurriculoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Fotos_FotoId",
                table: "Usuarios",
                column: "FotoId",
                principalTable: "Fotos",
                principalColumn: "FotoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fotos_Curriculos_FkCurriculo",
                table: "Fotos");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Curriculos_FkCurrilo",
                table: "Usuarios");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Fotos_FotoId",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_FkCurrilo",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_FotoId",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Fotos_FkCurriculo",
                table: "Fotos");

            migrationBuilder.DropColumn(
                name: "FkCurrilo",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "FotoId",
                table: "Usuarios");

            migrationBuilder.RenameColumn(
                name: "FotoPerfil",
                table: "Fotos",
                newName: "FotoUsuario");

            migrationBuilder.RenameColumn(
                name: "FkCurriculo",
                table: "Fotos",
                newName: "FkUsuario");

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Nome",
                keyValue: null,
                column: "Nome",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Usuarios",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "FkUsuario",
                table: "Curriculos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Foto",
                table: "Curriculos",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Fotos_FkUsuario",
                table: "Fotos",
                column: "FkUsuario",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Curriculos_FkUsuario",
                table: "Curriculos",
                column: "FkUsuario");

            migrationBuilder.AddForeignKey(
                name: "FK_Curriculos_Usuarios_FkUsuario",
                table: "Curriculos",
                column: "FkUsuario",
                principalTable: "Usuarios",
                principalColumn: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Fotos_Usuarios_FkUsuario",
                table: "Fotos",
                column: "FkUsuario",
                principalTable: "Usuarios",
                principalColumn: "UsuarioId");
        }
    }
}
