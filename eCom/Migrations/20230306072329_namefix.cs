using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eCom.Migrations
{
    /// <inheritdoc />
    public partial class namefix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Descriotion",
                table: "Cinemas",
                newName: "Description");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Cinemas",
                newName: "Descriotion");
        }
    }
}
