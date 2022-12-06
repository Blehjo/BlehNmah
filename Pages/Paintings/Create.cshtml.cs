using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPagesBlehNmah.Data;
using RazorPagesBlehNmah.Models;

namespace RazorPagesBlehNmah.Pages.Paintings
{
    public class CreateModel : PageModel
    {
        private readonly RazorPagesBlehNmah.Data.RazorPagesPaintingContext _context;

        public CreateModel(RazorPagesBlehNmah.Data.RazorPagesPaintingContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Painting Painting { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Painting == null || Painting == null)
            {
                return Page();
            }

            _context.Painting.Add(Painting);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
