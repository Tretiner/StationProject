using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StationProject.Migrations
{
    /// <inheritdoc />
    public partial class AddOwnersId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_AspNetUsers_Id",
                table: "Orders");

            migrationBuilder.AddColumn<string>(
                name: "OrdererId",
                table: "Orders",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "OwnerId",
                table: "KorzinaItems",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_OrdererId",
                table: "Orders",
                column: "OrdererId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_AspNetUsers_OrdererId",
                table: "Orders",
                column: "OrdererId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_AspNetUsers_OrdererId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_OrdererId",
                table: "Orders");
            
            migrationBuilder.DropColumn(
                name: "OrdererId",
                table: "Orders");

            migrationBuilder.AlterColumn<string>(
                name: "OwnerId",
                table: "KorzinaItems",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_AspNetUsers_Id",
                table: "Orders",
                column: "Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
