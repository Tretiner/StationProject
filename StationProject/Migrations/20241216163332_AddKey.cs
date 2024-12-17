using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StationProject.Migrations
{
    /// <inheritdoc />
    public partial class AddKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Products_SourceId",
                table: "OrderItems");

            migrationBuilder.DropIndex(
                name: "IX_OrderItems_SourceId",
                table: "OrderItems");

            migrationBuilder.AddColumn<string>(
                name: "SourceKey",
                table: "OrderItems",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_SourceKey",
                table: "OrderItems",
                column: "SourceKey",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Products_SourceKey",
                table: "OrderItems",
                column: "SourceKey",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Products_SourceKey",
                table: "OrderItems");

            migrationBuilder.DropIndex(
                name: "IX_OrderItems_SourceKey",
                table: "OrderItems");
            
            migrationBuilder.DropColumn(
                name: "SourceKey",
                table: "OrderItems");

            migrationBuilder.AddColumn<string>(
                name: "SourceId",
                table: "OrderItems",
                type: "text",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_SourceId",
                table: "OrderItems",
                column: "SourceId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Products_SourceId",
                table: "OrderItems",
                column: "SourceId",
                principalTable: "Products",
                principalColumn: "Id");
        }
    }
}
