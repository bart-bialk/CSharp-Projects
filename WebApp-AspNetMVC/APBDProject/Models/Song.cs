using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace APBDProject.Models;

public class Song
{
    public int IdSong { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public double Duration { get; set; }
    public int IdAlbum { get; set; }
    public virtual Album Album { get; set; }
    
}