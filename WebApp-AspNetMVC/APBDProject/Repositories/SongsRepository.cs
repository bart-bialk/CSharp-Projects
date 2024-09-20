using APBDProject.Context;
using APBDProject.Models;
using Microsoft.EntityFrameworkCore;

namespace APBDProject.Repositories;

public class SongsRepository : ISongsRepository
{
    private SongsDbContext _dbContext;
    
    public SongsRepository(SongsDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<List<Song>> GetSong(string query, CancellationToken cancellationToken)
    {
        return await _dbContext.Songs.Where(s => s.Title.ToLower().Contains(query) || s.Author.ToLower().Contains(query)).ToListAsync(cancellationToken);
    }
    
    public async Task<List<Song>> GetSong(CancellationToken cancellationToken)
    {
        return await _dbContext.Songs.ToListAsync(cancellationToken);
    }
}