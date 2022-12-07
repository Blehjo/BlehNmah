using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesBlehNmah.Data;
using RazorPagesBlehNmah.Models;

namespace RazorPagesBlehNmah.Pages.Photographs
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesBlehNmah.Data.RazorPagesGalleryContext _context;

        public IndexModel(RazorPagesBlehNmah.Data.RazorPagesGalleryContext context)
        {
            _context = context;
        }

        public IList<Photograph> Photograph { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Photograph != null)
            {
                Photograph = await _context.Photograph
                .Include(p => p.Collection).ToListAsync();
            }
        }
    }
}
