using System;
using Microsoft.EntityFrameworkCore;

namespace RazorPagesBlehNmah.Data
{
	public static class IWebHostExtensions
	{
        public static WebApplication MigrateDatabase(this WebApplication webApp)
        {
            using (var scope = webApp.Services.CreateScope())
            {
                using (var appContext = scope.ServiceProvider.GetRequiredService<RazorPagesGalleryContext>())
                {
                    try
                    {
                        appContext.Database.Migrate();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                        //Log errors or do anything you think it's needed
                        throw;
                    }
                }
            }

            return webApp;
        }
    }
}

