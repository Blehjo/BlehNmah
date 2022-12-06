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

namespace RazorPagesBlehNmah.Pages.Paintings;

public class IndexModel : PageModel
{
    private readonly RazorPagesBlehNmah.Data.RazorPagesPaintingContext _context;

    public IndexModel(RazorPagesBlehNmah.Data.RazorPagesPaintingContext context)
    {
        _context = context;
    }

    public IList<Painting> Painting { get;set; } = default!;

    [BindProperty(SupportsGet = true)]
    public string? SearchString { get; set; }

    public SelectList? Genres { get; set; }

    [BindProperty(SupportsGet = true)]
    public DateTime? PaintingYear { get; set; }

    public async Task OnGetAsync()
    {
        IQueryable<DateTime> yearQuery = from p in _context.Painting
                                           orderby p.Year
                                           select p.Year;

        var paintings = from p in _context.Painting
                     select p;
        if (!string.IsNullOrEmpty(SearchString))
        {
            paintings = paintings.Where(s => s.Title.Contains(SearchString));
        }

        if (!string.IsNullOrEmpty(PaintingYear))
        {
            paintings = paintings.Where(x => x.Year == PaintingYear);
        }
        Years = new SelectList(await yearQuery.Distinct().ToListAsync());
        Painting = await paintings.ToListAsync();
    }
}
