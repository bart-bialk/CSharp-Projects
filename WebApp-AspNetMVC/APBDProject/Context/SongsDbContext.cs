using System.Data;
using APBDProject.Models;
using Microsoft.EntityFrameworkCore;

namespace APBDProject.Context;

public class SongsDbContext : DbContext
{
    public virtual DbSet<Song> Songs { get; set; }
    public virtual DbSet<Album> Albums { get; set; }
        
    public SongsDbContext()
    {
        
    }


    public SongsDbContext(DbContextOptions<SongsDbContext> options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(SongsDbContext).Assembly);
    }
}