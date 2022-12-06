using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesBlehNmah.Models;

namespace RazorPagesBlehNmah.Data
{
    public class RazorPagesPaintingContext : DbContext
    {
        public RazorPagesPaintingContext (DbContextOptions<RazorPagesPaintingContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesBlehNmah.Models.Painting> Painting { get; set; } = default!;
    }
}
