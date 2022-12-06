using Microsoft.EntityFrameworkCore;
using RazorPagesBlehNmah.Data;

namespace RazorPagesBlehNmah.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new RazorPagesPaintingContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<RazorPagesPaintingContext>>()))
        {
            if (context == null || context.Painting == null)
            {
                throw new ArgumentNullException("Null RazorPagesPaintigContext");
            }

            // Look for any painting.
            if (context.Painting.Any())
            {
                return;   // DB has been seeded
            }

            context.Painting.AddRange(
                new Painting
                {
                    Title = "When Harry Met Sally",
                    Year = DateTime.Parse("1989-2-12"),
                    Location = "Romantic Comedy",
                },

                new Painting
                {
                    Title = "Ghostbusters ",
                    Year = DateTime.Parse("1984-3-13"),
                    Location = "Comedy",
                },

                new Painting
                {
                    Title = "Ghostbusters 2",
                    Year = DateTime.Parse("1986-2-23"),
                    Location = "Comedy",
                },

                new Painting
                {
                    Title = "Rio Bravo",
                    Year = DateTime.Parse("1959-4-15"),
                    Location = "Western",
                }
            );
            context.SaveChanges();
        }
    }
}