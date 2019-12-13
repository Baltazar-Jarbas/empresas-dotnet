using Microsoft.EntityFrameworkCore.Migrations;

namespace AppEmpresas.Data.Migrations
{
    public partial class Migration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "OwnShares",
                table: "tb_enterprise",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Shares",
                table: "tb_enterprise",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OwnShares",
                table: "tb_enterprise");

            migrationBuilder.DropColumn(
                name: "Shares",
                table: "tb_enterprise");
        }
    }
}
