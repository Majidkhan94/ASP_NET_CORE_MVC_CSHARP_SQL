using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VibePhone.Migrations
{
    /// <inheritdoc />
    public partial class updategallery : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "ImageGallery",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "ImageGallery",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "ProductName",
                table: "ImageGallery",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "ImageGallery");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "ImageGallery");

            migrationBuilder.DropColumn(
                name: "ProductName",
                table: "ImageGallery");
        }
    }
}
