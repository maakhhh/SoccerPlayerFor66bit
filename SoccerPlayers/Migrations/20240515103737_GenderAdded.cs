using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SoccerPlayers.Migrations
{
    /// <inheritdoc />
    public partial class GenderAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Gender",
                table: "SoccerPlayer",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Gender",
                table: "SoccerPlayer");
        }
    }
}
