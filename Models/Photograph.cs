﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesBlehNmah.Models;

public class Photograph
{
    public int Id { get; set; }

    public int? CollectionID { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    [DataType(DataType.Date)]
    public DateTime Year { get; set; }

    public string? Location { get; set; }

    public string? MediaLocation { get; set; }

    public virtual Collection? Collection { get; set; }
}