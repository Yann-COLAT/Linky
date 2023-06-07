using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Linky.API.Migrations
{
    /// <inheritdoc />
    public partial class ChangeIndicatorEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "DayConsumIndicator",
                table: "Indicator",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "HourConsumIndicator",
                table: "Indicator",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "MonthConsumIndicator",
                table: "Indicator",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DayConsumIndicator",
                table: "Indicator");

            migrationBuilder.DropColumn(
                name: "HourConsumIndicator",
                table: "Indicator");

            migrationBuilder.DropColumn(
                name: "MonthConsumIndicator",
                table: "Indicator");
        }
    }
}
