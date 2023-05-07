using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Spotifive.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Spotifive.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Account> Account { get; set; }
        public DbSet<Administrator> Administrator { get; set; }
        public DbSet<Artist> Artist { get; set; }
        public DbSet<ArtistHasSong> ArtistHasSong { get; set; }
        public DbSet<Critic> Critic { get; set; }
        public DbSet<EditingOfArtist> EditingOfArtist { get; set;}
        public DbSet<Editor> Editor { get; set; }
        public DbSet<EditingOfSong> EditingOfSong { get; set;}
        public DbSet<Favorites> Favorites { get; set; }
        public DbSet<Song>  Song { get; set; }
        public DbSet<Person> Person { get; set; }
        public DbSet<Playlist> Playlist { get; set; }
        public DbSet<RegisteredUser>    RegisteredUser { get; set; }
public DbSet<Review> Review { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>().ToTable("Account");
            modelBuilder.Entity<Administrator>().ToTable("Administrator");
            modelBuilder.Entity<Artist>().ToTable("Artist");
            modelBuilder.Entity<Critic>().ToTable("Critic");
            modelBuilder.Entity<Editor>().ToTable("Editor");
            modelBuilder.Entity<ArtistHasSong>().ToTable("ArtistHasSong");
            modelBuilder.Entity<EditingOfSong>().ToTable("EditingOfSong");
            modelBuilder.Entity<EditingOfArtist>().ToTable("EditingOfArtist");
            modelBuilder.Entity<Favorites>().ToTable("Favorites");
            modelBuilder.Entity<Song>().ToTable("Song");
            modelBuilder.Entity<Person>().ToTable("Person");
            modelBuilder.Entity<Playlist>().ToTable("Playlist");
            modelBuilder.Entity<RegisteredUser>().ToTable("RegisteredUser");
            modelBuilder.Entity<Review>().ToTable("Review");
            base.OnModelCreating(modelBuilder);
        }
    }

}
