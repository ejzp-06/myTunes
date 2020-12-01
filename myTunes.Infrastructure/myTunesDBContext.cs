using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using myTunes.Infrastructure.Configurations;
using myTunes.Core.Entities;

namespace myTunes.Infrastructure
{

    public class myTunesDbContext : DbContext
    {
        public myTunesDbContext(DbContextOptions options) :
            base(options)
        {
        }
        public DbSet<Song> Songs { get; set; }
        public DbSet<Album> Authors { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new SongConfiguration());
            modelBuilder.ApplyConfiguration(new AlbumConfiguration());
        }

    }
}
