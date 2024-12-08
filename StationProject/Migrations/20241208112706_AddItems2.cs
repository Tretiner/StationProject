using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StationProject.Migrations
{
    /// <inheritdoc />
    public partial class AddItems2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0fcbb53c-a41a-4187-a84e-7d705c9eae8f", null, "Vendor", "Vendor" },
                    { "9096d211-02e4-4a9e-ba8c-264bc182d166", null, "Admin", "Admin" },
                    { "dd93ac13-65cd-4c87-8041-f946c0a813e0", null, "Joe", "Joe" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "admin", 0, "43e5a3bb-60c9-4b2f-a9e2-5967547e3ffe", "admin@admin.com", true, false, null, null, null, "AQAAAAIAAYagAAAAEMUr0UWwK1X7jOCj6PAlCaCcoQDfYHoo7EcjAYfSj7wRDZnGWCBjVTKFlMSY5rSRgw==", null, false, "7a3392d3-f7fb-406d-97a9-32c469a0e645", false, "admin" },
                    { "joe", 0, "37a0d191-150f-45a0-9b62-637654740cca", "joe@joe.com", true, false, null, null, null, "AQAAAAIAAYagAAAAEMUr0UWwK1X7jOCj6PAlCaCcoQDfYHoo7EcjAYfSj7wRDZnGWCBjVTKFlMSY5rSRgw==", null, false, "1bff4795-5731-4f2e-95e2-9568260a6182", false, "joe" },
                    { "vendor", 0, "48ad8f94-eb9d-4776-a0de-1a40d985a6c0", "vendor@vendor.com", true, false, null, null, null, "AQAAAAIAAYagAAAAEMUr0UWwK1X7jOCj6PAlCaCcoQDfYHoo7EcjAYfSj7wRDZnGWCBjVTKFlMSY5rSRgw==", null, false, "bce4cfeb-2741-4bad-b786-4143d4d5ada8", false, "vendor" }
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CreatedAt", "ImageUrls", "Name", "UpdatedAt" },
                values: new object[] { "a2c16485-2cea-41b0-be74-ad678edd0441", null, new[] { "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRK-Vg_IFRtnL2WQsSiJFML7R22xC8i0FL11w&s" }, "Pens", null });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "9096d211-02e4-4a9e-ba8c-264bc182d166", "admin" },
                    { "dd93ac13-65cd-4c87-8041-f946c0a813e0", "joe" },
                    { "0fcbb53c-a41a-4187-a84e-7d705c9eae8f", "vendor" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryKey", "CreatedAt", "Description", "ImageUrls", "MinCount", "Name", "Price", "PriceTemplate", "PublishedByKey", "TotalCount", "UpdatedAt" },
                values: new object[,]
                {
                    { "00f18bbf-09cc-41a4-9467-6058f2fd17fa", "a2c16485-2cea-41b0-be74-ad678edd0441", null, "A5 ruled notebook", new string[0], 0, "Notebook", 10, "$10", "vendor", 0, null },
                    { "0399a22b-6639-4464-96e8-02a6fbceae55", "a2c16485-2cea-41b0-be74-ad678edd0441", null, "Box of paper clips", new string[0], 0, "Paper Clips", 5, "$5", "vendor", 0, null },
                    { "154cc3f1-6a74-442b-9662-3caeb53c805b", "a2c16485-2cea-41b0-be74-ad678edd0441", null, "Desktop tape dispenser", new string[0], 0, "Tape Dispenser", 7, "$7", "vendor", 0, null },
                    { "5b2eea72-5653-40a9-9814-f6a1c8058e7f", "a2c16485-2cea-41b0-be74-ad678edd0441", null, "Stainless steel scissors", new string[0], 0, "Scissors", 6, "$6", "vendor", 0, null },
                    { "78fd0ee8-9379-42fe-bdcf-f8867ce8dfb8", "a2c16485-2cea-41b0-be74-ad678edd0441", null, "Heavy-duty stapler", new string[0], 0, "Stapler", 25, "$25", "vendor", 0, null },
                    { "87598589-3329-4e33-8367-cb6d1aedef53", "a2c16485-2cea-41b0-be74-ad678edd0441", null, "Fluorescent highlighter", new string[0], 0, "Highlighter", 3, "$3", "vendor", 0, null },
                    { "a5ece3b0-017f-4431-9779-209a0c566fd3", "a2c16485-2cea-41b0-be74-ad678edd0441", null, "Blue ballpoint pen", new string[0], 0, "Pen", 2, "$2", "vendor", 0, null },
                    { "b3d9c4a5-449b-4de9-94cc-63c0c8e1d022", "a2c16485-2cea-41b0-be74-ad678edd0441", null, "Pack of sticky notes", new string[0], 0, "Sticky Notes", 4, "$4", "vendor", 0, null },
                    { "bfcb68b5-74d5-41a4-9bd5-1850ddc83f56", "a2c16485-2cea-41b0-be74-ad678edd0441", null, "Set of whiteboard markers", new string[0], 0, "Whiteboard Marker", 8, "$8", "vendor", 0, null },
                    { "dc42b916-8781-4dbb-acb2-2456edabc164", "a2c16485-2cea-41b0-be74-ad678edd0441", null, "Graphite pencil", new string[0], 0, "Pencil", 1, "$1", "vendor", 0, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9096d211-02e4-4a9e-ba8c-264bc182d166", "admin" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "dd93ac13-65cd-4c87-8041-f946c0a813e0", "joe" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0fcbb53c-a41a-4187-a84e-7d705c9eae8f", "vendor" });

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00f18bbf-09cc-41a4-9467-6058f2fd17fa");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0399a22b-6639-4464-96e8-02a6fbceae55");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "154cc3f1-6a74-442b-9662-3caeb53c805b");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5b2eea72-5653-40a9-9814-f6a1c8058e7f");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "78fd0ee8-9379-42fe-bdcf-f8867ce8dfb8");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "87598589-3329-4e33-8367-cb6d1aedef53");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a5ece3b0-017f-4431-9779-209a0c566fd3");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b3d9c4a5-449b-4de9-94cc-63c0c8e1d022");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "bfcb68b5-74d5-41a4-9bd5-1850ddc83f56");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "dc42b916-8781-4dbb-acb2-2456edabc164");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0fcbb53c-a41a-4187-a84e-7d705c9eae8f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9096d211-02e4-4a9e-ba8c-264bc182d166");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dd93ac13-65cd-4c87-8041-f946c0a813e0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "joe");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "vendor");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "a2c16485-2cea-41b0-be74-ad678edd0441");

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
        }
    }
}
