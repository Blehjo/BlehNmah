using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPagesBlehNmah.Models;
using RazorPagesBlehNmah.Data;

namespace RazorPagesBlehNmah.Pages.Collections
{
    public class CreateModel : PageModel
    {
        private readonly RazorPagesGalleryContext _context;

        public CreateModel(RazorPagesGalleryContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Collection Collection { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Collection == null || Collection == null)
            {
                return Page();
            }

            _context.Collection.Add(Collection);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}