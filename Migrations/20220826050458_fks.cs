using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace shopdotnet.Migrations
{
    public partial class fks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_States_Countries_Country_ID",
                table: "States");

            migrationBuilder.RenameColumn(
                name: "Country_ID",
                table: "States",
                newName: "CountryRefId");

            migrationBuilder.RenameIndex(
                name: "IX_States_Country_ID",
                table: "States",
                newName: "IX_States_CountryRefId");

            migrationBuilder.AddForeignKey(
                name: "FK_States_Countries_CountryRefId",
                table: "States",
                column: "CountryRefId",
                principalTable: "Countries",
                principalColumn: "Country_ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_States_Countries_CountryRefId",
                table: "States");

            migrationBuilder.RenameColumn(
                name: "CountryRefId",
                table: "States",
                newName: "Country_ID");

            migrationBuilder.RenameIndex(
                name: "IX_States_CountryRefId",
                table: "States",
                newName: "IX_States_Country_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_States_Countries_Country_ID",
                table: "States",
                column: "Country_ID",
                principalTable: "Countries",
                principalColumn: "Country_ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
