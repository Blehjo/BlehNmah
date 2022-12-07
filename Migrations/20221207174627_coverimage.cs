using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RazorPagesBlehNmah.Migrations
{
    /// <inheritdoc />
    public partial class coverimage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Photograph",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Painting",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CoverImage",
                table: "Collection",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Collection",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Photograph");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Painting");

            migrationBuilder.DropColumn(
                name: "CoverImage",
                table: "Collection");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Collection");
        }
    }
}
