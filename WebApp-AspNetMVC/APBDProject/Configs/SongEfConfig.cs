using APBDProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APBDProject.Configs;

public class SongEfConfig : IEntityTypeConfiguration<Song>
{
    public void Configure(EntityTypeBuilder<Song> builder)
    {
        builder.HasKey(e => e.IdSong).HasName("Song_PK");
        builder.Property(e => e.IdSong).UseIdentityColumn();

        builder.Property(e => e.Title).HasMaxLength(100).IsRequired();
        builder.Property(e => e.Author).HasMaxLength(100).IsRequired();
        builder.Property(e => e.Duration).HasColumnType("decimal(4,2)").IsRequired();

        builder.HasOne(e => e.Album)
            .WithMany(e => e.Songs)
            .HasForeignKey(e => e.IdAlbum)
            .HasConstraintName("Album_Song")
            .OnDelete(DeleteBehavior.Restrict);

        builder.ToTable("Song");
    }
}