using RazorPagesBlehNmah.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace RazorPagesBlehNmah.DAL
{
	public class GalleryContext : DbContext
	{
		public GalleryContext() : base("GalleryContext")
		{
            Database.SetInitializer<GalleryContext>(new CreateDatabaseIfNotExists<GalleryContext>());
        }

		public DbSet<Collection> Collections { get; set; }
		public DbSet<Painting> Paintings { get; set; }
        public DbSet<Photograph> Photographs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            {
				modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
			}
        }
    }
}

