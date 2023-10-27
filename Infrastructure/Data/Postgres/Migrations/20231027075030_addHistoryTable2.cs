using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Data.Postgres.Migrations
{
    /// <inheritdoc />
    public partial class addHistoryTable2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AccountHistories_User_UserId",
                table: "AccountHistories");

            migrationBuilder.DropIndex(
                name: "IX_AccountHistories_UserId",
                table: "AccountHistories");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "AccountHistories");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "AccountHistories",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AccountHistories_UserId",
                table: "AccountHistories",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AccountHistories_User_UserId",
                table: "AccountHistories",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id");
        }
    }
}
