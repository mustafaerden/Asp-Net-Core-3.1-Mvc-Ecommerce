using Microsoft.EntityFrameworkCore.Migrations;

namespace Azlan.Ecommerce.DataAccess.Migrations
{
    public partial class FeaturedImageIdAddedToProductTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Featured",
                table: "ProductImages");

            migrationBuilder.AddColumn<int>(
                name: "FeaturedImageId",
                table: "Products",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FeaturedImageId",
                table: "Products");

            migrationBuilder.AddColumn<bool>(
                name: "Featured",
                table: "ProductImages",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
