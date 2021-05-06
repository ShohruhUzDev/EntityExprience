using Microsoft.EntityFrameworkCore.Migrations;

namespace Models.Migrations
{
    public partial class newedit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Mahrulotlar",
                newName: "narxi");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Mahrulotlar",
                newName: "ismi");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Mahrulotlar",
                newName: "tarifi");

            migrationBuilder.RenameColumn(
                name: "product_idsi",
                table: "Mahrulotlar",
                newName: "product_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "tarifi",
                table: "Mahrulotlar",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "narxi",
                table: "Mahrulotlar",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "ismi",
                table: "Mahrulotlar",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "product_id",
                table: "Mahrulotlar",
                newName: "product_idsi");
        }
    }
}
