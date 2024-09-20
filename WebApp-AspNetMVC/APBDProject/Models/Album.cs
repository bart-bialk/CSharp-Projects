using System.Collections;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace APBDProject.Models;

public class Album
{
    public int IdAlbum { get; set; }
    public string Title { get; set; }
    public DateTime ReleaseYear { get; set; }
    public virtual ICollection<Song> Songs { get; set; }
    
    
}