using Microsoft.EntityFrameworkCore.Migrations;

namespace Models.Migrations
{
    public partial class EditColName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Mahsulotlar",
                newName: "product_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "product_id",
                table: "Mahsulotlar",
                newName: "Id");
        }
    }
}
