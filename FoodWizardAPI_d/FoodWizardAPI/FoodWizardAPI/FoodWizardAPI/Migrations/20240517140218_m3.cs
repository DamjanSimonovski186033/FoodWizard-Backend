using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodWizardAPI.Migrations
{
    /// <inheritdoc />
    public partial class m3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsFavorite",
                table: "Recepies");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Recepies",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Recepies_UserId",
                table: "Recepies",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Recepies_AspNetUsers_UserId",
                table: "Recepies",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recepies_AspNetUsers_UserId",
                table: "Recepies");

            migrationBuilder.DropIndex(
                name: "IX_Recepies_UserId",
                table: "Recepies");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Recepies");

            migrationBuilder.AddColumn<bool>(
                name: "IsFavorite",
                table: "Recepies",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
