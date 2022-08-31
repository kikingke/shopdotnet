using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace shopdotnet.Migrations
{
    public partial class fixindexcompuestosu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cities_States_State_ID",
                table: "Cities");

            migrationBuilder.DropForeignKey(
                name: "FK_States_Countries_Country_ID",
                table: "States");

            migrationBuilder.DropUniqueConstraint(
                name: "CountryId",
                table: "States");

            migrationBuilder.DropUniqueConstraint(
                name: "StateId",
                table: "Cities");

            migrationBuilder.RenameColumn(
                name: "Country_ID",
                table: "States",
                newName: "CountryId");

            migrationBuilder.RenameIndex(
                name: "IX_States_Country_ID",
                table: "States",
                newName: "IX_States_CountryId");

            migrationBuilder.RenameColumn(
                name: "State_ID",
                table: "Cities",
                newName: "StateId");

            migrationBuilder.RenameIndex(
                name: "IX_Cities_State_ID",
                table: "Cities",
                newName: "IX_Cities_StateId");

            migrationBuilder.CreateIndex(
                name: "IX_States_State_Name_CountryId",
                table: "States",
                columns: new[] { "State_Name", "CountryId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cities_City_Name_StateId",
                table: "Cities",
                columns: new[] { "City_Name", "StateId" },
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_States_StateId",
                table: "Cities",
                column: "StateId",
                principalTable: "States",
                principalColumn: "State_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_States_Countries_CountryId",
                table: "States",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Country_ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cities_States_StateId",
                table: "Cities");

            migrationBuilder.DropForeignKey(
                name: "FK_States_Countries_CountryId",
                table: "States");

            migrationBuilder.DropIndex(
                name: "IX_States_State_Name_CountryId",
                table: "States");

            migrationBuilder.DropIndex(
                name: "IX_Cities_City_Name_StateId",
                table: "Cities");

            migrationBuilder.RenameColumn(
                name: "CountryId",
                table: "States",
                newName: "Country_ID");

            migrationBuilder.RenameIndex(
                name: "IX_States_CountryId",
                table: "States",
                newName: "IX_States_Country_ID");

            migrationBuilder.RenameColumn(
                name: "StateId",
                table: "Cities",
                newName: "State_ID");

            migrationBuilder.RenameIndex(
                name: "IX_Cities_StateId",
                table: "Cities",
                newName: "IX_Cities_State_ID");

            migrationBuilder.AddUniqueConstraint(
                name: "CountryId",
                table: "States",
                column: "State_Name");

            migrationBuilder.AddUniqueConstraint(
                name: "StateId",
                table: "Cities",
                column: "City_Name");

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_States_State_ID",
                table: "Cities",
                column: "State_ID",
                principalTable: "States",
                principalColumn: "State_ID",
                onDelete: ReferentialAction.Cascade);

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
