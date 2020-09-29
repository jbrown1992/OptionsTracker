using Microsoft.EntityFrameworkCore.Migrations;

namespace Options.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Options",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Symbol = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Details = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    StockPriceAtSale = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    AveragePrice = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Comission = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Profit = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Options", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Options");
        }
    }
}
