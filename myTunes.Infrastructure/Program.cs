using Microsoft.EntityFrameworkCore;
using myTunes.Core.Entities;
using myTunes.Infrastructure.Configurations;

namespace shoponline.Infrastructure
{
    public class myTunesDbContext : DbContext
    {
        public myTunesDbContext(DbContextOptions options) :
            base(options)
        {

        }

        public DbSet<Song> Songs { get; set; }

        public DbSet<Album> Albums { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new SongConfiguration());
            modelBuilder.ApplyConfiguration(new AlbumConfiguration());
        }
    }
}