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
    public class DeleteModel : PageModel
    {
        private readonly RazorPagesBlehNmah.Data.RazorPagesPaintingContext _context;

        public DeleteModel(RazorPagesBlehNmah.Data.RazorPagesPaintingContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Painting == null)
            {
                return NotFound();
            }
            var painting = await _context.Painting.FindAsync(id);

            if (painting != null)
            {
                Painting = painting;
                _context.Painting.Remove(Painting);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
