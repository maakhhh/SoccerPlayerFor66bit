using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SoccerPlayers.Migrations
{
    /// <inheritdoc />
    public partial class CoutryAdd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Country",
                table: "SoccerPlayer",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Country",
                table: "SoccerPlayer");
        }
    }
}
