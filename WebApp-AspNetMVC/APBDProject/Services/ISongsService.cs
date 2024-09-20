using APBDProject.Models;
using APBDProject.Repositories;

namespace APBDProject.Services;

public interface ISongsService
{
    public Task<List<Song>> GetSong(string query, CancellationToken cancellationToken);
}