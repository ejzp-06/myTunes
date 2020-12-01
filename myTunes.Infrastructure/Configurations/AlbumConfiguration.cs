using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using myTunes.Core.Entities;

namespace myTunes.Infrastructure.Configurations
{
    public class AlbumConfiguration : IEntityTypeConfiguration<Album>
    {
        public void Configure(EntityTypeBuilder<Album> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.Property(x => x.Name).IsRequired();

            builder.Property(x => x.Author).IsRequired();

            builder.Property(x => x.Genre).IsRequired();

            builder.Property(x => x.LaunchDate).IsRequired();

            builder.Property(x => x.points).IsRequired();

            builder.Property(x => x.Songs).IsRequired();

            builder.Property(x => x.Price).IsRequired();

            builder.Property(x => x.Image).IsRequired();

            builder.Property(x => x.Description).IsRequired();
        }
    }
}
