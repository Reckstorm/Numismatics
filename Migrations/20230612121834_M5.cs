using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Numismatics.Migrations
{
    /// <inheritdoc />
    public partial class M5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Logs_Coins_CoinUpdID",
                table: "Logs");

            migrationBuilder.DropForeignKey(
                name: "FK_Logs_Users_UserFromID",
                table: "Logs");

            migrationBuilder.DropForeignKey(
                name: "FK_Logs_Users_UserToID",
                table: "Logs");

            migrationBuilder.DropIndex(
                name: "IX_Logs_CoinUpdID",
                table: "Logs");

            migrationBuilder.DropIndex(
                name: "IX_Logs_UserFromID",
                table: "Logs");

            migrationBuilder.DropIndex(
                name: "IX_Logs_UserToID",
                table: "Logs");

            migrationBuilder.RenameColumn(
                name: "CoinUpdID",
                table: "Logs",
                newName: "CoinID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CoinID",
                table: "Logs",
                newName: "CoinUpdID");

            migrationBuilder.CreateIndex(
                name: "IX_Logs_CoinUpdID",
                table: "Logs",
                column: "CoinUpdID");

            migrationBuilder.CreateIndex(
                name: "IX_Logs_UserFromID",
                table: "Logs",
                column: "UserFromID");

            migrationBuilder.CreateIndex(
                name: "IX_Logs_UserToID",
                table: "Logs",
                column: "UserToID");

            migrationBuilder.AddForeignKey(
                name: "FK_Logs_Coins_CoinUpdID",
                table: "Logs",
                column: "CoinUpdID",
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
    }
}
