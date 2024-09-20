using APBDProject.Models;
using APBDProject.Repositories;

namespace APBDProject.Services;

public class SongsService : ISongsService
{
    private ISongsRepository _songsRepository;
    
    public SongsService(ISongsRepository songsRepository)
    {
        _songsRepository = songsRepository;
    }
    
    public async Task<List<Song>> GetSong(string query, CancellationToken cancellationToken)
    {
        if (!string.IsNullOrWhiteSpace(query))
        {
            return await _songsRepository.GetSong(query, cancellationToken);
        }
        
        return await _songsRepository.GetSong(cancellationToken);
    }
}