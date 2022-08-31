using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace shopdotnet.Migrations
{
    public partial class Addindicecitystate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "States",
                columns: table => new
                {
                    State_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    State_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Country_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_States", x => x.State_ID);
                    table.UniqueConstraint("CountryId", x => x.State_Name);
                    table.ForeignKey(
                        name: "FK_States_Countries_Country_ID",
                        column: x => x.Country_ID,
                        principalTable: "Countries",
                        principalColumn: "Country_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    City_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    City_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    State_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.City_ID);
                    table.UniqueConstraint("StateId", x => x.City_Name);
                    table.ForeignKey(
                        name: "FK_Cities_States_State_ID",
                        column: x => x.State_ID,
                        principalTable: "States",
                        principalColumn: "State_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cities_State_ID",
                table: "Cities",
                column: "State_ID");

            migrationBuilder.CreateIndex(
                name: "IX_States_Country_ID",
                table: "States",
                column: "Country_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "States");
        }
    }
}
