using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Linky.API.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Indicator",
                columns: table => new
                {
                    IdIndicator = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumIndicator = table.Column<int>(type: "int", nullable: false),
                    SwitchOnIndicator = table.Column<bool>(type: "bit", nullable: false),
                    ConsumIndicator = table.Column<double>(type: "float", nullable: false),
                    PowerIndicator = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Indicator", x => x.IdIndicator);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Indicator");
        }
    }
}
