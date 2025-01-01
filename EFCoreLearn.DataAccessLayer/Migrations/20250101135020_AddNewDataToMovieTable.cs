using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreLearn.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class AddNewDataToMovieTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 1L,
                column: "ActionDate",
                value: new DateTime(2025, 1, 1, 19, 35, 19, 700, DateTimeKind.Local).AddTicks(3536));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 4L,
                columns: new[] { "ActionDate", "MovieName" },
                values: new object[] { new DateTime(2025, 1, 1, 19, 35, 19, 700, DateTimeKind.Local).AddTicks(3587), "Kamal" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieId", "ActionDate", "ActionTaken", "ActionType", "Genre", "MovieName", "Price" },
                values: new object[] { 5L, new DateTime(2025, 1, 1, 19, 35, 19, 700, DateTimeKind.Local).AddTicks(3585), 2, "Create", "Comedy, Action", "Dhammal", 1145.996m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 5L);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 1L,
                column: "ActionDate",
                value: new DateTime(2025, 1, 1, 19, 29, 4, 357, DateTimeKind.Local).AddTicks(5458));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 4L,
                columns: new[] { "ActionDate", "MovieName" },
                values: new object[] { new DateTime(2025, 1, 1, 19, 29, 4, 357, DateTimeKind.Local).AddTicks(5501), "Dhammal" });
        }
    }
}
