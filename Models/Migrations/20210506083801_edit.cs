using Microsoft.EntityFrameworkCore.Migrations;

namespace Models.Migrations
{
    public partial class edit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mahrulotlar_Company_CompanyId",
                table: "Mahrulotlar");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Mahrulotlar",
                table: "Mahrulotlar");

            migrationBuilder.RenameTable(
                name: "Mahrulotlar",
                newName: "Mahsulotlar");

            migrationBuilder.RenameIndex(
                name: "IX_Mahrulotlar_CompanyId",
                table: "Mahsulotlar",
                newName: "IX_Mahsulotlar_CompanyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Mahsulotlar",
                table: "Mahsulotlar",
                column: "product_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Mahsulotlar_Company_CompanyId",
                table: "Mahsulotlar",
                column: "CompanyId",
                principalTable: "Company",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mahsulotlar_Company_CompanyId",
                table: "Mahsulotlar");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Mahsulotlar",
                table: "Mahsulotlar");

            migrationBuilder.RenameTable(
                name: "Mahsulotlar",
                newName: "Mahrulotlar");

            migrationBuilder.RenameIndex(
                name: "IX_Mahsulotlar_CompanyId",
                table: "Mahrulotlar",
                newName: "IX_Mahrulotlar_CompanyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Mahrulotlar",
                table: "Mahrulotlar",
                column: "product_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Mahrulotlar_Company_CompanyId",
                table: "Mahrulotlar",
                column: "CompanyId",
                principalTable: "Company",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
