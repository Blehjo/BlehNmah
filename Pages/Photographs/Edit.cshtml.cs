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

namespace RazorPagesBlehNmah.Pages.Photographs
{
    public class EditModel : PageModel
    {
        private readonly RazorPagesBlehNmah.Data.RazorPagesGalleryContext _context;

        public EditModel(RazorPagesBlehNmah.Data.RazorPagesGalleryContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Photograph Photograph { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Photograph == null)
            {
                return NotFound();
            }

            var photograph =  await _context.Photograph.FirstOrDefaultAsync(m => m.Id == id);
            if (photograph == null)
            {
                return NotFound();
            }
            Photograph = photograph;
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

            _context.Attach(Photograph).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PhotographExists(Photograph.Id))
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

        private bool PhotographExists(int id)
        {
          return (_context.Photograph?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
