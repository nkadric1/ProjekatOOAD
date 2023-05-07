using Microsoft.EntityFrameworkCore.Migrations;

namespace Spotifive.Data.Migrations
{
    public partial class OsmaM : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Account_Administrator_AdminID",
                table: "Account");

            migrationBuilder.DropForeignKey(
                name: "FK_ArtistHasSong_Artist_ArtistID",
                table: "ArtistHasSong");

            migrationBuilder.DropForeignKey(
                name: "FK_ArtistHasSong_Song_SongID",
                table: "ArtistHasSong");

            migrationBuilder.DropForeignKey(
                name: "FK_EditingOfArtist_Artist_ArtistID",
                table: "EditingOfArtist");

            migrationBuilder.DropForeignKey(
                name: "FK_EditingOfArtist_Editor_EditorID",
                table: "EditingOfArtist");

            migrationBuilder.DropForeignKey(
                name: "FK_EditingOfSong_Editor_EditorID",
                table: "EditingOfSong");

            migrationBuilder.DropForeignKey(
                name: "FK_EditingOfSong_Song_SongID",
                table: "EditingOfSong");

            migrationBuilder.DropForeignKey(
                name: "FK_Favorites_Playlist_PlaylistID",
                table: "Favorites");

            migrationBuilder.DropForeignKey(
                name: "FK_Favorites_Song_SongID",
                table: "Favorites");

            migrationBuilder.DropForeignKey(
                name: "FK_RegisteredUser_Song_SongID",
                table: "RegisteredUser");

            migrationBuilder.DropForeignKey(
                name: "FK_Review_Critic_CriticID",
                table: "Review");

            migrationBuilder.DropForeignKey(
                name: "FK_Review_Song_SongID",
                table: "Review");

            migrationBuilder.DropIndex(
                name: "IX_Account_AdminID",
                table: "Account");

            migrationBuilder.AlterColumn<int>(
                name: "SongID",
                table: "Review",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CriticID",
                table: "Review",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "SongID",
                table: "RegisteredUser",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "SongID",
                table: "Favorites",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "PlaylistID",
                table: "Favorites",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "SongID",
                table: "EditingOfSong",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "EditorID",
                table: "EditingOfSong",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "EditorID",
                table: "EditingOfArtist",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ArtistID",
                table: "EditingOfArtist",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "SongID",
                table: "ArtistHasSong",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ArtistID",
                table: "ArtistHasSong",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "AdminID",
                table: "Account",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Account_AdminID",
                table: "Account",
                column: "AdminID",
                unique: true,
                filter: "[AdminID] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Account_Administrator_AdminID",
                table: "Account",
                column: "AdminID",
                principalTable: "Administrator",
                principalColumn: "PersonID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ArtistHasSong_Artist_ArtistID",
                table: "ArtistHasSong",
                column: "ArtistID",
                principalTable: "Artist",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ArtistHasSong_Song_SongID",
                table: "ArtistHasSong",
                column: "SongID",
                principalTable: "Song",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EditingOfArtist_Artist_ArtistID",
                table: "EditingOfArtist",
                column: "ArtistID",
                principalTable: "Artist",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EditingOfArtist_Editor_EditorID",
                table: "EditingOfArtist",
                column: "EditorID",
                principalTable: "Editor",
                principalColumn: "PersonID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EditingOfSong_Editor_EditorID",
                table: "EditingOfSong",
                column: "EditorID",
                principalTable: "Editor",
                principalColumn: "PersonID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EditingOfSong_Song_SongID",
                table: "EditingOfSong",
                column: "SongID",
                principalTable: "Song",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Favorites_Playlist_PlaylistID",
                table: "Favorites",
                column: "PlaylistID",
                principalTable: "Playlist",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Favorites_Song_SongID",
                table: "Favorites",
                column: "SongID",
                principalTable: "Song",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RegisteredUser_Song_SongID",
                table: "RegisteredUser",
                column: "SongID",
                principalTable: "Song",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Review_Critic_CriticID",
                table: "Review",
                column: "CriticID",
                principalTable: "Critic",
                principalColumn: "PersonID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Review_Song_SongID",
                table: "Review",
                column: "SongID",
                principalTable: "Song",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Account_Administrator_AdminID",
                table: "Account");

            migrationBuilder.DropForeignKey(
                name: "FK_ArtistHasSong_Artist_ArtistID",
                table: "ArtistHasSong");

            migrationBuilder.DropForeignKey(
                name: "FK_ArtistHasSong_Song_SongID",
                table: "ArtistHasSong");

            migrationBuilder.DropForeignKey(
                name: "FK_EditingOfArtist_Artist_ArtistID",
                table: "EditingOfArtist");

            migrationBuilder.DropForeignKey(
                name: "FK_EditingOfArtist_Editor_EditorID",
                table: "EditingOfArtist");

            migrationBuilder.DropForeignKey(
                name: "FK_EditingOfSong_Editor_EditorID",
                table: "EditingOfSong");

            migrationBuilder.DropForeignKey(
                name: "FK_EditingOfSong_Song_SongID",
                table: "EditingOfSong");

            migrationBuilder.DropForeignKey(
                name: "FK_Favorites_Playlist_PlaylistID",
                table: "Favorites");

            migrationBuilder.DropForeignKey(
                name: "FK_Favorites_Song_SongID",
                table: "Favorites");

            migrationBuilder.DropForeignKey(
                name: "FK_RegisteredUser_Song_SongID",
                table: "RegisteredUser");

            migrationBuilder.DropForeignKey(
                name: "FK_Review_Critic_CriticID",
                table: "Review");

            migrationBuilder.DropForeignKey(
                name: "FK_Review_Song_SongID",
                table: "Review");

            migrationBuilder.DropIndex(
                name: "IX_Account_AdminID",
                table: "Account");

            migrationBuilder.AlterColumn<int>(
                name: "SongID",
                table: "Review",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CriticID",
                table: "Review",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SongID",
                table: "RegisteredUser",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SongID",
                table: "Favorites",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PlaylistID",
                table: "Favorites",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SongID",
                table: "EditingOfSong",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EditorID",
                table: "EditingOfSong",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EditorID",
                table: "EditingOfArtist",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ArtistID",
                table: "EditingOfArtist",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SongID",
                table: "ArtistHasSong",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ArtistID",
                table: "ArtistHasSong",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AdminID",
                table: "Account",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Account_AdminID",
                table: "Account",
                column: "AdminID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Account_Administrator_AdminID",
                table: "Account",
                column: "AdminID",
                principalTable: "Administrator",
                principalColumn: "PersonID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ArtistHasSong_Artist_ArtistID",
                table: "ArtistHasSong",
                column: "ArtistID",
                principalTable: "Artist",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ArtistHasSong_Song_SongID",
                table: "ArtistHasSong",
                column: "SongID",
                principalTable: "Song",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EditingOfArtist_Artist_ArtistID",
                table: "EditingOfArtist",
                column: "ArtistID",
                principalTable: "Artist",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EditingOfArtist_Editor_EditorID",
                table: "EditingOfArtist",
                column: "EditorID",
                principalTable: "Editor",
                principalColumn: "PersonID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EditingOfSong_Editor_EditorID",
                table: "EditingOfSong",
                column: "EditorID",
                principalTable: "Editor",
                principalColumn: "PersonID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EditingOfSong_Song_SongID",
                table: "EditingOfSong",
                column: "SongID",
                principalTable: "Song",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Favorites_Playlist_PlaylistID",
                table: "Favorites",
                column: "PlaylistID",
                principalTable: "Playlist",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Favorites_Song_SongID",
                table: "Favorites",
                column: "SongID",
                principalTable: "Song",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RegisteredUser_Song_SongID",
                table: "RegisteredUser",
                column: "SongID",
                principalTable: "Song",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Review_Critic_CriticID",
                table: "Review",
                column: "CriticID",
                principalTable: "Critic",
                principalColumn: "PersonID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Review_Song_SongID",
                table: "Review",
                column: "SongID",
                principalTable: "Song",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
