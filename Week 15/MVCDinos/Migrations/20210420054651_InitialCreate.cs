using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCDinos.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    ClassID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClassName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClassEasyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClassDesc = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.ClassID);
                });

            migrationBuilder.CreateTable(
                name: "Dinosaurs",
                columns: table => new
                {
                    DinosaurID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DinosaurName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pronounced = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BriefDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameMeans = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LengthFt = table.Column<int>(type: "int", nullable: false),
                    WeightLbs = table.Column<int>(type: "int", nullable: false),
                    LivedYearsAgo = table.Column<int>(type: "int", nullable: false),
                    ClassID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PeriodID = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dinosaurs", x => x.DinosaurID);
                });

            migrationBuilder.CreateTable(
                name: "Periods",
                columns: table => new
                {
                    PeriodID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PeriodName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Periods", x => x.PeriodID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.DropTable(
                name: "Dinosaurs");

            migrationBuilder.DropTable(
                name: "Periods");
        }
    }
}
