using Microsoft.EntityFrameworkCore.Migrations;

namespace AppEmpresas.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_enterprise_type",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(250)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_enterprise_type", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_enterprise",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "varchar(100)", nullable: true),
                    Facebook = table.Column<string>(type: "varchar(100)", nullable: true),
                    Twitter = table.Column<string>(type: "varchar(100)", nullable: true),
                    Linkedin = table.Column<string>(type: "varchar(100)", nullable: true),
                    Phone = table.Column<string>(type: "varchar(100)", nullable: true),
                    OwnEnterprise = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(type: "varchar(100)", nullable: true),
                    Photo = table.Column<string>(type: "varchar(100)", nullable: true),
                    Description = table.Column<string>(type: "varchar(100)", nullable: true),
                    City = table.Column<string>(type: "varchar(100)", nullable: true),
                    Country = table.Column<string>(type: "varchar(100)", nullable: true),
                    Value = table.Column<int>(nullable: false),
                    SharePrice = table.Column<decimal>(nullable: false),
                    EnterpriseTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_enterprise", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tb_enterprise_tb_enterprise_type_EnterpriseTypeId",
                        column: x => x.EnterpriseTypeId,
                        principalTable: "tb_enterprise_type",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tb_enterprise_EnterpriseTypeId",
                table: "tb_enterprise",
                column: "EnterpriseTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_enterprise");

            migrationBuilder.DropTable(
                name: "tb_enterprise_type");
        }
    }
}
