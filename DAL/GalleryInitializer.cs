using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using RazorPagesBlehNmah.Models;
using System.Diagnostics;

namespace RazorPagesBlehNmah.DAL
{
	public class GalleryInitializer : CreateDatabaseIfNotExists<GalleryContext>
	{
        protected override void Seed(GalleryContext context)
        {
            //var collections = new List<Collection>
            //{
            //new Collection{CollectionName="Masks",Year=DateTime.Parse("2005-09-01")},
            //new Collection{CollectionName="Profiles",Year=DateTime.Parse("2002-09-01")},
            //new Collection{CollectionName="Fashion",Year=DateTime.Parse("2003-09-01")},
            //new Collection{CollectionName="Color Theory",Year=DateTime.Parse("2002-09-01")},
            //new Collection{CollectionName="Faces",Year=DateTime.Parse("2002-09-01")},
            //new Collection{CollectionName="Early Works",Year=DateTime.Parse("2001-09-01")},
            //new Collection{CollectionName="Expressionism",Year=DateTime.Parse("2003-09-01")},
            //new Collection{CollectionName="Animals",Year=DateTime.Parse("2005-09-01")}
            //};

            //collections.ForEach(c => context.Collections.Add(c));
            //context.SaveChanges();
            //var paintings = new List<Painting>
            //{
            //new Painting{CollectionID=1,Title="Eyes from Above",Year=DateTime.Parse("2005-09-01"),Medium="Oil Paint, Canvas",Location="Chicago, Illinois",MediaLocation="https://d7hftxdivxxvm.cloudfront.net/?resize_to=fit&src=https%3A%2F%2Fd32dm0rphc51dk.cloudfront.net%2FiNARiJXoSBLiVgZLRJCfkQ%2Fnormalized.jpg&width=4000&height=4000&quality=80"},
            //new Painting{CollectionID=1,Title="Eyes from Above",Year=DateTime.Parse("2005-09-01"),Medium="Oil Paint, Canvas",Location="Chicago, Illinois",MediaLocation="https://d7hftxdivxxvm.cloudfront.net/?resize_to=fit&src=https%3A%2F%2Fd32dm0rphc51dk.cloudfront.net%2FiNARiJXoSBLiVgZLRJCfkQ%2Fnormalized.jpg&width=4000&height=4000&quality=80"},
            //new Painting{CollectionID=1,Title="Eyes from Above",Year=DateTime.Parse("2005-09-01"),Medium="Oil Paint, Canvas",Location="Chicago, Illinois",MediaLocation="https://d7hftxdivxxvm.cloudfront.net/?resize_to=fit&src=https%3A%2F%2Fd32dm0rphc51dk.cloudfront.net%2FiNARiJXoSBLiVgZLRJCfkQ%2Fnormalized.jpg&width=4000&height=4000&quality=80"},
            //new Painting{CollectionID=1,Title="Eyes from Above",Year=DateTime.Parse("2005-09-01"),Medium="Oil Paint, Canvas",Location="Chicago, Illinois",MediaLocation="https://d7hftxdivxxvm.cloudfront.net/?resize_to=fit&src=https%3A%2F%2Fd32dm0rphc51dk.cloudfront.net%2FiNARiJXoSBLiVgZLRJCfkQ%2Fnormalized.jpg&width=4000&height=4000&quality=80"},
            //new Painting{CollectionID=1,Title="Eyes from Above",Year=DateTime.Parse("2005-09-01"),Medium="Oil Paint, Canvas",Location="Chicago, Illinois",MediaLocation="https://d7hftxdivxxvm.cloudfront.net/?resize_to=fit&src=https%3A%2F%2Fd32dm0rphc51dk.cloudfront.net%2FiNARiJXoSBLiVgZLRJCfkQ%2Fnormalized.jpg&width=4000&height=4000&quality=80"},
            //new Painting{CollectionID=1,Title="Eyes from Above",Year=DateTime.Parse("2005-09-01"),Medium="Oil Paint, Canvas",Location="Chicago, Illinois",MediaLocation="https://d7hftxdivxxvm.cloudfront.net/?resize_to=fit&src=https%3A%2F%2Fd32dm0rphc51dk.cloudfront.net%2FiNARiJXoSBLiVgZLRJCfkQ%2Fnormalized.jpg&width=4000&height=4000&quality=80"},
            //new Painting{CollectionID=1,Title="Eyes from Above",Year=DateTime.Parse("2005-09-01"),Medium="Oil Paint, Canvas",Location="Chicago, Illinois",MediaLocation="https://d7hftxdivxxvm.cloudfront.net/?resize_to=fit&src=https%3A%2F%2Fd32dm0rphc51dk.cloudfront.net%2FiNARiJXoSBLiVgZLRJCfkQ%2Fnormalized.jpg&width=4000&height=4000&quality=80"},
            //new Painting{CollectionID=1,Title="Eyes from Above",Year=DateTime.Parse("2005-09-01"),Medium="Oil Paint, Canvas",Location="Chicago, Illinois",MediaLocation="https://d7hftxdivxxvm.cloudfront.net/?resize_to=fit&src=https%3A%2F%2Fd32dm0rphc51dk.cloudfront.net%2FiNARiJXoSBLiVgZLRJCfkQ%2Fnormalized.jpg&width=4000&height=4000&quality=80"},
            //new Painting{CollectionID=1,Title="Eyes from Above",Year=DateTime.Parse("2005-09-01"),Medium="Oil Paint, Canvas",Location="Chicago, Illinois",MediaLocation="https://d7hftxdivxxvm.cloudfront.net/?resize_to=fit&src=https%3A%2F%2Fd32dm0rphc51dk.cloudfront.net%2FiNARiJXoSBLiVgZLRJCfkQ%2Fnormalized.jpg&width=4000&height=4000&quality=80"},
            //new Painting{CollectionID=1,Title="Eyes from Above",Year=DateTime.Parse("2005-09-01"),Medium="Oil Paint, Canvas",Location="Chicago, Illinois",MediaLocation="https://d7hftxdivxxvm.cloudfront.net/?resize_to=fit&src=https%3A%2F%2Fd32dm0rphc51dk.cloudfront.net%2FiNARiJXoSBLiVgZLRJCfkQ%2Fnormalized.jpg&width=4000&height=4000&quality=80"},
            //new Painting{CollectionID=1,Title="Eyes from Above",Year=DateTime.Parse("2005-09-01"),Medium="Oil Paint, Canvas",Location="Chicago, Illinois",MediaLocation="https://d7hftxdivxxvm.cloudfront.net/?resize_to=fit&src=https%3A%2F%2Fd32dm0rphc51dk.cloudfront.net%2FiNARiJXoSBLiVgZLRJCfkQ%2Fnormalized.jpg&width=4000&height=4000&quality=80"},
            //new Painting{CollectionID=1,Title="Eyes from Above",Year=DateTime.Parse("2005-09-01"),Medium="Oil Paint, Canvas",Location="Chicago, Illinois",MediaLocation="https://d7hftxdivxxvm.cloudfront.net/?resize_to=fit&src=https%3A%2F%2Fd32dm0rphc51dk.cloudfront.net%2FiNARiJXoSBLiVgZLRJCfkQ%2Fnormalized.jpg&width=4000&height=4000&quality=80"},
            //new Painting{CollectionID=1,Title="Eyes from Above",Year=DateTime.Parse("2005-09-01"),Medium="Oil Paint, Canvas",Location="Chicago, Illinois",MediaLocation="https://d7hftxdivxxvm.cloudfront.net/?resize_to=fit&src=https%3A%2F%2Fd32dm0rphc51dk.cloudfront.net%2FiNARiJXoSBLiVgZLRJCfkQ%2Fnormalized.jpg&width=4000&height=4000&quality=80"},
            //new Painting{CollectionID=1,Title="Eyes from Above",Year=DateTime.Parse("2005-09-01"),Medium="Oil Paint, Canvas",Location="Chicago, Illinois",MediaLocation="https://d7hftxdivxxvm.cloudfront.net/?resize_to=fit&src=https%3A%2F%2Fd32dm0rphc51dk.cloudfront.net%2FiNARiJXoSBLiVgZLRJCfkQ%2Fnormalized.jpg&width=4000&height=4000&quality=80"},
            //new Painting{CollectionID=1,Title="Eyes from Above",Year=DateTime.Parse("2005-09-01"),Medium="Oil Paint, Canvas",Location="Chicago, Illinois",MediaLocation="https://d7hftxdivxxvm.cloudfront.net/?resize_to=fit&src=https%3A%2F%2Fd32dm0rphc51dk.cloudfront.net%2FiNARiJXoSBLiVgZLRJCfkQ%2Fnormalized.jpg&width=4000&height=4000&quality=80"},
            //new Painting{CollectionID=1,Title="Eyes from Above",Year=DateTime.Parse("2005-09-01"),Medium="Oil Paint, Canvas",Location="Chicago, Illinois",MediaLocation="https://d7hftxdivxxvm.cloudfront.net/?resize_to=fit&src=https%3A%2F%2Fd32dm0rphc51dk.cloudfront.net%2FiNARiJXoSBLiVgZLRJCfkQ%2Fnormalized.jpg&width=4000&height=4000&quality=80"},
            //new Painting{CollectionID=1,Title="Eyes from Above",Year=DateTime.Parse("2005-09-01"),Medium="Oil Paint, Canvas",Location="Chicago, Illinois",MediaLocation="https://d7hftxdivxxvm.cloudfront.net/?resize_to=fit&src=https%3A%2F%2Fd32dm0rphc51dk.cloudfront.net%2FiNARiJXoSBLiVgZLRJCfkQ%2Fnormalized.jpg&width=4000&height=4000&quality=80"},
            //new Painting{CollectionID=1,Title="Eyes from Above",Year=DateTime.Parse("2005-09-01"),Medium="Oil Paint, Canvas",Location="Chicago, Illinois",MediaLocation="https://d7hftxdivxxvm.cloudfront.net/?resize_to=fit&src=https%3A%2F%2Fd32dm0rphc51dk.cloudfront.net%2FiNARiJXoSBLiVgZLRJCfkQ%2Fnormalized.jpg&width=4000&height=4000&quality=80"},
            //new Painting{CollectionID=1,Title="Eyes from Above",Year=DateTime.Parse("2005-09-01"),Medium="Oil Paint, Canvas",Location="Chicago, Illinois",MediaLocation="https://d7hftxdivxxvm.cloudfront.net/?resize_to=fit&src=https%3A%2F%2Fd32dm0rphc51dk.cloudfront.net%2FiNARiJXoSBLiVgZLRJCfkQ%2Fnormalized.jpg&width=4000&height=4000&quality=80"},
            //new Painting{CollectionID=1,Title="Eyes from Above",Year=DateTime.Parse("2005-09-01"),Medium="Oil Paint, Canvas",Location="Chicago, Illinois",MediaLocation="https://d7hftxdivxxvm.cloudfront.net/?resize_to=fit&src=https%3A%2F%2Fd32dm0rphc51dk.cloudfront.net%2FiNARiJXoSBLiVgZLRJCfkQ%2Fnormalized.jpg&width=4000&height=4000&quality=80"},
            //};
            //paintings.ForEach(p => context.Paintings.Add(p));
            //context.SaveChanges();
            //var photographs = new List<Photograph>
            //{
            //new Photograph{CollectionID=1,Title="Feet on the Ground",Year=DateTime.Parse("2005-09-01"),Location="Vienna, Austria",MediaLocation="https://media.cnn.com/api/v1/images/stellar/prod/181115180453-01-mars-best-moments-mars-globe-valles-marineris-enhanced.jpg?q=w_2500,h_1406,x_0,y_0,c_fill/w_1376"},
            //new Photograph{CollectionID=1,Title="Feet on the Ground",Year=DateTime.Parse("2005-09-01"),Location="Vienna, Austria",MediaLocation="https://media.cnn.com/api/v1/images/stellar/prod/181115180453-01-mars-best-moments-mars-globe-valles-marineris-enhanced.jpg?q=w_2500,h_1406,x_0,y_0,c_fill/w_1376"},
            //new Photograph{CollectionID=1,Title="Feet on the Ground",Year=DateTime.Parse("2005-09-01"),Location="Vienna, Austria",MediaLocation="https://media.cnn.com/api/v1/images/stellar/prod/181115180453-01-mars-best-moments-mars-globe-valles-marineris-enhanced.jpg?q=w_2500,h_1406,x_0,y_0,c_fill/w_1376"},
            //new Photograph{CollectionID=1,Title="Feet on the Ground",Year=DateTime.Parse("2005-09-01"),Location="Vienna, Austria",MediaLocation="https://media.cnn.com/api/v1/images/stellar/prod/181115180453-01-mars-best-moments-mars-globe-valles-marineris-enhanced.jpg?q=w_2500,h_1406,x_0,y_0,c_fill/w_1376"},
            //new Photograph{CollectionID=1,Title="Feet on the Ground",Year=DateTime.Parse("2005-09-01"),Location="Vienna, Austria",MediaLocation="https://media.cnn.com/api/v1/images/stellar/prod/181115180453-01-mars-best-moments-mars-globe-valles-marineris-enhanced.jpg?q=w_2500,h_1406,x_0,y_0,c_fill/w_1376"},
            //new Photograph{CollectionID=1,Title="Feet on the Ground",Year=DateTime.Parse("2005-09-01"),Location="Vienna, Austria",MediaLocation="https://media.cnn.com/api/v1/images/stellar/prod/181115180453-01-mars-best-moments-mars-globe-valles-marineris-enhanced.jpg?q=w_2500,h_1406,x_0,y_0,c_fill/w_1376"},
            //new Photograph{CollectionID=1,Title="Feet on the Ground",Year=DateTime.Parse("2005-09-01"),Location="Vienna, Austria",MediaLocation="https://media.cnn.com/api/v1/images/stellar/prod/181115180453-01-mars-best-moments-mars-globe-valles-marineris-enhanced.jpg?q=w_2500,h_1406,x_0,y_0,c_fill/w_1376"},
            //new Photograph{CollectionID=1,Title="Feet on the Ground",Year=DateTime.Parse("2005-09-01"),Location="Vienna, Austria",MediaLocation="https://media.cnn.com/api/v1/images/stellar/prod/181115180453-01-mars-best-moments-mars-globe-valles-marineris-enhanced.jpg?q=w_2500,h_1406,x_0,y_0,c_fill/w_1376"},
            //new Photograph{CollectionID=1,Title="Feet on the Ground",Year=DateTime.Parse("2005-09-01"),Location="Vienna, Austria",MediaLocation="https://media.cnn.com/api/v1/images/stellar/prod/181115180453-01-mars-best-moments-mars-globe-valles-marineris-enhanced.jpg?q=w_2500,h_1406,x_0,y_0,c_fill/w_1376"},
            //new Photograph{CollectionID=1,Title="Feet on the Ground",Year=DateTime.Parse("2005-09-01"),Location="Vienna, Austria",MediaLocation="https://media.cnn.com/api/v1/images/stellar/prod/181115180453-01-mars-best-moments-mars-globe-valles-marineris-enhanced.jpg?q=w_2500,h_1406,x_0,y_0,c_fill/w_1376"},
            //new Photograph{CollectionID=1,Title="Feet on the Ground",Year=DateTime.Parse("2005-09-01"),Location="Vienna, Austria",MediaLocation="https://media.cnn.com/api/v1/images/stellar/prod/181115180453-01-mars-best-moments-mars-globe-valles-marineris-enhanced.jpg?q=w_2500,h_1406,x_0,y_0,c_fill/w_1376"},
            //new Photograph{CollectionID=1,Title="Feet on the Ground",Year=DateTime.Parse("2005-09-01"),Location="Vienna, Austria",MediaLocation="https://media.cnn.com/api/v1/images/stellar/prod/181115180453-01-mars-best-moments-mars-globe-valles-marineris-enhanced.jpg?q=w_2500,h_1406,x_0,y_0,c_fill/w_1376"},
            //new Photograph{CollectionID=1,Title="Feet on the Ground",Year=DateTime.Parse("2005-09-01"),Location="Vienna, Austria",MediaLocation="https://media.cnn.com/api/v1/images/stellar/prod/181115180453-01-mars-best-moments-mars-globe-valles-marineris-enhanced.jpg?q=w_2500,h_1406,x_0,y_0,c_fill/w_1376"},
            //new Photograph{CollectionID=1,Title="Feet on the Ground",Year=DateTime.Parse("2005-09-01"),Location="Vienna, Austria",MediaLocation="https://media.cnn.com/api/v1/images/stellar/prod/181115180453-01-mars-best-moments-mars-globe-valles-marineris-enhanced.jpg?q=w_2500,h_1406,x_0,y_0,c_fill/w_1376"},
            //new Photograph{CollectionID=1,Title="Feet on the Ground",Year=DateTime.Parse("2005-09-01"),Location="Vienna, Austria",MediaLocation="https://media.cnn.com/api/v1/images/stellar/prod/181115180453-01-mars-best-moments-mars-globe-valles-marineris-enhanced.jpg?q=w_2500,h_1406,x_0,y_0,c_fill/w_1376"},
            //new Photograph{CollectionID=1,Title="Feet on the Ground",Year=DateTime.Parse("2005-09-01"),Location="Vienna, Austria",MediaLocation="https://media.cnn.com/api/v1/images/stellar/prod/181115180453-01-mars-best-moments-mars-globe-valles-marineris-enhanced.jpg?q=w_2500,h_1406,x_0,y_0,c_fill/w_1376"},
            //new Photograph{CollectionID=1,Title="Feet on the Ground",Year=DateTime.Parse("2005-09-01"),Location="Vienna, Austria",MediaLocation="https://media.cnn.com/api/v1/images/stellar/prod/181115180453-01-mars-best-moments-mars-globe-valles-marineris-enhanced.jpg?q=w_2500,h_1406,x_0,y_0,c_fill/w_1376"},
            //new Photograph{CollectionID=1,Title="Feet on the Ground",Year=DateTime.Parse("2005-09-01"),Location="Vienna, Austria",MediaLocation="https://media.cnn.com/api/v1/images/stellar/prod/181115180453-01-mars-best-moments-mars-globe-valles-marineris-enhanced.jpg?q=w_2500,h_1406,x_0,y_0,c_fill/w_1376"},
            //new Photograph{CollectionID=1,Title="Feet on the Ground",Year=DateTime.Parse("2005-09-01"),Location="Vienna, Austria",MediaLocation="https://media.cnn.com/api/v1/images/stellar/prod/181115180453-01-mars-best-moments-mars-globe-valles-marineris-enhanced.jpg?q=w_2500,h_1406,x_0,y_0,c_fill/w_1376"},
            //new Photograph{CollectionID=1,Title="Feet on the Ground",Year=DateTime.Parse("2005-09-01"),Location="Vienna, Austria",MediaLocation="https://media.cnn.com/api/v1/images/stellar/prod/181115180453-01-mars-best-moments-mars-globe-valles-marineris-enhanced.jpg?q=w_2500,h_1406,x_0,y_0,c_fill/w_1376"},
            //new Photograph{CollectionID=1,Title="Feet on the Ground",Year=DateTime.Parse("2005-09-01"),Location="Vienna, Austria",MediaLocation="https://media.cnn.com/api/v1/images/stellar/prod/181115180453-01-mars-best-moments-mars-globe-valles-marineris-enhanced.jpg?q=w_2500,h_1406,x_0,y_0,c_fill/w_1376"},
            //new Photograph{CollectionID=1,Title="Feet on the Ground",Year=DateTime.Parse("2005-09-01"),Location="Vienna, Austria",MediaLocation="https://media.cnn.com/api/v1/images/stellar/prod/181115180453-01-mars-best-moments-mars-globe-valles-marineris-enhanced.jpg?q=w_2500,h_1406,x_0,y_0,c_fill/w_1376"},
            //new Photograph{CollectionID=1,Title="Feet on the Ground",Year=DateTime.Parse("2005-09-01"),Location="Vienna, Austria",MediaLocation="https://media.cnn.com/api/v1/images/stellar/prod/181115180453-01-mars-best-moments-mars-globe-valles-marineris-enhanced.jpg?q=w_2500,h_1406,x_0,y_0,c_fill/w_1376"},
            //new Photograph{CollectionID=1,Title="Feet on the Ground",Year=DateTime.Parse("2005-09-01"),Location="Vienna, Austria",MediaLocation="https://media.cnn.com/api/v1/images/stellar/prod/181115180453-01-mars-best-moments-mars-globe-valles-marineris-enhanced.jpg?q=w_2500,h_1406,x_0,y_0,c_fill/w_1376"},
            //new Photograph{CollectionID=1,Title="Feet on the Ground",Year=DateTime.Parse("2005-09-01"),Location="Vienna, Austria",MediaLocation="https://media.cnn.com/api/v1/images/stellar/prod/181115180453-01-mars-best-moments-mars-globe-valles-marineris-enhanced.jpg?q=w_2500,h_1406,x_0,y_0,c_fill/w_1376"},
            //new Photograph{CollectionID=1,Title="Feet on the Ground",Year=DateTime.Parse("2005-09-01"),Location="Vienna, Austria",MediaLocation="https://media.cnn.com/api/v1/images/stellar/prod/181115180453-01-mars-best-moments-mars-globe-valles-marineris-enhanced.jpg?q=w_2500,h_1406,x_0,y_0,c_fill/w_1376"},
            //};
            //photographs.ForEach(p => context.Photographs.Add(p));
            //context.SaveChanges();
            base.Seed(context);
        }
    }
}

