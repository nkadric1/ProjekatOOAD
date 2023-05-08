using Microsoft.EntityFrameworkCore.Migrations;

namespace Spotifive.Data.Migrations
{
    public partial class migv20 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EditorArtists");

            migrationBuilder.DropTable(
                name: "EditorSongs");

            migrationBuilder.AddColumn<int>(
                name: "ArtistID",
                table: "Editor",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SongID",
                table: "Editor",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Editor_ArtistID",
                table: "Editor",
                column: "ArtistID");

            migrationBuilder.CreateIndex(
                name: "IX_Editor_SongID",
                table: "Editor",
                column: "SongID");

            migrationBuilder.AddForeignKey(
                name: "FK_Editor_Artist_ArtistID",
                table: "Editor",
                column: "ArtistID",
                principalTable: "Artist",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Editor_Song_SongID",
                table: "Editor",
                column: "SongID",
                principalTable: "Song",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Editor_Artist_ArtistID",
                table: "Editor");

            migrationBuilder.DropForeignKey(
                name: "FK_Editor_Song_SongID",
                table: "Editor");

            migrationBuilder.DropIndex(
                name: "IX_Editor_ArtistID",
                table: "Editor");

            migrationBuilder.DropIndex(
                name: "IX_Editor_SongID",
                table: "Editor");

            migrationBuilder.DropColumn(
                name: "ArtistID",
                table: "Editor");

            migrationBuilder.DropColumn(
                name: "SongID",
                table: "Editor");

            migrationBuilder.CreateTable(
                name: "EditorArtists",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArtistID = table.Column<int>(type: "int", nullable: false),
                    EditorID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EditorArtists", x => x.ID);
                    table.ForeignKey(
                        name: "FK_EditorArtists_Artist_ArtistID",
                        column: x => x.ArtistID,
                        principalTable: "Artist",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EditorArtists_Editor_EditorID",
                        column: x => x.EditorID,
                        principalTable: "Editor",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EditorSongs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EditorID = table.Column<int>(type: "int", nullable: false),
                    SongID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EditorSongs", x => x.ID);
                    table.ForeignKey(
                        name: "FK_EditorSongs_Editor_EditorID",
                        column: x => x.EditorID,
                        principalTable: "Editor",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EditorSongs_Song_SongID",
                        column: x => x.SongID,
                        principalTable: "Song",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EditorArtists_ArtistID",
                table: "EditorArtists",
                column: "ArtistID");

            migrationBuilder.CreateIndex(
                name: "IX_EditorArtists_EditorID",
                table: "EditorArtists",
                column: "EditorID");

            migrationBuilder.CreateIndex(
                name: "IX_EditorSongs_EditorID",
                table: "EditorSongs",
                column: "EditorID");

            migrationBuilder.CreateIndex(
                name: "IX_EditorSongs_SongID",
                table: "EditorSongs",
                column: "SongID");
        }
    }
}
