using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Data.Postgres.Migrations
{
    /// <inheritdoc />
    public partial class editconfiguration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReceiverName",
                table: "AccountHistories");

            migrationBuilder.AddColumn<int>(
                name: "ReceiverId",
                table: "AccountHistories",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_AccountHistories_ReceiverId",
                table: "AccountHistories",
                column: "ReceiverId");

            migrationBuilder.AddForeignKey(
                name: "FK_AccountHistories_User_ReceiverId",
                table: "AccountHistories",
                column: "ReceiverId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AccountHistories_User_ReceiverId",
                table: "AccountHistories");

            migrationBuilder.DropIndex(
                name: "IX_AccountHistories_ReceiverId",
                table: "AccountHistories");

            migrationBuilder.DropColumn(
                name: "ReceiverId",
                table: "AccountHistories");

            migrationBuilder.AddColumn<string>(
                name: "ReceiverName",
                table: "AccountHistories",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
