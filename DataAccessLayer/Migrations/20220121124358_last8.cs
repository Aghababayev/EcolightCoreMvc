using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class last8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Distributors_Distributors_DistributorDistribitorID",
                table: "Distributors");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Products_ProductID1",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_ProductID1",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Distributors_DistributorDistribitorID",
                table: "Distributors");

            migrationBuilder.DropColumn(
                name: "ProductID1",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "DistributorDistribitorID",
                table: "Distributors");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductID1",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DistributorDistribitorID",
                table: "Distributors",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductID1",
                table: "Products",
                column: "ProductID1");

            migrationBuilder.CreateIndex(
                name: "IX_Distributors_DistributorDistribitorID",
                table: "Distributors",
                column: "DistributorDistribitorID");

            migrationBuilder.AddForeignKey(
                name: "FK_Distributors_Distributors_DistributorDistribitorID",
                table: "Distributors",
                column: "DistributorDistribitorID",
                principalTable: "Distributors",
                principalColumn: "DistribitorID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Products_ProductID1",
                table: "Products",
                column: "ProductID1",
                principalTable: "Products",
                principalColumn: "ProductID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
