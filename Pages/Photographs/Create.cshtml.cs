using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPagesBlehNmah.Data;
using RazorPagesBlehNmah.Models;

namespace RazorPagesBlehNmah.Pages.Photographs
{
    public class CreateModel : PageModel
    {
        private readonly RazorPagesBlehNmah.Data.RazorPagesGalleryContext _context;

        public CreateModel(RazorPagesBlehNmah.Data.RazorPagesGalleryContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["CollectionID"] = new SelectList(_context.Collection, "CollectionID", "CollectionID");
            return Page();
        }

        [BindProperty]
        public Photograph Photograph { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Photograph == null || Photograph == null)
            {
                return Page();
            }

            _context.Photograph.Add(Photograph);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
