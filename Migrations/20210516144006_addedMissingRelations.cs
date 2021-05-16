using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Rema1000ApiProject.Migrations
{
    public partial class addedMissingRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ProductTypeCategoryCategoryID",
                table: "ProductTypes",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductTypes_ProductTypeCategoryCategoryID",
                table: "ProductTypes",
                column: "ProductTypeCategoryCategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductTypes_Categories_ProductTypeCategoryCategoryID",
                table: "ProductTypes",
                column: "ProductTypeCategoryCategoryID",
                principalTable: "Categories",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductTypes_Categories_ProductTypeCategoryCategoryID",
                table: "ProductTypes");

            migrationBuilder.DropIndex(
                name: "IX_ProductTypes_ProductTypeCategoryCategoryID",
                table: "ProductTypes");

            migrationBuilder.DropColumn(
                name: "ProductTypeCategoryCategoryID",
                table: "ProductTypes");
        }
    }
}
