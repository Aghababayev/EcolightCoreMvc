using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class last6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DistributorDistribitorID",
                table: "Distributors",
                type: "int",
                nullable: true);

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Distributors_Distributors_DistributorDistribitorID",
                table: "Distributors");

            migrationBuilder.DropIndex(
                name: "IX_Distributors_DistributorDistribitorID",
                table: "Distributors");

            migrationBuilder.DropColumn(
                name: "DistributorDistribitorID",
                table: "Distributors");
        }
    }
}
