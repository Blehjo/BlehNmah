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
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesGalleryContext _context;

        public DetailsModel(RazorPagesGalleryContext context)
        {
            _context = context;
        }

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
    }
}
