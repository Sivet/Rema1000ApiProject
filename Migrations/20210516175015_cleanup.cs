using Microsoft.EntityFrameworkCore.Migrations;

namespace Rema1000ApiProject.Migrations
{
    public partial class cleanup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Products",
                newName: "SalesPrice");

            migrationBuilder.AddColumn<decimal>(
                name: "GrossPrice",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GrossPrice",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "SalesPrice",
                table: "Products",
                newName: "Price");
        }
    }
}
