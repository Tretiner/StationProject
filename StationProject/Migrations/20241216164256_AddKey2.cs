using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StationProject.Migrations
{
    /// <inheritdoc />
    public partial class AddKey2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Orders_Id",
                table: "OrderItems");

            migrationBuilder.AddColumn<string>(
                name: "OrderKey",
                table: "OrderItems",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderKey",
                table: "OrderItems",
                column: "OrderKey");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Orders_OrderKey",
                table: "OrderItems",
                column: "OrderKey",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Orders_OrderKey",
                table: "OrderItems");

            migrationBuilder.DropIndex(
                name: "IX_OrderItems_OrderKey",
                table: "OrderItems");

            
            migrationBuilder.DropColumn(
                name: "OrderKey",
                table: "OrderItems");
            
            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Orders_Id",
                table: "OrderItems",
                column: "Id",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
