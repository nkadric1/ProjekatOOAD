using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Spotifive.Models;
using System;
using System.Collections.Generic;
using System.Text;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Spotifive.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        //implementation of singleton pattern
        private static ApplicationDbContext instance;
        private ApplicationDbContext()
        {
        }
        public static ApplicationDbContext getInstance()
        {
            if (instance == null)
            {
                instance = new ApplicationDbContext();
            }
            return instance;
        }

        public Connection getConnection()
        {
            return null;
        }
        public DbSet<Account> Account { get; set; }
        public DbSet<Administrator> Administrator { get; set; }
        public DbSet<Artist> Artist { get; set; }
        public DbSet<ArtistSongs> ArtistSongs { get; set; }
        public DbSet<EditorSongs> EditorSongs { get; set; }
        public DbSet<EditorSongs> UserSongs { get; set; }


        public DbSet<Critic> Critic { get; set; }
        public DbSet<Editor> Editor { get; set; }
        public DbSet<Song> Song { get; set; }
        public DbSet<Person> Person { get; set; }
        public DbSet<Playlist> Playlist { get; set; }
        public DbSet<PlaylistSongs> PlaylistSongs { get; set; }
        public DbSet<RegisteredUser> RegisteredUser { get; set; }
        public DbSet<Review> Review { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
           modelBuilder.Entity<Account>().ToTable("Account");
          modelBuilder.Entity<Administrator>().ToTable("Administrator");
           modelBuilder.Entity<Artist>().ToTable("Artist");
           modelBuilder.Entity<Critic>().ToTable("Critic");
            modelBuilder.Entity<Editor>().ToTable("Editor");
            modelBuilder.Entity<ArtistSongs>().ToTable("ArtistSongs");
            modelBuilder.Entity<EditorSongs>().ToTable("EditorSongs");
            modelBuilder.Entity<UserSongs>().ToTable("UserSongs");

            modelBuilder.Entity<Song>().ToTable("Song");
           modelBuilder.Entity<Person>().ToTable("Person");
           modelBuilder.Entity<Playlist>().ToTable("Playlist");
            modelBuilder.Entity<RegisteredUser>().ToTable("RegisteredUser");
            modelBuilder.Entity<Review>().ToTable("Review");
          modelBuilder.Entity<PlaylistSongs>().ToTable("PlaylistSongs");
			modelBuilder.Entity<ApplicationUser>()
				.Property(e => e.Name)
				.HasMaxLength(250);

			modelBuilder.Entity<ApplicationUser>()
				.Property(e => e.Surname)
				.HasMaxLength(250);
	


			modelBuilder.Entity<ApplicationUser>()
							.Property(e => e.DateOfBirth)
							.HasMaxLength(250);

			modelBuilder.Entity<ApplicationUser>()
				.Property(e => e.Gender)
				.HasMaxLength(250);
			modelBuilder.Entity<ApplicationUser>()
							.Property(e => e.Role)
							.HasMaxLength(250);


			base.OnModelCreating(modelBuilder);
        }
     
    }

}
