using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CCMovieDatabase.Migrations
{
    /// <inheritdoc />
    public partial class AddedPGRating : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ThumbnailURL",
                table: "Movie",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 1,
                column: "ThumbnailURL",
                value: "https://encrypted-tbn1.gstatic.com/images?q=tbn:ANd9GcTG_q0A0cypAsXxYlgs5J_554BrcnjeeKExlQE3ZaZUuPYv0fUd");

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 2,
                column: "ThumbnailURL",
                value: "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcTPx7lW6h0G1O9-npEnVPL07fT74Tp6SFl0i47nxfypyVBcQFdS");

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 3,
                column: "ThumbnailURL",
                value: "https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcQcZT3sdwr1NiJytvJb95icJJKPWpWRNv35l_uuVYxjlzBJS-hb");

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 4,
                column: "ThumbnailURL",
                value: "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcRw1ynxwA6p8jGMs5TD1Q6BFgn9fafEk-XQ3lrYQGQo0q4Ggo3a");

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 5,
                column: "ThumbnailURL",
                value: "https://encrypted-tbn1.gstatic.com/images?q=tbn:ANd9GcSUZk92ju8kisZKCc9m4lyySg9S5RSM6mhFnSWOpOb1_MlCsHsw");

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 6,
                column: "ThumbnailURL",
                value: "https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcT08ZFpbAwAL_jQFtQfMjut1_T6oNgxRCQiOPA6S1twJLXZq_Wi");

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 7,
                column: "ThumbnailURL",
                value: "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR84Bm2XnTfW7hukdkEdr5jezVGfoIt22h0-s7Dfk1aRavoPZmh");

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "RatingId", "Name" },
                values: new object[] { 4, "PG" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "RatingId",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "ThumbnailURL",
                table: "Movie");
        }
    }
}
