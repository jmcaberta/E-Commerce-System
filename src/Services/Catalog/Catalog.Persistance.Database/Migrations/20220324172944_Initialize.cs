using Microsoft.EntityFrameworkCore.Migrations;

namespace Catalog.Persistance.Database.Migrations
{
    public partial class Initialize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Catalog");

            migrationBuilder.CreateTable(
                name: "Products",
                schema: "Catalog",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Description = table.Column<string>(maxLength: 500, nullable: false),
                    Price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Stocks",
                schema: "Catalog",
                columns: table => new
                {
                    ProductInStockId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(nullable: false),
                    Stock = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stocks", x => x.ProductInStockId);
                    table.ForeignKey(
                        name: "FK_Stocks_Products_ProductId",
                        column: x => x.ProductId,
                        principalSchema: "Catalog",
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Products",
                columns: new[] { "ProductId", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Description for product 1", "Product 1", 131m },
                    { 73, "Description for product 73", "Product 73", 799m },
                    { 72, "Description for product 72", "Product 72", 972m },
                    { 71, "Description for product 71", "Product 71", 821m },
                    { 70, "Description for product 70", "Product 70", 789m },
                    { 69, "Description for product 69", "Product 69", 443m },
                    { 68, "Description for product 68", "Product 68", 991m },
                    { 67, "Description for product 67", "Product 67", 987m },
                    { 66, "Description for product 66", "Product 66", 741m },
                    { 65, "Description for product 65", "Product 65", 751m },
                    { 64, "Description for product 64", "Product 64", 442m },
                    { 63, "Description for product 63", "Product 63", 473m },
                    { 62, "Description for product 62", "Product 62", 816m },
                    { 61, "Description for product 61", "Product 61", 564m },
                    { 60, "Description for product 60", "Product 60", 651m },
                    { 59, "Description for product 59", "Product 59", 403m },
                    { 58, "Description for product 58", "Product 58", 419m },
                    { 57, "Description for product 57", "Product 57", 676m },
                    { 56, "Description for product 56", "Product 56", 659m },
                    { 55, "Description for product 55", "Product 55", 261m },
                    { 54, "Description for product 54", "Product 54", 575m },
                    { 53, "Description for product 53", "Product 53", 393m },
                    { 74, "Description for product 74", "Product 74", 840m },
                    { 52, "Description for product 52", "Product 52", 397m },
                    { 75, "Description for product 75", "Product 75", 104m },
                    { 77, "Description for product 77", "Product 77", 864m },
                    { 98, "Description for product 98", "Product 98", 265m },
                    { 97, "Description for product 97", "Product 97", 680m },
                    { 96, "Description for product 96", "Product 96", 185m },
                    { 95, "Description for product 95", "Product 95", 810m },
                    { 94, "Description for product 94", "Product 94", 922m },
                    { 93, "Description for product 93", "Product 93", 512m },
                    { 92, "Description for product 92", "Product 92", 791m },
                    { 91, "Description for product 91", "Product 91", 841m },
                    { 90, "Description for product 90", "Product 90", 826m },
                    { 89, "Description for product 89", "Product 89", 723m },
                    { 88, "Description for product 88", "Product 88", 917m },
                    { 87, "Description for product 87", "Product 87", 462m },
                    { 86, "Description for product 86", "Product 86", 530m },
                    { 85, "Description for product 85", "Product 85", 871m },
                    { 84, "Description for product 84", "Product 84", 931m },
                    { 83, "Description for product 83", "Product 83", 907m },
                    { 82, "Description for product 82", "Product 82", 602m },
                    { 81, "Description for product 81", "Product 81", 536m },
                    { 80, "Description for product 80", "Product 80", 224m },
                    { 79, "Description for product 79", "Product 79", 938m },
                    { 78, "Description for product 78", "Product 78", 424m },
                    { 76, "Description for product 76", "Product 76", 899m },
                    { 51, "Description for product 51", "Product 51", 210m },
                    { 50, "Description for product 50", "Product 50", 232m },
                    { 49, "Description for product 49", "Product 49", 837m },
                    { 22, "Description for product 22", "Product 22", 472m },
                    { 21, "Description for product 21", "Product 21", 953m },
                    { 20, "Description for product 20", "Product 20", 906m },
                    { 19, "Description for product 19", "Product 19", 215m },
                    { 18, "Description for product 18", "Product 18", 374m },
                    { 17, "Description for product 17", "Product 17", 789m },
                    { 16, "Description for product 16", "Product 16", 932m },
                    { 15, "Description for product 15", "Product 15", 306m },
                    { 14, "Description for product 14", "Product 14", 829m },
                    { 13, "Description for product 13", "Product 13", 876m },
                    { 12, "Description for product 12", "Product 12", 480m },
                    { 11, "Description for product 11", "Product 11", 497m },
                    { 10, "Description for product 10", "Product 10", 579m },
                    { 9, "Description for product 9", "Product 9", 424m },
                    { 8, "Description for product 8", "Product 8", 538m },
                    { 7, "Description for product 7", "Product 7", 562m },
                    { 6, "Description for product 6", "Product 6", 154m },
                    { 5, "Description for product 5", "Product 5", 496m },
                    { 4, "Description for product 4", "Product 4", 289m },
                    { 3, "Description for product 3", "Product 3", 350m },
                    { 2, "Description for product 2", "Product 2", 170m },
                    { 23, "Description for product 23", "Product 23", 493m },
                    { 24, "Description for product 24", "Product 24", 931m },
                    { 25, "Description for product 25", "Product 25", 885m },
                    { 26, "Description for product 26", "Product 26", 845m },
                    { 48, "Description for product 48", "Product 48", 988m },
                    { 47, "Description for product 47", "Product 47", 408m },
                    { 46, "Description for product 46", "Product 46", 760m },
                    { 45, "Description for product 45", "Product 45", 993m },
                    { 44, "Description for product 44", "Product 44", 169m },
                    { 43, "Description for product 43", "Product 43", 607m },
                    { 42, "Description for product 42", "Product 42", 154m },
                    { 41, "Description for product 41", "Product 41", 902m },
                    { 40, "Description for product 40", "Product 40", 375m },
                    { 39, "Description for product 39", "Product 39", 574m },
                    { 99, "Description for product 99", "Product 99", 417m },
                    { 38, "Description for product 38", "Product 38", 816m },
                    { 36, "Description for product 36", "Product 36", 517m },
                    { 35, "Description for product 35", "Product 35", 485m },
                    { 34, "Description for product 34", "Product 34", 885m },
                    { 33, "Description for product 33", "Product 33", 492m },
                    { 32, "Description for product 32", "Product 32", 756m },
                    { 31, "Description for product 31", "Product 31", 828m },
                    { 30, "Description for product 30", "Product 30", 981m },
                    { 29, "Description for product 29", "Product 29", 164m },
                    { 28, "Description for product 28", "Product 28", 745m },
                    { 27, "Description for product 27", "Product 27", 590m },
                    { 37, "Description for product 37", "Product 37", 211m },
                    { 100, "Description for product 100", "Product 100", 352m }
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Stocks",
                columns: new[] { "ProductInStockId", "ProductId", "Stock" },
                values: new object[,]
                {
                    { 1, 1, 12 },
                    { 73, 73, 19 },
                    { 72, 72, 9 },
                    { 71, 71, 19 },
                    { 70, 70, 14 },
                    { 69, 69, 17 },
                    { 68, 68, 11 },
                    { 67, 67, 11 },
                    { 66, 66, 4 },
                    { 65, 65, 10 },
                    { 64, 64, 7 },
                    { 63, 63, 10 },
                    { 62, 62, 7 },
                    { 61, 61, 14 },
                    { 60, 60, 8 },
                    { 59, 59, 4 },
                    { 58, 58, 14 },
                    { 57, 57, 19 },
                    { 56, 56, 15 },
                    { 55, 55, 18 },
                    { 54, 54, 5 },
                    { 53, 53, 6 },
                    { 74, 74, 13 },
                    { 52, 52, 8 },
                    { 75, 75, 0 },
                    { 77, 77, 3 },
                    { 98, 98, 6 },
                    { 97, 97, 9 },
                    { 96, 96, 0 },
                    { 95, 95, 16 },
                    { 94, 94, 1 },
                    { 93, 93, 2 },
                    { 92, 92, 7 },
                    { 91, 91, 9 },
                    { 90, 90, 2 },
                    { 89, 89, 0 },
                    { 88, 88, 10 },
                    { 87, 87, 18 },
                    { 86, 86, 17 },
                    { 85, 85, 3 },
                    { 84, 84, 16 },
                    { 83, 83, 9 },
                    { 82, 82, 5 },
                    { 81, 81, 11 },
                    { 80, 80, 6 },
                    { 79, 79, 4 },
                    { 78, 78, 18 },
                    { 76, 76, 11 },
                    { 51, 51, 14 },
                    { 50, 50, 5 },
                    { 49, 49, 8 },
                    { 22, 22, 17 },
                    { 21, 21, 11 },
                    { 20, 20, 7 },
                    { 19, 19, 3 },
                    { 18, 18, 9 },
                    { 17, 17, 15 },
                    { 16, 16, 2 },
                    { 15, 15, 3 },
                    { 14, 14, 15 },
                    { 13, 13, 9 },
                    { 12, 12, 7 },
                    { 11, 11, 8 },
                    { 10, 10, 16 },
                    { 9, 9, 5 },
                    { 8, 8, 12 },
                    { 7, 7, 4 },
                    { 6, 6, 0 },
                    { 5, 5, 10 },
                    { 4, 4, 11 },
                    { 3, 3, 16 },
                    { 2, 2, 15 },
                    { 23, 23, 16 },
                    { 24, 24, 1 },
                    { 25, 25, 7 },
                    { 26, 26, 2 },
                    { 48, 48, 0 },
                    { 47, 47, 11 },
                    { 46, 46, 0 },
                    { 45, 45, 17 },
                    { 44, 44, 18 },
                    { 43, 43, 13 },
                    { 42, 42, 0 },
                    { 41, 41, 7 },
                    { 40, 40, 10 },
                    { 39, 39, 9 },
                    { 99, 99, 7 },
                    { 38, 38, 6 },
                    { 36, 36, 9 },
                    { 35, 35, 17 },
                    { 34, 34, 18 },
                    { 33, 33, 15 },
                    { 32, 32, 4 },
                    { 31, 31, 5 },
                    { 30, 30, 17 },
                    { 29, 29, 2 },
                    { 28, 28, 17 },
                    { 27, 27, 5 },
                    { 37, 37, 2 },
                    { 100, 100, 13 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductId",
                schema: "Catalog",
                table: "Products",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_ProductId",
                schema: "Catalog",
                table: "Stocks",
                column: "ProductId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stocks",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "Products",
                schema: "Catalog");
        }
    }
}
