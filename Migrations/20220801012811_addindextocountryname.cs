using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace shopdotnet.Migrations
{
    public partial class addindextocountryname : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Countries_Country_Name",
                table: "Countries",
                column: "Country_Name",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Countries_Country_Name",
                table: "Countries");
        }
    }
}
