using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace shopdotnet.Migrations
{
    public partial class modState : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_States_Countries_Country_ID",
                table: "States");

            migrationBuilder.AlterColumn<int>(
                name: "Country_ID",
                table: "States",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "idCountry",
                table: "States",
                type: "int",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_States_Countries_Country_ID",
                table: "States",
                column: "Country_ID",
                principalTable: "Countries",
                principalColumn: "Country_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_States_Countries_Country_ID",
                table: "States");

            migrationBuilder.DropColumn(
                name: "idCountry",
                table: "States");

            migrationBuilder.AlterColumn<int>(
                name: "Country_ID",
                table: "States",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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
