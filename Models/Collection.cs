using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesBlehNmah.Models;

public class Collection
{
    public int CollectionID { get; set; }

    [Display(Name = "Collection")]
    public string? CollectionName { get; set; }

    public DateTime Year { get; set; }

    public virtual ICollection<Painting>? Paintings { get; set; }

    public virtual ICollection<Photograph>? Photographs { get; set; }
}