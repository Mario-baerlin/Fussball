using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QuizApp.Migrations
{
    public partial class _12312 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_match_Person_SelectedPersonId",
                table: "match");

            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.DropIndex(
                name: "IX_match_SelectedPersonId",
                table: "match");

            migrationBuilder.DropColumn(
                name: "SelectedPersonId",
                table: "match");

            migrationBuilder.AddColumn<Guid>(
                name: "SelectedVerein2VereinGuid",
                table: "match",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "SelectedVereinVereinGuid",
                table: "match",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_match_SelectedVerein2VereinGuid",
                table: "match",
                column: "SelectedVerein2VereinGuid");

            migrationBuilder.CreateIndex(
                name: "IX_match_SelectedVereinVereinGuid",
                table: "match",
                column: "SelectedVereinVereinGuid");

            migrationBuilder.AddForeignKey(
                name: "FK_match_verein_SelectedVerein2VereinGuid",
                table: "match",
                column: "SelectedVerein2VereinGuid",
                principalTable: "verein",
                principalColumn: "VereinGuid",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_match_verein_SelectedVereinVereinGuid",
                table: "match",
                column: "SelectedVereinVereinGuid",
                principalTable: "verein",
                principalColumn: "VereinGuid",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_match_verein_SelectedVerein2VereinGuid",
                table: "match");

            migrationBuilder.DropForeignKey(
                name: "FK_match_verein_SelectedVereinVereinGuid",
                table: "match");

            migrationBuilder.DropIndex(
                name: "IX_match_SelectedVerein2VereinGuid",
                table: "match");

            migrationBuilder.DropIndex(
                name: "IX_match_SelectedVereinVereinGuid",
                table: "match");

            migrationBuilder.DropColumn(
                name: "SelectedVerein2VereinGuid",
                table: "match");

            migrationBuilder.DropColumn(
                name: "SelectedVereinVereinGuid",
                table: "match");

            migrationBuilder.AddColumn<int>(
                name: "SelectedPersonId",
                table: "match",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Firstname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lastname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_match_SelectedPersonId",
                table: "match",
                column: "SelectedPersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_match_Person_SelectedPersonId",
                table: "match",
                column: "SelectedPersonId",
                principalTable: "Person",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
