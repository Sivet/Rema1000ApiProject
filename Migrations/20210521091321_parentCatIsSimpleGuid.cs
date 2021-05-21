using Microsoft.EntityFrameworkCore.Migrations;

namespace Rema1000ApiProject.Migrations
{
    public partial class parentCatIsSimpleGuid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Categories_ParentCategoryCategoryID",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Categories_ParentCategoryCategoryID",
                table: "Categories");

            migrationBuilder.RenameColumn(
                name: "ParentCategoryCategoryID",
                table: "Categories",
                newName: "ParentCategory");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ParentCategory",
                table: "Categories",
                newName: "ParentCategoryCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_ParentCategoryCategoryID",
                table: "Categories",
                column: "ParentCategoryCategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Categories_ParentCategoryCategoryID",
                table: "Categories",
                column: "ParentCategoryCategoryID",
                principalTable: "Categories",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
