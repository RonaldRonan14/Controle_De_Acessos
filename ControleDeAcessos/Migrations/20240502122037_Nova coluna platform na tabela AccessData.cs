using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ControleDeAcessos.Migrations
{
    public partial class NovacolunaplatformnatabelaAccessData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "platform",
                table: "AccessData",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "platform",
                table: "AccessData");
        }
    }
}
