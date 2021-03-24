using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QuizApp.Migrations
{
    public partial class _131231 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "season");

            migrationBuilder.DropColumn(
                name: "SeasonGuid",
                table: "match");

            migrationBuilder.AddColumn<string>(
                name: "Season",
                table: "match",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Season",
                table: "match");

            migrationBuilder.AddColumn<Guid>(
                name: "SeasonGuid",
                table: "match",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "season",
                columns: table => new
                {
                    SeasonGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Seasonname = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_season", x => x.SeasonGuid);
                });
        }
    }
}
