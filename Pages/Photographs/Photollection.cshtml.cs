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
    public class CollectionsModel : PageModel
    {
        private readonly RazorPagesBlehNmah.Data.RazorPagesGalleryContext _context;

        public CollectionsModel(RazorPagesBlehNmah.Data.RazorPagesGalleryContext context)
        {
            _context = context;
        }

      public Photograph Photograph { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Photograph == null)
            {
                return NotFound();
            }

            var photograph = await _context.Photograph.FirstOrDefaultAsync(m => m.Id == id);
            if (photograph == null)
            {
                return NotFound();
            }
            else 
            {
                Photograph = photograph;
            }
            return Page();
        }
    }
}
