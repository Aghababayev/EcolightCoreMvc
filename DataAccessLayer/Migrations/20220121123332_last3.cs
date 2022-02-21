using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class last3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Distributors_DistributorDistribitorID",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_DistributorDistribitorID",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "DistributorDistribitorID",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "DistribitorID",
                table: "Orders",
                newName: "DistributorID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_DistributorID",
                table: "Orders",
                column: "DistributorID");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Distributors_DistributorID",
                table: "Orders",
                column: "DistributorID",
                principalTable: "Distributors",
                principalColumn: "DistribitorID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Distributors_DistributorID",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_DistributorID",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "DistributorID",
                table: "Orders",
                newName: "DistribitorID");

            migrationBuilder.AddColumn<int>(
                name: "DistributorDistribitorID",
                table: "Orders",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_DistributorDistribitorID",
                table: "Orders",
                column: "DistributorDistribitorID");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Distributors_DistributorDistribitorID",
                table: "Orders",
                column: "DistributorDistribitorID",
                principalTable: "Distributors",
                principalColumn: "DistribitorID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
