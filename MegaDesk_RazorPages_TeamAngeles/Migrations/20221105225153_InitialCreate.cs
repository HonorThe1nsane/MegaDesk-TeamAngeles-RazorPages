using Microsoft.EntityFrameworkCore.Migrations;

namespace MegaDesk_RazorPages_TeamAngeles.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Desk",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeskWidth = table.Column<float>(type: "real", nullable: false),
                    DeskDepth = table.Column<float>(type: "real", nullable: false),
                    NumDrawers = table.Column<int>(type: "int", nullable: false),
                    DeskMaterial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RushDays = table.Column<float>(type: "real", nullable: false),
                    DrawerCost = table.Column<float>(type: "real", nullable: false),
                    QuotePrice = table.Column<float>(type: "real", nullable: false),
                    RushCost = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Desk", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Desk");
        }
    }
}
