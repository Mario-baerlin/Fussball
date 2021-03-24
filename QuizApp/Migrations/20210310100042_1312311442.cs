using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QuizApp.Migrations
{
    public partial class _1312311442 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SpieltagGuid",
                table: "torjäger");

            migrationBuilder.AddColumn<string>(
                name: "Saison",
                table: "torjäger",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Saison",
                table: "torjäger");

            migrationBuilder.AddColumn<Guid>(
                name: "SpieltagGuid",
                table: "torjäger",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }
    }
}
