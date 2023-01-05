using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesBlehNmah.Models;
using RazorPagesBlehNmah.Data;

namespace RazorPagesBlehNmah.Pages.Collections
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesGalleryContext _context;

        public IndexModel(RazorPagesGalleryContext context)
        {
            _context = context;
        }

        public IList<Collection> Collection { get; set; } = default!;

        public IList<Painting> Painting { get; set; } = default!;

        public IList<Photograph> Photograph { get; set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Collection != null)
            {
                Collection = await _context.Collection.ToListAsync();
                Painting = await _context.Painting.ToListAsync();
                Photograph = await _context.Photograph.ToListAsync();
            }
        }
    }
}
