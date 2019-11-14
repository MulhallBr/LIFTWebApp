using Microsoft.EntityFrameworkCore.Migrations;

namespace LIFTWebApp.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Lifts",
                columns: table => new
                {
                    LiftID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(nullable: false),
                    DateTimePerformed = table.Column<string>(nullable: true),
                    ExercisePerfromed = table.Column<string>(nullable: true),
                    Weight = table.Column<int>(nullable: false),
                    Reps = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lifts", x => x.LiftID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Lifts");
        }
    }
}
