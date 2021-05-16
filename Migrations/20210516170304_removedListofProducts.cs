using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Rema1000ApiProject.Migrations
{
    public partial class removedListofProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductTypes_ProductTypeID",
                table: "Products");

            migrationBuilder.DropTable(
                name: "ProductTypes");

            migrationBuilder.DropIndex(
                name: "IX_Products_ProductTypeID",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductTypeID",
                table: "Products");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ProductTypeID",
                table: "Products",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ProductTypes",
                columns: table => new
                {
                    ProductTypeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductTypeCategoryCategoryID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ProductTypeDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTypes", x => x.ProductTypeID);
                    table.ForeignKey(
                        name: "FK_ProductTypes_Categories_ProductTypeCategoryCategoryID",
                        column: x => x.ProductTypeCategoryCategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductTypeID",
                table: "Products",
                column: "ProductTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductTypes_ProductTypeCategoryCategoryID",
                table: "ProductTypes",
                column: "ProductTypeCategoryCategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductTypes_ProductTypeID",
                table: "Products",
                column: "ProductTypeID",
                principalTable: "ProductTypes",
                principalColumn: "ProductTypeID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
