using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SoccerPlayers.Migrations
{
    /// <inheritdoc />
    public partial class CommandNameAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Birthday",
                table: "SoccerPlayer",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AddColumn<string>(
                name: "CommandName",
                table: "SoccerPlayer",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CommandName",
                table: "SoccerPlayer");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Birthday",
                table: "SoccerPlayer",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");
        }
    }
}
