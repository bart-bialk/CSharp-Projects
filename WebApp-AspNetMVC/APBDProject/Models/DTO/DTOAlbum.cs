using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace APBDProject.Models;

public class DTOAlbum
{
    [Key]
    public int IdAlbum { get; set; }
    
    [Required]
    [MaxLength(100)]
    [DisplayName("Title")]
    public string Title { get; set; }
    
}