using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesBlehNmah.Models;

namespace RazorPagesBlehNmah.Data;

public class RazorPagesGalleryContext : DbContext
{
    public RazorPagesGalleryContext (DbContextOptions<RazorPagesGalleryContext> options)
        : base(options)
    {
    }

    public DbSet<RazorPagesBlehNmah.Models.Collection> Collection { get; set; } = default!;
    public DbSet<RazorPagesBlehNmah.Models.Painting> Painting { get; set; } = default!;
    public DbSet<RazorPagesBlehNmah.Models.Photograph> Photograph { get; set; } = default!;
}
