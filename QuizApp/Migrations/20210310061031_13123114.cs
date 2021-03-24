using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QuizApp.Migrations
{
    public partial class _13123114 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "torjäger",
                columns: table => new
                {
                    TorjägerGuid = table.Column<Guid>(nullable: false),
                    MatchGuid = table.Column<Guid>(nullable: false),
                    SpieltagGuid = table.Column<Guid>(nullable: false),
                    LigaId = table.Column<Guid>(nullable: false),
                    Spielername = table.Column<string>(nullable: true),
                    Tore = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_torjäger", x => x.TorjägerGuid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "torjäger");
        }
    }
}
