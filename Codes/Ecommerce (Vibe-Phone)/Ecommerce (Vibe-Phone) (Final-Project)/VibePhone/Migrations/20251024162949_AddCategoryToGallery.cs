using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VibePhone.Migrations
{
    /// <inheritdoc />
    public partial class AddCategoryToGallery : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "ImageGallery",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ImageGallery_CategoryId",
                table: "ImageGallery",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_ImageGallery_Categories_CategoryId",
                table: "ImageGallery",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ImageGallery_Categories_CategoryId",
                table: "ImageGallery");

            migrationBuilder.DropIndex(
                name: "IX_ImageGallery_CategoryId",
                table: "ImageGallery");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "ImageGallery");
        }
    }
}
