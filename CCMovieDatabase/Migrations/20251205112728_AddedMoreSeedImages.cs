using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CCMovieDatabase.Migrations
{
    /// <inheritdoc />
    public partial class AddedMoreSeedImages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 3,
                column: "ThumbnailURL",
                value: "https://external-content.duckduckgo.com/iu/?u=http%3A%2F%2Fwww.impawards.com%2F1993%2Fposters%2Farmy_of_darkness_ver3.jpg&f=1&nofb=1&ipt=0f5ba9f7dec46adcdb32748f094b542e4b5c8eff313c6811ef1bea9fde96af7d");

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 4,
                column: "ThumbnailURL",
                value: "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fpostertok.com%2Fwp-content%2Fuploads%2F2024%2F02%2F5337.webp&f=1&nofb=1&ipt=0e1573f1b1d07b5daa12a781e53f49b27c130790c4d2dcde54916cc0eff9f901");

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 5,
                column: "ThumbnailURL",
                value: "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fc8.alamy.com%2Fcomp%2FBKG4ED%2Fthe-cable-guy-1996-poster-BKG4ED.jpg&f=1&nofb=1&ipt=04d76ad2b1e8ab66bd02da1ce264a9d679f0f2cad012d7c99c0ac192572af20b");

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 6,
                column: "ThumbnailURL",
                value: "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Famc-theatres-res.cloudinary.com%2Fv1579117618%2Famc-cdn%2Fproduction%2F2%2Fmovies%2F3500%2F3499%2FPoster%2Fp_800x1200_Spider-Man_En_0802517.jpg&f=1&nofb=1&ipt=a5788d911cca9535bbb702afd5665df889150246b214e4f0394fc6f0a1e6f798");

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 7,
                column: "ThumbnailURL",
                value: "https://external-content.duckduckgo.com/iu/?u=http%3A%2F%2Fwww.impawards.com%2F1993%2Fposters%2Fnightmare_before_christmas_ver1.jpg&f=1&nofb=1&ipt=a3fc758eba9bddd233e7d4e35b4511f5d2f2482e2d85d1589232c9d6a4c4efe6");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 3,
                column: "ThumbnailURL",
                value: null);

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 4,
                column: "ThumbnailURL",
                value: null);

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 5,
                column: "ThumbnailURL",
                value: null);

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 6,
                column: "ThumbnailURL",
                value: null);

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 7,
                column: "ThumbnailURL",
                value: null);
        }
    }
}
