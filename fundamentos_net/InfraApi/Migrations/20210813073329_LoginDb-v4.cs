using Microsoft.EntityFrameworkCore.Migrations;

namespace InfraApi.Migrations
{
    public partial class LoginDbv4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Words_Users_UserId",
                table: "Words");

            migrationBuilder.DropIndex(
                name: "IX_Words_UserId",
                table: "Words");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Words");

            migrationBuilder.CreateIndex(
                name: "IX_Words_IdUser",
                table: "Words",
                column: "IdUser");

            migrationBuilder.AddForeignKey(
                name: "FK_Words_Users_IdUser",
                table: "Words",
                column: "IdUser",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Words_Users_IdUser",
                table: "Words");

            migrationBuilder.DropIndex(
                name: "IX_Words_IdUser",
                table: "Words");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Words",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Words_UserId",
                table: "Words",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Words_Users_UserId",
                table: "Words",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
