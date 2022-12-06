﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesBlehNmah.Models;

public class Painting
{
    public int Id { get; set; }

    public string? Title { get; set; }

    [DataType(DataType.Date)]
    public DateTime Year { get; set; }

    public string? Location { get; set; }
    //public string? MediaLocation { get; set; }
}

