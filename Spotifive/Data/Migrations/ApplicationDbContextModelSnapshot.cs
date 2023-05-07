﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Spotifive.Data;

namespace Spotifive.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Spotifive.Models.Account", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AdminID")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("AdminID")
                        .IsUnique()
                        .HasFilter("[AdminID] IS NOT NULL");

                    b.ToTable("Account");
                });

            modelBuilder.Entity("Spotifive.Models.Artist", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ArtistName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ArtistSurname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Artist");
                });

            modelBuilder.Entity("Spotifive.Models.ArtistHasSong", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ArtistID")
                        .HasColumnType("int");

                    b.Property<int?>("SongID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ArtistID");

                    b.HasIndex("SongID");

                    b.ToTable("ArtistHasSong");
                });

            modelBuilder.Entity("Spotifive.Models.EditingOfArtist", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ArtistID")
                        .HasColumnType("int");

                    b.Property<int?>("EditorID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ArtistID");

                    b.HasIndex("EditorID");

                    b.ToTable("EditingOfArtist");
                });

            modelBuilder.Entity("Spotifive.Models.EditingOfSong", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("EditorID")
                        .HasColumnType("int");

                    b.Property<int?>("SongID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("EditorID");

                    b.HasIndex("SongID");

                    b.ToTable("EditingOfSong");
                });

            modelBuilder.Entity("Spotifive.Models.Favorites", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("PlaylistID")
                        .HasColumnType("int");

                    b.Property<int?>("SongID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("PlaylistID");

                    b.HasIndex("SongID");

                    b.ToTable("Favorites");
                });

            modelBuilder.Entity("Spotifive.Models.Person", b =>
                {
                    b.Property<int>("PersonID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DateOfBirth")
                        .HasColumnType("int");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PersonID");

                    b.ToTable("Person");
                });

            modelBuilder.Entity("Spotifive.Models.Playlist", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PlaylistName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("UserID");

                    b.ToTable("Playlist");
                });

            modelBuilder.Entity("Spotifive.Models.Review", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CriticID")
                        .HasColumnType("int");

                    b.Property<double>("Grade")
                        .HasColumnType("float");

                    b.Property<int?>("SongID")
                        .HasColumnType("int");

                    b.Property<string>("TimeStamp")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("CriticID");

                    b.HasIndex("SongID");

                    b.ToTable("Review");
                });

            modelBuilder.Entity("Spotifive.Models.Song", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CodeQR")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DateRelease")
                        .HasColumnType("int");

                    b.Property<int>("Genre")
                        .HasColumnType("int");

                    b.Property<string>("LinkYT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SongName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Song");
                });

            modelBuilder.Entity("Spotifive.Models.Administrator", b =>
                {
                    b.HasBaseType("Spotifive.Models.Person");

                    b.ToTable("Administrator");
                });

            modelBuilder.Entity("Spotifive.Models.Critic", b =>
                {
                    b.HasBaseType("Spotifive.Models.Person");

                    b.Property<int?>("AccountID")
                        .HasColumnType("int");

                    b.HasIndex("AccountID");

                    b.ToTable("Critic");
                });

            modelBuilder.Entity("Spotifive.Models.Editor", b =>
                {
                    b.HasBaseType("Spotifive.Models.Person");

                    b.Property<int?>("AccountID")
                        .HasColumnType("int");

                    b.HasIndex("AccountID");

                    b.ToTable("Editor");
                });

            modelBuilder.Entity("Spotifive.Models.RegisteredUser", b =>
                {
                    b.HasBaseType("Spotifive.Models.Person");

                    b.Property<int?>("AccountID")
                        .HasColumnType("int");

                    b.Property<int?>("SongID")
                        .HasColumnType("int");

                    b.HasIndex("AccountID");

                    b.HasIndex("SongID");

                    b.ToTable("RegisteredUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Spotifive.Models.Account", b =>
                {
                    b.HasOne("Spotifive.Models.Administrator", "Administrator")
                        .WithOne("Account")
                        .HasForeignKey("Spotifive.Models.Account", "AdminID");

                    b.Navigation("Administrator");
                });

            modelBuilder.Entity("Spotifive.Models.ArtistHasSong", b =>
                {
                    b.HasOne("Spotifive.Models.Artist", "Artist")
                        .WithMany()
                        .HasForeignKey("ArtistID");

                    b.HasOne("Spotifive.Models.Song", "Song")
                        .WithMany()
                        .HasForeignKey("SongID");

                    b.Navigation("Artist");

                    b.Navigation("Song");
                });

            modelBuilder.Entity("Spotifive.Models.EditingOfArtist", b =>
                {
                    b.HasOne("Spotifive.Models.Artist", "Artist")
                        .WithMany()
                        .HasForeignKey("ArtistID");

                    b.HasOne("Spotifive.Models.Editor", "Editor")
                        .WithMany()
                        .HasForeignKey("EditorID");

                    b.Navigation("Artist");

                    b.Navigation("Editor");
                });

            modelBuilder.Entity("Spotifive.Models.EditingOfSong", b =>
                {
                    b.HasOne("Spotifive.Models.Editor", "Editor")
                        .WithMany()
                        .HasForeignKey("EditorID");

                    b.HasOne("Spotifive.Models.Song", "Song")
                        .WithMany()
                        .HasForeignKey("SongID");

                    b.Navigation("Editor");

                    b.Navigation("Song");
                });

            modelBuilder.Entity("Spotifive.Models.Favorites", b =>
                {
                    b.HasOne("Spotifive.Models.Playlist", "Playlist")
                        .WithMany()
                        .HasForeignKey("PlaylistID");

                    b.HasOne("Spotifive.Models.Song", "Song")
                        .WithMany()
                        .HasForeignKey("SongID");

                    b.Navigation("Playlist");

                    b.Navigation("Song");
                });

            modelBuilder.Entity("Spotifive.Models.Playlist", b =>
                {
                    b.HasOne("Spotifive.Models.RegisteredUser", "User")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Spotifive.Models.Review", b =>
                {
                    b.HasOne("Spotifive.Models.Critic", "User")
                        .WithMany()
                        .HasForeignKey("CriticID");

                    b.HasOne("Spotifive.Models.Song", "Song")
                        .WithMany()
                        .HasForeignKey("SongID");

                    b.Navigation("Song");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Spotifive.Models.Administrator", b =>
                {
                    b.HasOne("Spotifive.Models.Person", null)
                        .WithOne()
                        .HasForeignKey("Spotifive.Models.Administrator", "PersonID")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Spotifive.Models.Critic", b =>
                {
                    b.HasOne("Spotifive.Models.Account", "Account")
                        .WithMany()
                        .HasForeignKey("AccountID");

                    b.HasOne("Spotifive.Models.Person", null)
                        .WithOne()
                        .HasForeignKey("Spotifive.Models.Critic", "PersonID")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("Spotifive.Models.Editor", b =>
                {
                    b.HasOne("Spotifive.Models.Account", "Account")
                        .WithMany()
                        .HasForeignKey("AccountID");

                    b.HasOne("Spotifive.Models.Person", null)
                        .WithOne()
                        .HasForeignKey("Spotifive.Models.Editor", "PersonID")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("Spotifive.Models.RegisteredUser", b =>
                {
                    b.HasOne("Spotifive.Models.Account", "Account")
                        .WithMany()
                        .HasForeignKey("AccountID");

                    b.HasOne("Spotifive.Models.Person", null)
                        .WithOne()
                        .HasForeignKey("Spotifive.Models.RegisteredUser", "PersonID")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.HasOne("Spotifive.Models.Song", "Song")
                        .WithMany()
                        .HasForeignKey("SongID");

                    b.Navigation("Account");

                    b.Navigation("Song");
                });

            modelBuilder.Entity("Spotifive.Models.Administrator", b =>
                {
                    b.Navigation("Account");
                });
#pragma warning restore 612, 618
        }
    }
}
