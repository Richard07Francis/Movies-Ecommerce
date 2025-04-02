using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eMovies.Migrations
{
    /// <inheritdoc />
    public partial class UpdatingIDs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProducerID",
                table: "Producers",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "MovieId",
                table: "Movies",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "CinemaID",
                table: "Cinemas",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ActorID",
                table: "Actors",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Actors",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Producers",
                newName: "ProducerID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Movies",
                newName: "MovieId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Cinemas",
                newName: "CinemaID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Actors",
                newName: "ActorID");

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Actors",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);
        }
    }
}
