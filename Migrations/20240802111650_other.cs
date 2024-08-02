using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContaHoueseMvc.Migrations
{
    public partial class other : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CódigoDeBarras",
                table: "Contas");

            migrationBuilder.RenameColumn(
                name: "NomeConta",
                table: "Contas",
                newName: "NomeDaConta");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NomeDaConta",
                table: "Contas",
                newName: "NomeConta");

            migrationBuilder.AddColumn<string>(
                name: "CódigoDeBarras",
                table: "Contas",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }
    }
}
