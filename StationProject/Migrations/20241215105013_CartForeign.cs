using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StationProject.Migrations
{
    /// <inheritdoc />
    public partial class CartForeign : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KorzinaItems_AspNetUsers_Id",
                table: "KorzinaItems");
            
            migrationBuilder.AddColumn<string>(
                name: "OwnerId",
                table: "KorzinaItems",
                type: "text",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_KorzinaItems_OwnerId",
                table: "KorzinaItems",
                column: "OwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_KorzinaItems_AspNetUsers_OwnerId",
                table: "KorzinaItems",
                column: "OwnerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KorzinaItems_AspNetUsers_OwnerId",
                table: "KorzinaItems");

            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "KorzinaItems");

            migrationBuilder.AddForeignKey(
                name: "FK_KorzinaItems_AspNetUsers_Id",
                table: "KorzinaItems",
                column: "Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
