using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RazorPagesBlehNmah.Data;
using RazorPagesBlehNmah.Models;

namespace RazorPagesBlehNmah.Pages.Paintings
{
    public class EditModel : PageModel
    {
        private readonly RazorPagesBlehNmah.Data.RazorPagesGalleryContext _context;

        public EditModel(RazorPagesBlehNmah.Data.RazorPagesGalleryContext context)
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

            var painting =  await _context.Painting.FirstOrDefaultAsync(m => m.Id == id);
            if (painting == null)
            {
                return NotFound();
            }
            Painting = painting;
           ViewData["CollectionID"] = new SelectList(_context.Collection, "CollectionID", "CollectionID");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Painting).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PaintingExists(Painting.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool PaintingExists(int id)
        {
          return (_context.Painting?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
