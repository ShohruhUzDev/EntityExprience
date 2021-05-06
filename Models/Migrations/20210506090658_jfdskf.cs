using Microsoft.EntityFrameworkCore.Migrations;

namespace Models.Migrations
{
    public partial class jfdskf : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mahsulotlar_Company_CompanyId",
                table: "Mahsulotlar");

            migrationBuilder.DropTable(
                name: "Company");

            migrationBuilder.DropIndex(
                name: "IX_Mahsulotlar_CompanyId",
                table: "Mahsulotlar");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "Mahsulotlar");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "Mahsulotlar",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Mahsulotlar_CompanyId",
                table: "Mahsulotlar",
                column: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Mahsulotlar_Company_CompanyId",
                table: "Mahsulotlar",
                column: "CompanyId",
                principalTable: "Company",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
