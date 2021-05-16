using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Rema1000ApiProject.Migrations
{
    public partial class createdRecursiveCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductTypes_TypeProductTypeID",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "TypeProductTypeID",
                table: "Products",
                newName: "ProductTypeID");

            migrationBuilder.RenameIndex(
                name: "IX_Products_TypeProductTypeID",
                table: "Products",
                newName: "IX_Products_ProductTypeID");

            migrationBuilder.AddColumn<Guid>(
                name: "ProductCategoryCategoryID",
                table: "Products",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ParentCategoryCategoryID",
                table: "Categories",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductCategoryCategoryID",
                table: "Products",
                column: "ProductCategoryCategoryID");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_ProductCategoryCategoryID",
                table: "Products",
                column: "ProductCategoryCategoryID",
                principalTable: "Categories",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductTypes_ProductTypeID",
                table: "Products",
                column: "ProductTypeID",
                principalTable: "ProductTypes",
                principalColumn: "ProductTypeID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Categories_ParentCategoryCategoryID",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_ProductCategoryCategoryID",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductTypes_ProductTypeID",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_ProductCategoryCategoryID",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Categories_ParentCategoryCategoryID",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "ProductCategoryCategoryID",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ParentCategoryCategoryID",
                table: "Categories");

            migrationBuilder.RenameColumn(
                name: "ProductTypeID",
                table: "Products",
                newName: "TypeProductTypeID");

            migrationBuilder.RenameIndex(
                name: "IX_Products_ProductTypeID",
                table: "Products",
                newName: "IX_Products_TypeProductTypeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductTypes_TypeProductTypeID",
                table: "Products",
                column: "TypeProductTypeID",
                principalTable: "ProductTypes",
                principalColumn: "ProductTypeID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
