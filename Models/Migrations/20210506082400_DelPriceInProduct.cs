﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Models.Migrations
{
    public partial class DelPriceInProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Mahsulotlar");

            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "Mahsulotlar",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Mahsulotlar",
                type: "nvarchar(max)",
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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Mahsulotlar");

            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "Mahsulotlar",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
