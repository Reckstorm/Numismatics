using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Numismatics.Migrations
{
    /// <inheritdoc />
    public partial class M3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Logs_CoinID",
                table: "Logs",
                column: "CoinID");

            migrationBuilder.CreateIndex(
                name: "IX_Logs_UserFromID",
                table: "Logs",
                column: "UserFromID");

            migrationBuilder.CreateIndex(
                name: "IX_Logs_UserToID",
                table: "Logs",
                column: "UserToID");

            migrationBuilder.AddForeignKey(
                name: "FK_Logs_Coins_CoinID",
                table: "Logs",
                column: "CoinID",
                principalTable: "Coins",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Logs_Users_UserFromID",
                table: "Logs",
                column: "UserFromID",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Logs_Users_UserToID",
                table: "Logs",
                column: "UserToID",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Logs_Coins_CoinID",
                table: "Logs");

            migrationBuilder.DropForeignKey(
                name: "FK_Logs_Users_UserFromID",
                table: "Logs");

            migrationBuilder.DropForeignKey(
                name: "FK_Logs_Users_UserToID",
                table: "Logs");

            migrationBuilder.DropIndex(
                name: "IX_Logs_CoinID",
                table: "Logs");

            migrationBuilder.DropIndex(
                name: "IX_Logs_UserFromID",
                table: "Logs");

            migrationBuilder.DropIndex(
                name: "IX_Logs_UserToID",
                table: "Logs");
        }
    }
}
