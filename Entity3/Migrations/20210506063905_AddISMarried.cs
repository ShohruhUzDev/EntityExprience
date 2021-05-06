using Microsoft.EntityFrameworkCore.Migrations;

namespace Entity3.Migrations
{
    public partial class AddISMarried : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsMarried",
                table: "Students",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsMarried",
                table: "Students");
        }
    }
}
