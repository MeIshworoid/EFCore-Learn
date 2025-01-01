using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreLearn.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class ChangeDisplayColumnNameToDisplayOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Display",
                table: "Genres",
                newName: "DisplayOrder");

            //migrationBuilder.Sql("Update genres set display=displayorder"); for before.net 5 version because of data deletion
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DisplayOrder",
                table: "Genres",
                newName: "Display");
        }
    }
}
