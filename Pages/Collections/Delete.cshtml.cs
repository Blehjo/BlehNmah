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
    public class DeleteModel : PageModel
    {
        private readonly RazorPagesGalleryContext _context;

        public DeleteModel(RazorPagesGalleryContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Collection Collection { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Collection == null)
            {
                return NotFound();
            }

            var collection = await _context.Collection.FirstOrDefaultAsync(m => m.CollectionID == id);

            if (collection == null)
            {
                return NotFound();
            }
            else 
            {
                Collection = collection;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Collection == null)
            {
                return NotFound();
            }
            var collection = await _context.Collection.FindAsync(id);

            if (collection != null)
            {
                Collection = collection;
                _context.Collection.Remove(Collection);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}