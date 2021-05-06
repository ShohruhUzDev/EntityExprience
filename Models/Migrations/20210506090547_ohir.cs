using Microsoft.EntityFrameworkCore.Migrations;

namespace Models.Migrations
{
    public partial class ohir : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Mahsulotlar",
                table: "Mahsulotlar");

            migrationBuilder.AlterColumn<int>(
                name: "product_id",
                table: "Mahsulotlar",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "ismi",
                table: "Mahsulotlar",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Mahsulotlar_narxi",
                table: "Mahsulotlar",
                column: "narxi");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Mahsulotlar",
                table: "Mahsulotlar",
                column: "product_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "AK_Mahsulotlar_narxi",
                table: "Mahsulotlar");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Mahsulotlar",
                table: "Mahsulotlar");

            migrationBuilder.AlterColumn<string>(
                name: "ismi",
                table: "Mahsulotlar",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "product_id",
                table: "Mahsulotlar",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Mahsulotlar",
                table: "Mahsulotlar",
                column: "ismi");
        }
    }
}
