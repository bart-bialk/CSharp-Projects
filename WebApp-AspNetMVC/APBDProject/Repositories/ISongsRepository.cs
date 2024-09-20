using APBDProject.Models;

namespace APBDProject.Repositories;

public interface ISongsRepository
{
    public Task<List<Song>> GetSong(string query,CancellationToken cancellationToken);
    public Task<List<Song>> GetSong(CancellationToken cancellationToken);
}