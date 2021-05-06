using Microsoft.EntityFrameworkCore.Migrations;

namespace Models.Migrations
{
    public partial class EditID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "product_id",
                table: "Mahrulotlar",
                newName: "product_idsi");

            migrationBuilder.RenameIndex(
                name: "IX_Mahsulotlar_CompanyId",
                table: "Mahrulotlar",
                newName: "IX_Mahrulotlar_CompanyId");

            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "Mahrulotlar",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Mahrulotlar",
                table: "Mahrulotlar",
                column: "product_idsi");

            migrationBuilder.AddForeignKey(
                name: "FK_Mahrulotlar_Company_CompanyId",
                table: "Mahrulotlar",
                column: "CompanyId",
                principalTable: "Company",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mahrulotlar_Company_CompanyId",
                table: "Mahrulotlar");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Mahrulotlar",
                table: "Mahrulotlar");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Mahrulotlar");

            migrationBuilder.RenameTable(
                name: "Mahrulotlar",
                newName: "Mahsulotlar");

            migrationBuilder.RenameColumn(
                name: "product_idsi",
                table: "Mahsulotlar",
                newName: "product_id");

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
    }
}
