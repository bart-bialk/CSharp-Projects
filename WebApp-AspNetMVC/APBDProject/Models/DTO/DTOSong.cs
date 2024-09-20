using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace APBDProject.Models;

public class DTOSong
{
    [Key]
    public int IdSong { get; set; }
    
    [Required]
    [MaxLength(100)]
    [DisplayName("Title")]
    public string Title { get; set; }

    [Required]
    [MaxLength(100)]
    [DisplayName("Author")]
    public string Author { get; set; }

    [Required]
    [DisplayName("Duration")]
    public double Duration { get; set; }
    
}