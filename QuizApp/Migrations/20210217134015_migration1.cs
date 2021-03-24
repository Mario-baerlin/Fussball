using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QuizApp.Migrations
{
    public partial class migration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "jobModel",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nchar(50)",
                oldFixedLength: true,
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "liga",
                columns: table => new
                {
                    LigaGuid = table.Column<Guid>(nullable: false),
                    LigaName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_liga", x => x.LigaGuid);
                });

            migrationBuilder.CreateTable(
                name: "match",
                columns: table => new
                {
                    MatchGuid = table.Column<Guid>(nullable: false),
                    Mannschaft1 = table.Column<string>(nullable: true),
                    Mannschaf2 = table.Column<string>(nullable: true),
                    Tore_Mannschaft1 = table.Column<int>(nullable: false),
                    Tore_Mannschaft2 = table.Column<int>(nullable: false),
                    Uhrzeit = table.Column<DateTime>(nullable: false),
                    SpieltagGuid = table.Column<Guid>(nullable: false),
                    LigaId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_match", x => x.MatchGuid);
                });

            migrationBuilder.CreateTable(
                name: "spieltag",
                columns: table => new
                {
                    SpieltagGuid = table.Column<Guid>(nullable: false),
                    Datum = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_spieltag", x => x.SpieltagGuid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "liga");

            migrationBuilder.DropTable(
                name: "match");

            migrationBuilder.DropTable(
                name: "spieltag");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "jobModel",
                type: "nchar(50)",
                fixedLength: true,
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);
        }
    }
}
