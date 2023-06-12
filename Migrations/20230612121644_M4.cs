using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Numismatics.Migrations
{
    /// <inheritdoc />
    public partial class M4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Logs_Coins_CoinID",
                table: "Logs");

            migrationBuilder.RenameColumn(
                name: "CoinID",
                table: "Logs",
                newName: "CoinUpdID");

            migrationBuilder.RenameIndex(
                name: "IX_Logs_CoinID",
                table: "Logs",
                newName: "IX_Logs_CoinUpdID");

            migrationBuilder.AddForeignKey(
                name: "FK_Logs_Coins_CoinUpdID",
                table: "Logs",
                column: "CoinUpdID",
                principalTable: "Coins",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Logs_Coins_CoinUpdID",
                table: "Logs");

            migrationBuilder.RenameColumn(
                name: "CoinUpdID",
                table: "Logs",
                newName: "CoinID");

            migrationBuilder.RenameIndex(
                name: "IX_Logs_CoinUpdID",
                table: "Logs",
                newName: "IX_Logs_CoinID");

            migrationBuilder.AddForeignKey(
                name: "FK_Logs_Coins_CoinID",
                table: "Logs",
                column: "CoinID",
                principalTable: "Coins",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
