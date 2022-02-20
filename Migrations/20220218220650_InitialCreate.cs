using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RazorPagesHistoricalFiguresAC.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HistoricalFiguresAC",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DateOfDeath = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Profession = table.Column<string>(type: "TEXT", nullable: true),
                    SeenIn = table.Column<string>(type: "TEXT", nullable: true),
                    Affiliation = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoricalFiguresAC", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HistoricalFiguresAC");
        }
    }
}
