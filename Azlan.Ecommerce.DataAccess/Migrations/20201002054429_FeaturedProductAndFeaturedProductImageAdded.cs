using Microsoft.EntityFrameworkCore.Migrations;

namespace Azlan.Ecommerce.DataAccess.Migrations
{
    public partial class FeaturedProductAndFeaturedProductImageAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Featured",
                table: "Products",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Featured",
                table: "ProductImages",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Featured",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Featured",
                table: "ProductImages");
        }
    }
}
