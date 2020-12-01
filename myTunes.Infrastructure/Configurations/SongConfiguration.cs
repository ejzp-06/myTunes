using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using myTunes.Core.Entities;

namespace myTunes.Infrastructure.Configurations
{
    public class SongConfiguration : IEntityTypeConfiguration<Song>
    {
        public void Configure(EntityTypeBuilder<Song> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.Property(x => x.Name).IsRequired();

            builder.Property(x => x.Author).IsRequired();

            builder.Property(x => x.Price).IsRequired();

            builder.Property(x => x.Duration).IsRequired();

            builder.Property(x => x.Popularity).IsRequired();
        }
    }
}
