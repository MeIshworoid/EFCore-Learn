using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EFCoreLearn.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSeeDataToMovieTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 12L);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 1L,
                columns: new[] { "ActionDate", "ActionTaken", "ActionType" },
                values: new object[] { new DateTime(2025, 1, 1, 19, 29, 4, 357, DateTimeKind.Local).AddTicks(5458), 1, "Create" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieId", "ActionDate", "ActionTaken", "ActionType", "Genre", "MovieName", "Price" },
                values: new object[,]
                {
                    { 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, "Adventure, Action, Fantasy", "Bahubali The Conclusion", 800.99m },
                    { 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, "Comedy, Drama", "3 Idiots", 3899.777m },
                    { 4L, new DateTime(2025, 1, 1, 19, 29, 4, 357, DateTimeKind.Local).AddTicks(5501), 2, "Create", "Comedy, Action", "Dhammal", 1145.996m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 4L);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 1L,
                columns: new[] { "ActionDate", "ActionTaken", "ActionType" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieId", "ActionDate", "ActionTaken", "ActionType", "Genre", "MovieName", "Price" },
                values: new object[,]
                {
                    { 10L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, "Adventure, Action, Fantasy", "Bahubali The Conclusion", 800.99m },
                    { 11L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, "Comedy, Drama", "3 Idiots", 3899.777m },
                    { 12L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, "Comedy, Action", "Dhammal", 1145.996m }
                });
        }
    }
}
