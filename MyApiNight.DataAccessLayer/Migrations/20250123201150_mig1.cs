using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyApiNight.DataAccessLayer.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Writers_WriterId",
                table: "Books");

            migrationBuilder.RenameColumn(
                name: "WriterId",
                table: "Writers",
                newName: "WriterID");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "Products",
                newName: "ProductID");

            migrationBuilder.RenameColumn(
                name: "FeatureId",
                table: "Features",
                newName: "FeatureID");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Categories",
                newName: "CategoryID");

            migrationBuilder.RenameColumn(
                name: "WriterId",
                table: "Books",
                newName: "WriterID");

            migrationBuilder.RenameColumn(
                name: "BookId",
                table: "Books",
                newName: "BookID");

            migrationBuilder.RenameIndex(
                name: "IX_Books_WriterId",
                table: "Books",
                newName: "IX_Books_WriterID");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Writers_WriterID",
                table: "Books",
                column: "WriterID",
                principalTable: "Writers",
                principalColumn: "WriterID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Writers_WriterID",
                table: "Books");

            migrationBuilder.RenameColumn(
                name: "WriterID",
                table: "Writers",
                newName: "WriterId");

            migrationBuilder.RenameColumn(
                name: "ProductID",
                table: "Products",
                newName: "ProductId");

            migrationBuilder.RenameColumn(
                name: "FeatureID",
                table: "Features",
                newName: "FeatureId");

            migrationBuilder.RenameColumn(
                name: "CategoryID",
                table: "Categories",
                newName: "CategoryId");

            migrationBuilder.RenameColumn(
                name: "WriterID",
                table: "Books",
                newName: "WriterId");

            migrationBuilder.RenameColumn(
                name: "BookID",
                table: "Books",
                newName: "BookId");

            migrationBuilder.RenameIndex(
                name: "IX_Books_WriterID",
                table: "Books",
                newName: "IX_Books_WriterId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Writers_WriterId",
                table: "Books",
                column: "WriterId",
                principalTable: "Writers",
                principalColumn: "WriterId");
        }
    }
}
