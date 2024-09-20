using APBDProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APBDProject.Configs;

public class AlbumEfConfig : IEntityTypeConfiguration<Album>
{
    public void Configure(EntityTypeBuilder<Album> builder)
    {
        builder.HasKey(e => e.IdAlbum).HasName("Album_PK");
        builder.Property(e => e.IdAlbum).UseIdentityColumn();

        builder.Property(e => e.Title).HasMaxLength(100).IsRequired();
        builder.Property(e => e.ReleaseYear).IsRequired();

        builder.ToTable("Album");
    }
}