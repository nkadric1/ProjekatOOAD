using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Spotifive.Data.Migrations
{
    public partial class migracijapodataka : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateRelease",
                table: "Song",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "ArtistID",
                table: "RegisteredUser",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "Person",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "ArtistID",
                table: "Critic",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "PlaylistSongs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlaylistID = table.Column<int>(type: "int", nullable: false),
                    SongID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlaylistSongs", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PlaylistSongs_Playlist_PlaylistID",
                        column: x => x.PlaylistID,
                        principalTable: "Playlist",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlaylistSongs_Song_SongID",
                        column: x => x.SongID,
                        principalTable: "Song",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RegisteredUser_ArtistID",
                table: "RegisteredUser",
                column: "ArtistID");

            migrationBuilder.CreateIndex(
                name: "IX_Critic_ArtistID",
                table: "Critic",
                column: "ArtistID");

            migrationBuilder.CreateIndex(
                name: "IX_PlaylistSongs_PlaylistID",
                table: "PlaylistSongs",
                column: "PlaylistID");

            migrationBuilder.CreateIndex(
                name: "IX_PlaylistSongs_SongID",
                table: "PlaylistSongs",
                column: "SongID");

            migrationBuilder.AddForeignKey(
                name: "FK_Critic_Artist_ArtistID",
                table: "Critic",
                column: "ArtistID",
                principalTable: "Artist",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RegisteredUser_Artist_ArtistID",
                table: "RegisteredUser",
                column: "ArtistID",
                principalTable: "Artist",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Critic_Artist_ArtistID",
                table: "Critic");

            migrationBuilder.DropForeignKey(
                name: "FK_RegisteredUser_Artist_ArtistID",
                table: "RegisteredUser");

            migrationBuilder.DropTable(
                name: "PlaylistSongs");

            migrationBuilder.DropIndex(
                name: "IX_RegisteredUser_ArtistID",
                table: "RegisteredUser");

            migrationBuilder.DropIndex(
                name: "IX_Critic_ArtistID",
                table: "Critic");

            migrationBuilder.DropColumn(
                name: "ArtistID",
                table: "RegisteredUser");

            migrationBuilder.DropColumn(
                name: "ArtistID",
                table: "Critic");

            migrationBuilder.AlterColumn<int>(
                name: "DateRelease",
                table: "Song",
                type: "int",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "DateOfBirth",
                table: "Person",
                type: "int",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }
    }
}
