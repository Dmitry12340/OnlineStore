using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineStore.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class products : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Product_Name",
                table: "Product",
                column: "Name");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Product_Name",
                table: "Product");
        }
    }
}
