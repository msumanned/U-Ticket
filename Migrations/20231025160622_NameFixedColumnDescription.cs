using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace U_Ticket.Migrations
{
    /// <inheritdoc />
    public partial class NameFixedColumnDescription : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SeatCapacity",
                table: "Cinemas",
                newName: "Description");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Cinemas",
                newName: "SeatCapacity");
        }
    }
}
