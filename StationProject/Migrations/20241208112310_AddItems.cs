using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StationProject.Migrations
{
    /// <inheritdoc />
    public partial class AddItems : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KorzinaItems_AspNetUsers_ApplicationUserId",
                table: "KorzinaItems");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Orders_OrderId",
                table: "OrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_AspNetUsers_ApplicationUserId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_AspNetUsers_PublishedById",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Category_CategoryId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_CategoryId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_PublishedById",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Orders_ApplicationUserId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems");

            migrationBuilder.DropIndex(
                name: "IX_KorzinaItems_ApplicationUserId",
                table: "KorzinaItems");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "PublishedById",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "KorzinaItems");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "vendor-user-id", 0, "814eda41-288c-4649-aa44-1a3a3617128a", "vendor@vendor.com", true, false, null, null, null, "AQAAAAIAAYagAAAAEMUr0UWwK1X7jOCj6PAlCaCcoQDfYHoo7EcjAYfSj7wRDZnGWCBjVTKFlMSY5rSRgw==", null, false, "ea5051bb-f1fe-498a-b0ba-685b6ab37f00", false, "vendor1" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CreatedAt", "ImageUrls", "Name", "UpdatedAt" },
                values: new object[] { "ab4941b9-07d0-46fc-99b5-9e8df48e4a4a", null, new[] { "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRK-Vg_IFRtnL2WQsSiJFML7R22xC8i0FL11w&s" }, "Pens", null });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryKey", "CreatedAt", "Description", "ImageUrls", "MinCount", "Name", "Price", "PriceTemplate", "PublishedByKey", "TotalCount", "UpdatedAt" },
                values: new object[,]
                {
                    { "16fa280e-731e-45d9-bf0b-35b6d92bc8e4", "ab4941b9-07d0-46fc-99b5-9e8df48e4a4a", null, "Box of paper clips", new string[0], 0, "Paper Clips", 5, "$5", "vendor-user-id", 0, null },
                    { "1988e477-6558-4eb2-a5fe-9225506f729a", "ab4941b9-07d0-46fc-99b5-9e8df48e4a4a", null, "Graphite pencil", new string[0], 0, "Pencil", 1, "$1", "vendor-user-id", 0, null },
                    { "3142c5f9-d26f-42b9-a459-bf9536902a5a", "ab4941b9-07d0-46fc-99b5-9e8df48e4a4a", null, "Heavy-duty stapler", new string[0], 0, "Stapler", 25, "$25", "vendor-user-id", 0, null },
                    { "4704d438-b6e4-4076-b036-0767b269b004", "ab4941b9-07d0-46fc-99b5-9e8df48e4a4a", null, "Blue ballpoint pen", new string[0], 0, "Pen", 2, "$2", "vendor-user-id", 0, null },
                    { "990425c9-4374-4c5e-a668-410dbb6dfbfa", "ab4941b9-07d0-46fc-99b5-9e8df48e4a4a", null, "Desktop tape dispenser", new string[0], 0, "Tape Dispenser", 7, "$7", "vendor-user-id", 0, null },
                    { "c0c881bb-e001-4641-a7f0-8755badca05c", "ab4941b9-07d0-46fc-99b5-9e8df48e4a4a", null, "Fluorescent highlighter", new string[0], 0, "Highlighter", 3, "$3", "vendor-user-id", 0, null },
                    { "c32742c8-5548-4473-881b-2e3d527221fd", "ab4941b9-07d0-46fc-99b5-9e8df48e4a4a", null, "A5 ruled notebook", new string[0], 0, "Notebook", 10, "$10", "vendor-user-id", 0, null },
                    { "c553bb1f-f6d5-4520-bd0c-bc200af06296", "ab4941b9-07d0-46fc-99b5-9e8df48e4a4a", null, "Pack of sticky notes", new string[0], 0, "Sticky Notes", 4, "$4", "vendor-user-id", 0, null },
                    { "c79a5762-ce47-4c56-80cc-33209b2283b2", "ab4941b9-07d0-46fc-99b5-9e8df48e4a4a", null, "Stainless steel scissors", new string[0], 0, "Scissors", 6, "$6", "vendor-user-id", 0, null },
                    { "d5673e96-6015-43f6-ad91-eab1659343db", "ab4941b9-07d0-46fc-99b5-9e8df48e4a4a", null, "Set of whiteboard markers", new string[0], 0, "Whiteboard Marker", 8, "$8", "vendor-user-id", 0, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryKey",
                table: "Products",
                column: "CategoryKey");

            migrationBuilder.CreateIndex(
                name: "IX_Products_PublishedByKey",
                table: "Products",
                column: "PublishedByKey");

            migrationBuilder.AddForeignKey(
                name: "FK_KorzinaItems_AspNetUsers_Id",
                table: "KorzinaItems",
                column: "Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Orders_Id",
                table: "OrderItems",
                column: "Id",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_AspNetUsers_Id",
                table: "Orders",
                column: "Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_AspNetUsers_PublishedByKey",
                table: "Products",
                column: "PublishedByKey",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Category_CategoryKey",
                table: "Products",
                column: "CategoryKey",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KorzinaItems_AspNetUsers_Id",
                table: "KorzinaItems");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Orders_Id",
                table: "OrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_AspNetUsers_Id",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_AspNetUsers_PublishedByKey",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Category_CategoryKey",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_CategoryKey",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_PublishedByKey",
                table: "Products");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "16fa280e-731e-45d9-bf0b-35b6d92bc8e4");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "1988e477-6558-4eb2-a5fe-9225506f729a");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3142c5f9-d26f-42b9-a459-bf9536902a5a");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4704d438-b6e4-4076-b036-0767b269b004");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "990425c9-4374-4c5e-a668-410dbb6dfbfa");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c0c881bb-e001-4641-a7f0-8755badca05c");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c32742c8-5548-4473-881b-2e3d527221fd");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c553bb1f-f6d5-4520-bd0c-bc200af06296");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c79a5762-ce47-4c56-80cc-33209b2283b2");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d5673e96-6015-43f6-ad91-eab1659343db");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "vendor-user-id");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "ab4941b9-07d0-46fc-99b5-9e8df48e4a4a");

            migrationBuilder.AddColumn<string>(
                name: "CategoryId",
                table: "Products",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PublishedById",
                table: "Products",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Orders",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OrderId",
                table: "OrderItems",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "KorzinaItems",
                type: "text",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_PublishedById",
                table: "Products",
                column: "PublishedById");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ApplicationUserId",
                table: "Orders",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_KorzinaItems_ApplicationUserId",
                table: "KorzinaItems",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_KorzinaItems_AspNetUsers_ApplicationUserId",
                table: "KorzinaItems",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Orders_OrderId",
                table: "OrderItems",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_AspNetUsers_ApplicationUserId",
                table: "Orders",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_AspNetUsers_PublishedById",
                table: "Products",
                column: "PublishedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Category_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id");
        }
    }
}
