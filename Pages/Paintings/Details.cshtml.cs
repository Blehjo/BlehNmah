using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesBlehNmah.Data;
using RazorPagesBlehNmah.Models;

namespace RazorPagesBlehNmah.Pages.Paintings
{
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesBlehNmah.Data.RazorPagesGalleryContext _context;

        public DetailsModel(RazorPagesBlehNmah.Data.RazorPagesGalleryContext context)
        {
            _context = context;
        }

      public Painting Painting { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Painting == null)
            {
                return NotFound();
            }

            var painting = await _context.Painting.FirstOrDefaultAsync(m => m.Id == id);
            if (painting == null)
            {
                return NotFound();
            }
            else 
            {
                Painting = painting;
            }
            return Page();
        }
    }
}
