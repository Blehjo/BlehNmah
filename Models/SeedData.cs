using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using RazorPagesBlehNmah.Models;
using System.Diagnostics;
using RazorPagesBlehNmah.Data;
using Microsoft.EntityFrameworkCore;

namespace RazorPagesBlehNmah.Models;

	public static class SeedData 
	{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new RazorPagesGalleryContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<RazorPagesGalleryContext>>()))
        {
            if (context == null || context.Collection == null || context.Painting == null || context.Photograph == null)
            {
                throw new ArgumentNullException("Null RazorPagesGalleryContext");
            }

            if (context.Collection.Any())
            {
                return;   // DB has been seeded
            }

            //const string V = "https://news.artnet.com/app/news-upload/2019/04/PK-Ad-Parnassum-1932-copy.jpg";
            context.Collection.AddRange(
                new Collection { CollectionName = "Kings", CoverImage = "https://i.imgur.com/ijeK4AL.jpg", Description = "Study of Fulani and the influence of the Fulani people on west Africa. Masks begin to be used more in my art. A fascination begins on how people use masks to tap into different egos.", Year = DateTime.Parse("2005-09-01") },
                new Collection { CollectionName = "Masks", CoverImage = "https://i.imgur.com/6xYybdH.jpg", Description = "Full on study of masks and how it's much more than hiding who people are. Masks are used to become different parts of ourselves and communicate with people who feel the same as us.", Year = DateTime.Parse("2005-09-01") },
                new Collection { CollectionName = "Faces", CoverImage = "https://i.imgur.com/XW3Xqst.jpg", Description = "Were faces the first masks? With no where to hide, we put on faces and convince ourselves we're ready for action. Come and explore some of these notions.", Year = DateTime.Parse("2005-09-01") },
                new Collection { CollectionName = "Animals", CoverImage = "https://i.imgur.com/DesbWBo.jpg", Description = "Animals are some of our first inspirations in art. We look to animals for spiritual connections and tapping into who we aspire to be.", Year = DateTime.Parse("2005-09-01") },
                new Collection { CollectionName = "Portraits", CoverImage = "https://i.imgur.com/2YVJkNM.jpg", Description = "Some of Bleh Nmah's early works. Simply testing out techniques and materials. We begin to see some instances of hiding our everyday face.", Year = DateTime.Parse("2005-09-01") },
                new Collection { CollectionName = "Love", CoverImage = "https://i.imgur.com/c9Z3OCm.jpg", Description = "So much inspiration with the word LOVE. So much motivation. Bleh Nmah created so much art because of Love and will continue to do so. Let's give it up for love.", Year = DateTime.Parse("2005-09-01") },
                new Collection { CollectionName = "Fragments", CoverImage = "https://i.imgur.com/QV0TZoh.jpg", Description = "Inspired by Piet Modrian and Paul Klee. We explore color theory and the emotion that comes with it. We see the experiments and begin to understand how color combinations can evoke feelings.", Year = DateTime.Parse("2005-09-01") },
                new Collection { CollectionName = "Hidden", CoverImage = "https://i.imgur.com/9Il1Fbi.jpg", Description = "Bleh Nmah is a shy person at heart. We see that in this collection 'Hidden.' So many tools out there to help us hide or help us stand out. Depends on how you look at it I guess.", Year = DateTime.Parse("2005-09-01") },
                new Collection { CollectionName = "Prints", CoverImage = "https://i.imgur.com/AchglF9.jpg", Description = "A bit of a slow time to experiment and try out some ideas. If you like to people watch and are open to new ideas. This is the collection for you.", Year = DateTime.Parse("2005-09-01") },
                new Collection { CollectionName = "City", CoverImage = "https://i.imgur.com/O2mvWFE.jpg", Description = "Speaks for itself. This is the city that Bleh Nmah grew up in. The city can make you feel wonderful and horrible at the same time. It's all up to how you approach it. Good luck!", Year = DateTime.Parse("2005-09-01") }
            );
            context.SaveChanges();

            if (context.Painting.Any())
            {
                return;   // DB has been seeded
            }

            context.Painting.AddRange(
                new Painting { CollectionID = 1, Title = "Three Kings", MediaLocation = "https://i.imgur.com/HuJmoct.jpg", Description = "", Year = DateTime.Parse("2018-09-01"), Medium = "Oil Paint, Paper, Chalk, Pastel", Location = "Chicago, Illinois" },
                new Painting { CollectionID = 1, Title = "Heavy is the Crown", MediaLocation = "https://i.imgur.com/ijeK4AL.jpg", Description = "", Year = DateTime.Parse("2020-09-01"), Medium = "Oil Paint, Canvas, Chalk, Pastel", Location = "Chicago, Illinois" },
                new Painting { CollectionID = 1, Title = "Dead Kings", MediaLocation = "https://i.imgur.com/HxNGjRH.jpg", Description = "", Year = DateTime.Parse("2021-09-01"), Medium = "Oil Paint, Canvas", Location = "Chicago, Illinois" },
                new Painting { CollectionID = 2, Title = "The Jungle", MediaLocation = "https://i.imgur.com/f2n2HSs.jpg", Description = "", Year = DateTime.Parse("2018-09-01"), Medium = "Paper, Oil Pastel, Chalk", Location = "Chicago, Illinois" },
                new Painting { CollectionID = 2, Title = "Tribal Fire", MediaLocation = "https://i.imgur.com/s84GFU0.jpg", Description = "", Year = DateTime.Parse("2020-09-01"), Medium = "Canvas, Oil Paint, Oil Pastel, Chalk, Acrylic Paint", Location = "Chicago, Illinois" },
                new Painting { CollectionID = 2, Title = "Masks", MediaLocation = "https://i.imgur.com/6xYybdH.jpg", Description = "", Year = DateTime.Parse("2020-09-01"), Medium = "Canvas, Oil Paint", Location = "Chicago, Illinois" },
                new Painting { CollectionID = 2, Title = "Masks 2", MediaLocation = "https://i.imgur.com/A5W29DK.jpg", Description = "", Year = DateTime.Parse("2018-09-01"), Medium = "Paper, Oil Pastel, Chalk, Oil Paint", Location = "Chicago, Illinois" },
                new Painting { CollectionID = 3, Title = "Against the World", MediaLocation = "https://i.imgur.com/eWJvRNj.jpg", Description = "", Year = DateTime.Parse("2018-09-01"), Medium = "Paper, Oil Paint, Acrylic, Oil Pastel, Chalk, Foil, Papier Maché", Location = "Chicago, Illinois" },
                new Painting { CollectionID = 3, Title = "Buildings", MediaLocation = "https://i.imgur.com/xz8Nrzp.jpg", Description = "", Year = DateTime.Parse("2020-09-01"), Medium = "Paper, Oil Paint, Oil Pastel, Oil Stick", Location = "Chicago, Illinois" },
                new Painting { CollectionID = 3, Title = "Self-Portrait 3", MediaLocation = "https://i.imgur.com/XW3Xqst.jpg", Description = "", Year = DateTime.Parse("2019-09-01"), Medium = "Sand Paper, Oil Paint, Oil Pastel, Chalk ", Location = "Chicago, Illinois" },
                new Painting { CollectionID = 3, Title = "Self-Portrait 4", MediaLocation = "https://i.imgur.com/5cIWqD0.jpg", Description = "", Year = DateTime.Parse("2020-09-01"), Medium = "Sand Paper, Chalk, Oil Pastel, Oil Stick", Location = "Chicago, Illinois" },
                new Painting { CollectionID = 4, Title = "Monkeys", MediaLocation = "https://i.imgur.com/wjo18wm.jpg", Description = "", Year = DateTime.Parse("2019-09-01"), Medium = "Oil Paint, Paper", Location = "Chicago, Illinois" },
                new Painting { CollectionID = 4, Title = "Hidden Owl", MediaLocation = "https://i.imgur.com/1QhPUit.jpg", Description = "", Year = DateTime.Parse("2019-09-01"), Medium = "Oil Paint, Paper", Location = "Chicago, Illinois" },
                new Painting { CollectionID = 4, Title = "Peacock", MediaLocation = "https://i.imgur.com/Qh99OUd.jpg", Description = "", Year = DateTime.Parse("2017-09-01"), Medium = "Chalk, Paper", Location = "Chicago, Illinois" },
                new Painting { CollectionID = 4, Title = "Jones", MediaLocation = "https://i.imgur.com/DesbWBo.jpg", Description = "", Year = DateTime.Parse("2019-09-01"), Medium = "Oil Paint, Paper", Location = "Chicago, Illinois" },
                new Painting { CollectionID = 5, Title = "Blur", MediaLocation = "https://i.imgur.com/KqUXpDf.jpg", Description = "", Year = DateTime.Parse("2018-09-01"), Medium = "Chalk, Paper", Location = "Chicago, Illinois" },
                new Painting { CollectionID = 5, Title = "Peacock", MediaLocation = "https://i.imgur.com/0iB3VQQ.jpg", Description = "", Year = DateTime.Parse("2018-09-01"), Medium = "Chalk, Paper", Location = "Chicago, Illinois" },
                new Painting { CollectionID = 5, Title = "Badu", MediaLocation = "https://i.imgur.com/efIWToz.jpg", Description = "", Year = DateTime.Parse("2018-09-01"), Medium = "Chalk, Paper", Location = "Chicago, Illinois" },
                new Painting { CollectionID = 5, Title = "Eve", MediaLocation = "https://i.imgur.com/w74hIqv.jpg", Description = "", Year = DateTime.Parse("2018-09-01"), Medium = "Chalk, Paper", Location = "Chicago, Illinois" },
                new Painting { CollectionID = 5, Title = "Eyes", MediaLocation = "https://i.imgur.com/2YVJkNM.jpg", Description = "", Year = DateTime.Parse("2018-09-01"), Medium = "Chalk, Paper", Location = "Chicago, Illinois" },
                new Painting { CollectionID = 5, Title = "Purse", MediaLocation = "https://i.imgur.com/Rg4Guvx.jpg", Description = "", Year = DateTime.Parse("2018-09-01"), Medium = "Chalk, Paper", Location = "Chicago, Illinois" },
                new Painting { CollectionID = 5, Title = "Neck", MediaLocation = "https://i.imgur.com/x3zHSsz.jpg", Description = "", Year = DateTime.Parse("2018-09-01"), Medium = "Chalk, Paper", Location = "Chicago, Illinois" },
                new Painting { CollectionID = 5, Title = "Jacket", MediaLocation = "https://i.imgur.com/318GreR.jpg", Description = "", Year = DateTime.Parse("2018-09-01"), Medium = "Chalk, Paper", Location = "Chicago, Illinois" },
                new Painting { CollectionID = 6, Title = "Nmah Nmah's Boy", MediaLocation = "https://i.imgur.com/H74LHjK.jpg", Description = "", Year = DateTime.Parse("2018-09-01"), Medium = "Chalk, Paper", Location = "Chicago, Illinois" },
                new Painting { CollectionID = 6, Title = "Nmah Nmah's Boy", MediaLocation = "https://i.imgur.com/H74LHjK.jpg", Description = "", Year = DateTime.Parse("2018-09-01"), Medium = "Chalk, Paper", Location = "Chicago, Illinois" },
                new Painting { CollectionID = 6, Title = "Three Wise Men", MediaLocation = "https://i.imgur.com/ez0dp2O.jpg", Description = "", Year = DateTime.Parse("2018-09-01"), Medium = "Chalk, Paper", Location = "Chicago, Illinois" },
                new Painting { CollectionID = 6, Title = "Love", MediaLocation = "https://i.imgur.com/r6QnXbF.jpg", Description = "", Year = DateTime.Parse("2018-09-01"), Medium = "Chalk, Paper", Location = "Chicago, Illinois" },
                new Painting { CollectionID = 6, Title = "Pioneers", MediaLocation = "https://i.imgur.com/c9Z3OCm.jpg", Description = "", Year = DateTime.Parse("2018-09-01"), Medium = "Chalk, Paper", Location = "Chicago, Illinois" },
                new Painting { CollectionID = 6, Title = "Secret Lovers", MediaLocation = "https://i.imgur.com/pdm8osi.jpg", Description = "", Year = DateTime.Parse("2018-09-01"), Medium = "Chalk, Paper", Location = "Chicago, Illinois" },
                new Painting { CollectionID = 7, Title = "Fragments", MediaLocation = "https://i.imgur.com/2gCfHFW.jpg", Description = "", Year = DateTime.Parse("2018-09-01"), Medium = "Chalk, Paper", Location = "Chicago, Illinois" },
                new Painting { CollectionID = 7, Title = "Fragments 2", MediaLocation = "https://i.imgur.com/t4ALv5I.jpg", Description = "", Year = DateTime.Parse("2018-09-01"), Medium = "Chalk, Paper", Location = "Chicago, Illinois" },
                new Painting { CollectionID = 7, Title = "Fragments 3", MediaLocation = "https://i.imgur.com/QV0TZoh.jpg", Description = "", Year = DateTime.Parse("2018-09-01"), Medium = "Chalk, Paper", Location = "Chicago, Illinois" },
                new Painting { CollectionID = 7, Title = "Fragments 4", MediaLocation = "https://i.imgur.com/DV88QRm.jpg", Description = "", Year = DateTime.Parse("2018-09-01"), Medium = "Chalk, Paper", Location = "Chicago, Illinois" },
                new Painting { CollectionID = 7, Title = "The kids are losing their minds", MediaLocation = "https://i.imgur.com/bJBaDTF.jpg", Description = "", Year = DateTime.Parse("2018-09-01"), Medium = "Chalk, Paper", Location = "Chicago, Illinois" },
                new Painting { CollectionID = 7, Title = "Sad Eyes", MediaLocation = "https://i.imgur.com/x14LH9Y.jpg", Description = "", Year = DateTime.Parse("2018-09-01"), Medium = "Chalk, Paper", Location = "Chicago, Illinois" },
                new Painting { CollectionID = 7, Title = "Urban Figures", MediaLocation = "https://i.imgur.com/m9nmufe.jpg", Description = "", Year = DateTime.Parse("2018-09-01"), Medium = "Chalk, Paper", Location = "Chicago, Illinois" },
                new Painting { CollectionID = 7, Title = "Ascending Figure", MediaLocation = "https://i.imgur.com/nZCKF3o.jpg", Description = "", Year = DateTime.Parse("2018-09-01"), Medium = "Chalk, Paper", Location = "Chicago, Illinois" },
                new Painting { CollectionID = 8, Title = "Star People", MediaLocation = "https://i.imgur.com/tke2yx4.jpg", Description = "", Year = DateTime.Parse("2018-09-01"), Medium = "Chalk, Paper", Location = "Chicago, Illinois" },
                new Painting { CollectionID = 10, Title = "Stuck in the city", MediaLocation = "https://i.imgur.com/18qMbhe.jpg", Description = "", Year = DateTime.Parse("2018-09-01"), Medium = "Chalk, Paper", Location = "Chicago, Illinois" },
                new Painting { CollectionID = 7, Title = "Down, but never out", MediaLocation = "https://i.imgur.com/i4WE292.jpg", Description = "", Year = DateTime.Parse("2018-09-01"), Medium = "Chalk, Paper", Location = "Chicago, Illinois" },
                new Painting { CollectionID = 10, Title = "City Slickers", MediaLocation = "https://i.imgur.com/2E31Osn.jpg", Description = "", Year = DateTime.Parse("2018-09-01"), Medium = "Chalk, Paper", Location = "Chicago, Illinois" },
                new Painting { CollectionID = 6, Title = "Hidden Love", MediaLocation = "https://i.imgur.com/9Il1Fbi.jpg", Description = "", Year = DateTime.Parse("2018-09-01"), Medium = "Chalk, Paper", Location = "Chicago, Illinois" },
                new Painting { CollectionID = 9, Title = "Print 1", MediaLocation = "https://i.imgur.com/aX6EgSZ.jpg", Description = "", Year = DateTime.Parse("2018-09-01"), Medium = "Chalk, Paper", Location = "Chicago, Illinois" },
                new Painting { CollectionID = 9, Title = "Print 2", MediaLocation = "https://i.imgur.com/g7aqfDg.jpg", Description = "", Year = DateTime.Parse("2018-09-01"), Medium = "Chalk, Paper", Location = "Chicago, Illinois" },
                new Painting { CollectionID = 9, Title = "Print 3", MediaLocation = "https://i.imgur.com/OYueUbI.jpg", Description = "", Year = DateTime.Parse("2018-09-01"), Medium = "Chalk, Paper", Location = "Chicago, Illinois" },
                new Painting { CollectionID = 9, Title = "Print 4", MediaLocation = "https://i.imgur.com/u3BP1Es.jpg", Description = "", Year = DateTime.Parse("2018-09-01"), Medium = "Chalk, Paper", Location = "Chicago, Illinois" },
                new Painting { CollectionID = 9, Title = "Print 5", MediaLocation = "https://i.imgur.com/0zC38o9.jpg", Description = "", Year = DateTime.Parse("2018-09-01"), Medium = "Chalk, Paper", Location = "Chicago, Illinois" },
                new Painting { CollectionID = 9, Title = "Print 6", MediaLocation = "https://i.imgur.com/AchglF9.jpg", Description = "", Year = DateTime.Parse("2018-09-01"), Medium = "Chalk, Paper", Location = "Chicago, Illinois" },
                new Painting { CollectionID = 9, Title = "Print 7", MediaLocation = "https://i.imgur.com/o9EBHty.jpg", Description = "", Year = DateTime.Parse("2018-09-01"), Medium = "Chalk, Paper", Location = "Chicago, Illinois" },
                new Painting { CollectionID = 9, Title = "Print 8", MediaLocation = "https://i.imgur.com/BPThcCQ.jpg", Description = "", Year = DateTime.Parse("2018-09-01"), Medium = "Chalk, Paper", Location = "Chicago, Illinois" },
                new Painting { CollectionID = 9, Title = "Print 9", MediaLocation = "https://i.imgur.com/v3viNdd.jpg", Description = "", Year = DateTime.Parse("2018-09-01"), Medium = "Chalk, Paper", Location = "Chicago, Illinois" },
                new Painting { CollectionID = 3, Title = "The round table", MediaLocation = "https://i.imgur.com/tiW0qSX.jpg", Description = "", Year = DateTime.Parse("2018-09-01"), Medium = "Chalk, Paper", Location = "Chicago, Illinois" },
                new Painting { CollectionID = 10, Title = "Sunnyside", MediaLocation = "https://i.imgur.com/O2mvWFE.jpg", Description = "", Year = DateTime.Parse("2018-09-01"), Medium = "Chalk, Paper", Location = "Chicago, Illinois" },
                new Painting { CollectionID = 3, Title = "Friends", MediaLocation = "https://i.imgur.com/3ykA5Wa.jpg", Description = "", Year = DateTime.Parse("2018-09-01"), Medium = "Chalk, Paper", Location = "Chicago, Illinois" }
            );
            context.SaveChanges();

            if (context.Photograph.Any())
            {
                return;   // DB has been seeded
            }

            context.Photograph.AddRange(
                new Photograph { CollectionID = 10, Title = "Statues in the garden", Description = "", Year = DateTime.Parse("2021-09-07"), Location = "Chicago, Illinois", MediaLocation = "https://i.imgur.com/fHP6ZfJ.jpg" },
                new Photograph { CollectionID = 10, Title = "Statues reflection", Description = "", Year = DateTime.Parse("2021-09-07"), Location = "Chicago, Illinois", MediaLocation = "https://i.imgur.com/31kPKHX.jpg" },
                new Photograph { CollectionID = 10, Title = "Statues' reflections", Description = "", Year = DateTime.Parse("2021-09-07"), Location = "Chicago, Illinois", MediaLocation = "https://i.imgur.com/PzdXe5c.jpg" },
                new Photograph { CollectionID = 10, Title = "Sedona cliffs", Description = "", Year = DateTime.Parse("2021-09-07"), Location = "Sedona, Arizona", MediaLocation = "https://i.imgur.com/yXYoEuN.jpg" },
                new Photograph { CollectionID = 10, Title = "Sedona during noon", Description = "", Year = DateTime.Parse("2021-09-07"), Location = "Sedona, Arizona", MediaLocation = "https://i.imgur.com/GRPmeN5.jpg" },
                new Photograph { CollectionID = 10, Title = "Sedona landscape", Description = "", Year = DateTime.Parse("2021-09-07"), Location = "Sedona, Arizona", MediaLocation = "https://i.imgur.com/CNikcPi.jpg" },
                new Photograph { CollectionID = 10, Title = "Sedona landscape 2", Description = "", Year = DateTime.Parse("2021-09-07"), Location = "Sedona, Location", MediaLocation = "https://i.imgur.com/KlsbX3h.jpg" },
                new Photograph { CollectionID = 10, Title = "Sedona landscape 3", Description = "", Year = DateTime.Parse("2021-09-07"), Location = "Sedona, Location", MediaLocation = "https://i.imgur.com/mczIgi4.jpg" },
                new Photograph { CollectionID = 10, Title = "Sedona landscape 4", Description = "", Year = DateTime.Parse("2021-09-07"), Location = "Sedona, Location", MediaLocation = "https://i.imgur.com/h1vHXBY.jpg" },
                new Photograph { CollectionID = 11, Title = "Bahaii Temple face", Description = "", Year = DateTime.Parse("2020-08-01"), Location = "Wilmette, Illinois", MediaLocation = "https://i.imgur.com/f1Mu1M8.jpg" },
                new Photograph { CollectionID = 11, Title = "Bahaii Temple", Description = "", Year = DateTime.Parse("2020-08-01"), Location = "Wilmette, Illinois", MediaLocation = "https://i.imgur.com/DRRzJcz.jpg" },
                new Photograph { CollectionID = 11, Title = "Bahaii Temple 2", Description = "", Year = DateTime.Parse("2020-08-01"), Location = "Wilmette, Illinois", MediaLocation = "https://i.imgur.com/CN5iIO8.jpg" },
                new Photograph { CollectionID = 11, Title = "Bahaii Temple 3", Description = "", Year = DateTime.Parse("2020-08-01"), Location = "Wilmette, Illinois", MediaLocation = "https://i.imgur.com/LI90B8L.jpg" },
                new Photograph { CollectionID = 11, Title = "Bahaii Temple 4", Description = "", Year = DateTime.Parse("2020-08-01"), Location = "Wilmette, Illinois", MediaLocation = "https://i.imgur.com/V8z8TVX.jpg" },
                new Photograph { CollectionID = 12, Title = "Dominica volcanic environment", Description = "", Year = DateTime.Parse("2021-08-06"), Location = "Dominica", MediaLocation = "https://i.imgur.com/bRPtmyR.jpg" },
                new Photograph { CollectionID = 12, Title = "Dominica Sauna", Description = "", Year = DateTime.Parse("2021-08-06"), Location = "Dominica", MediaLocation = "https://i.imgur.com/6AUAK8K.jpg" },
                new Photograph { CollectionID = 12, Title = "Mountain face", Description = "", Year = DateTime.Parse("2021-08-06"), Location = "Dominica", MediaLocation = "https://i.imgur.com/7BFxYZG.jpg" },
                new Photograph { CollectionID = 12, Title = "Star wars", Description = "", Year = DateTime.Parse("2021-08-06"), Location = "Dominica", MediaLocation = "https://i.imgur.com/3muZj6f.jpg" },
                new Photograph { CollectionID = 12, Title = "Star wars 2", Description = "", Year = DateTime.Parse("2021-08-06"), Location = "Dominica", MediaLocation = "https://i.imgur.com/6J6dMxc.jpg" },
                new Photograph { CollectionID = 12, Title = "Dominica mountains", Description = "", Year = DateTime.Parse("2021-08-06"), Location = "Dominica", MediaLocation = "https://i.imgur.com/cmiJRib.jpg" },
                new Photograph { CollectionID = 12, Title = "Dominica mountains 2", Description = "", Year = DateTime.Parse("2021-08-06"), Location = "Dominica", MediaLocation = "https://i.imgur.com/1hjJV59.jpg" },
                new Photograph { CollectionID = 12, Title = "Dominica mountains 3", Description = "", Year = DateTime.Parse("2021-08-06"), Location = "Dominica", MediaLocation = "https://i.imgur.com/PrKhNgQ.jpg" },
                new Photograph { CollectionID = 12, Title = "Cloudy hour", Description = "", Year = DateTime.Parse("2021-08-06"), Location = "Dominica", MediaLocation = "https://i.imgur.com/j3dryRQ.jpg" },
                new Photograph { CollectionID = 12, Title = "Closed off beach", Description = "", Year = DateTime.Parse("2021-08-06"), Location = "Dominica", MediaLocation = "https://i.imgur.com/AiuTe8Y.jpg" },
                new Photograph { CollectionID = 12, Title = "Golden hour", Description = "", Year = DateTime.Parse("2021-08-06"), Location = "Dominica", MediaLocation = "https://i.imgur.com/JK3K6Me.jpg" },
                new Photograph { CollectionID = 12, Title = "Shipwreck", Description = "", Year = DateTime.Parse("2021-08-06"), Location = "Dominica", MediaLocation = "https://i.imgur.com/1GJf5st.jpg" },
                new Photograph { CollectionID = 12, Title = "Sulfur Sauna", Description = "", Year = DateTime.Parse("2021-08-06"), Location = "Dominica", MediaLocation = "https://i.imgur.com/gApg84x.jpg" },
                new Photograph { CollectionID = 12, Title = "Sulfur Sauna 2", Description = "", Year = DateTime.Parse("2021-08-06"), Location = "Dominica", MediaLocation = "https://i.imgur.com/ILfEcrD.jpg" },
                new Photograph { CollectionID = 12, Title = "Jungle", Description = "", Year = DateTime.Parse("2021-08-06"), Location = "Dominica", MediaLocation = "https://i.imgur.com/eprM5Oc.jpg" },
                new Photograph { CollectionID = 12, Title = "Sunset in the ocean", Description = "", Year = DateTime.Parse("2021-08-06"), Location = "Dominica", MediaLocation = "https://i.imgur.com/Dspkboa.jpg" },
                new Photograph { CollectionID = 13, Title = "NBC", Description = "", Year = DateTime.Parse("2018-10-13"), Location = "Austin, Texas", MediaLocation = "https://i.imgur.com/LwXY8W9.jpg" },
                new Photograph { CollectionID = 13, Title = "Peacock", Description = "", Year = DateTime.Parse("2018-10-13"), Location = "Tanzania", MediaLocation = "https://i.imgur.com/QbqRzsG.jpg" },
                new Photograph { CollectionID = 14, Title = "1", Description = "", Year = DateTime.Parse("2018-09-13"), Location = "Wicker Park, Chicago", MediaLocation = "https://i.imgur.com/9RzgMza.jpg" },
                new Photograph { CollectionID = 14, Title = "2", Description = "", Year = DateTime.Parse("2018-09-13"), Location = "Wicker Park, Chicago", MediaLocation = "https://i.imgur.com/erjnmAg.jpg" },
                new Photograph { CollectionID = 14, Title = "3", Description = "", Year = DateTime.Parse("2018-09-13"), Location = "Wicker Park, Chicago", MediaLocation = "https://i.imgur.com/bwLNCMN.jpg" },
                new Photograph { CollectionID = 14, Title = "4", Description = "", Year = DateTime.Parse("2018-09-13"), Location = "Wicker Park, Chicago", MediaLocation = "https://i.imgur.com/rCU6mkP.jpg" },
                new Photograph { CollectionID = 14, Title = "5", Description = "", Year = DateTime.Parse("2018-09-13"), Location = "Wicker Park, Chicago", MediaLocation = "https://i.imgur.com/ox4kHP9.jpg" },
                new Photograph { CollectionID = 14, Title = "6", Description = "", Year = DateTime.Parse("2018-09-13"), Location = "Wicker Park, Chicago", MediaLocation = "https://i.imgur.com/HDAIlie.jpg" },
                new Photograph { CollectionID = 14, Title = "7", Description = "", Year = DateTime.Parse("2018-09-13"), Location = "Wicker Park, Chicago", MediaLocation = "https://i.imgur.com/ry3n3kF.jpg" },
                new Photograph { CollectionID = 14, Title = "8", Description = "", Year = DateTime.Parse("2018-09-13"), Location = "Wicker Park, Chicago", MediaLocation = "https://i.imgur.com/ry3n3kF.jpg" },
                new Photograph { CollectionID = 14, Title = "9", Description = "", Year = DateTime.Parse("2018-09-13"), Location = "Wicker Park, Chicago", MediaLocation = "https://i.imgur.com/rpOPSKq.jpg" },
                new Photograph { CollectionID = 14, Title = "10", Description = "", Year = DateTime.Parse("2018-09-13"), Location = "Wicker Park, Chicago", MediaLocation = "https://i.imgur.com/dYTirol.jpg" },
                new Photograph { CollectionID = 14, Title = "11", Description = "", Year = DateTime.Parse("2018-09-13"), Location = "Wicker Park, Chicago", MediaLocation = "https://i.imgur.com/rSnKxZi.jpg" },
                new Photograph { CollectionID = 14, Title = "12", Description = "", Year = DateTime.Parse("2018-09-13"), Location = "Wicker Park, Chicago", MediaLocation = "https://i.imgur.com/JQmAyhX.jpg" },
                new Photograph { CollectionID = 14, Title = "13", Description = "", Year = DateTime.Parse("2018-09-13"), Location = "Wicker Park, Chicago", MediaLocation = "https://i.imgur.com/CPK7E3f.jpg" },
                new Photograph { CollectionID = 14, Title = "14", Description = "", Year = DateTime.Parse("2018-09-13"), Location = "Wicker Park, Chicago", MediaLocation = "https://i.imgur.com/j5iXbBH.jpg" },
                new Photograph { CollectionID = 14, Title = "15", Description = "", Year = DateTime.Parse("2018-09-13"), Location = "Wicker Park, Chicago", MediaLocation = "https://i.imgur.com/3b6QbcF.jpg" },
                new Photograph { CollectionID = 15, Title = "Lights 1", Description = "", Year = DateTime.Parse("2018-09-13"), Location = "Hyde Park, Chicago", MediaLocation = "https://i.imgur.com/ceyA482.jpg" },
                new Photograph { CollectionID = 15, Title = "Lights 2", Description = "", Year = DateTime.Parse("2018-09-13"), Location = "Hyde Park, Chicago", MediaLocation = "https://i.imgur.com/8hs8fF3.jpg" },
                new Photograph { CollectionID = 15, Title = "Lights 3", Description = "", Year = DateTime.Parse("2018-09-13"), Location = "Hyde Park, Chicago", MediaLocation = "https://i.imgur.com/O6NclVz.jpg" },
                new Photograph { CollectionID = 15, Title = "Lights 4", Description = "", Year = DateTime.Parse("2018-09-13"), Location = "Hyde Park, Chicago", MediaLocation = "https://i.imgur.com/BwkBrMw.jpg" },
                new Photograph { CollectionID = 15, Title = "Lights 5", Description = "", Year = DateTime.Parse("2018-09-13"), Location = "Hyde Park, Chicago", MediaLocation = "https://i.imgur.com/AKvFShw.jpg" },
                new Photograph { CollectionID = 15, Title = "Lights 6", Description = "", Year = DateTime.Parse("2018-09-13"), Location = "Hyde Park, Chicago", MediaLocation = "https://i.imgur.com/klTzwUM.jpg" },
                new Photograph { CollectionID = 15, Title = "Lights 7", Description = "", Year = DateTime.Parse("2018-09-13"), Location = "Hyde Park, Chicago", MediaLocation = "https://i.imgur.com/cUeKqgM.jpg" },
                new Photograph { CollectionID = 16, Title = "Stolen too?", Description = "", Year = DateTime.Parse("2018-09-13"), Location = "Paris, France", MediaLocation = "https://i.imgur.com/WsUbtP6.jpg" },
                new Photograph { CollectionID = 16, Title = "The city that lived", Description = "", Year = DateTime.Parse("2018-09-13"), Location = "Dresden, Germany", MediaLocation = "https://i.imgur.com/nXN2VTh.jpg" },
                new Photograph { CollectionID = 16, Title = "Highlight", Description = "", Year = DateTime.Parse("2018-09-13"), Location = "Chicago, Illinois", MediaLocation = "https://i.imgur.com/lOUZOrZ.jpg" },
                new Photograph { CollectionID = 16, Title = "Waves", Description = "", Year = DateTime.Parse("2018-09-13"), Location = "Chicago, Illinois", MediaLocation = "https://i.imgur.com/irn9tyC.jpg" },
                new Photograph { CollectionID = 16, Title = "Waves 2", Description = "", Year = DateTime.Parse("2018-09-13"), Location = "Chicago, Illinois", MediaLocation = "https://i.imgur.com/NN8HzDf.jpg" },
                new Photograph { CollectionID = 17, Title = "Shot 1", Description = "", Year = DateTime.Parse("2016-12-15"), Location = "MCA", MediaLocation = "https://i.imgur.com/kcICVjN.jpg" },
                new Photograph { CollectionID = 17, Title = "Shot 2", Description = "", Year = DateTime.Parse("2016-12-15"), Location = "MCA", MediaLocation = "https://i.imgur.com/oPrtU71.jpg" },
                new Photograph { CollectionID = 17, Title = "Shot 3", Description = "", Year = DateTime.Parse("2016-12-15"), Location = "MCA", MediaLocation = "https://i.imgur.com/ePyCoqR.jpg" },
                new Photograph { CollectionID = 17, Title = "Shot 4", Description = "", Year = DateTime.Parse("2016-12-15"), Location = "MCA", MediaLocation = "https://i.imgur.com/phoRbot.jpg" },
                new Photograph { CollectionID = 18, Title = "Mercedes Wagon 1", Description = "", Year = DateTime.Parse("2018-09-13"), Location = "Wicker Park", MediaLocation = "https://i.imgur.com/7izKWAP.jpg" },
                new Photograph { CollectionID = 18, Title = "Mercedes Wagon 2", Description = "", Year = DateTime.Parse("2018-09-13"), Location = "Wicker Park", MediaLocation = "https://i.imgur.com/UA9uVe6.jpg" },
                new Photograph { CollectionID = 18, Title = "Mercedes Wagon 3", Description = "", Year = DateTime.Parse("2018-09-13"), Location = "Wicker Park", MediaLocation = "https://i.imgur.com/o4G2XGB.jpg" },
                new Photograph { CollectionID = 18, Title = "Mercedes Wagon 4", Description = "", Year = DateTime.Parse("2018-09-13"), Location = "Wicker Park", MediaLocation = "https://i.imgur.com/PKX0kA0.jpg" },
                new Photograph { CollectionID = 19, Title = "Friends", Description = "", Year = DateTime.Parse("2018-09-13"), Location = "Smart Museum", MediaLocation = "https://i.imgur.com/DnEEAWN.jpg" },
                new Photograph { CollectionID = 19, Title = "Friends 2", Description = "", Year = DateTime.Parse("2018-09-13"), Location = "Smart Museum", MediaLocation = "https://i.imgur.com/R34Y4HB.jpg" },
                new Photograph { CollectionID = 19, Title = "Monster", Description = "", Year = DateTime.Parse("2018-09-13"), Location = "Smart Museum", MediaLocation = "https://i.imgur.com/p98C5CT.jpg" },
                new Photograph { CollectionID = 19, Title = "Monsters 1", Description = "", Year = DateTime.Parse("2018-09-13"), Location = "Smart Museum", MediaLocation = "https://i.imgur.com/quXUYYg.jpg" },
                new Photograph { CollectionID = 19, Title = "Monsters 2", Description = "", Year = DateTime.Parse("2018-09-13"), Location = "Smart Museum", MediaLocation = "https://i.imgur.com/HtN92Ru.jpg" },
                new Photograph { CollectionID = 20, Title = "The Sun the Moon, and Star", Description = "", Year = DateTime.Parse("2018-09-13"), Location = "Chicago, Illinois", MediaLocation = "https://i.imgur.com/Wd9NLEn.jpg" },
                new Photograph { CollectionID = 20, Title = "The Sun the Moon, and Star", Description = "", Year = DateTime.Parse("2018-09-13"), Location = "Chicago, Illinois", MediaLocation = "https://i.imgur.com/7Nxg9uE.jpg" },
                new Photograph { CollectionID = 21, Title = "Sunset I", Description = "", Year = DateTime.Parse(""), Location = "Tanzania", MediaLocation = "https://i.imgur.com/fD8A1Hn.jpg" },
                new Photograph { CollectionID = 21, Title = "Sunset II", Description = "", Year = DateTime.Parse(""), Location = "Tanzania", MediaLocation = "https://i.imgur.com/KNJssgW.jpg" },
                new Photograph { CollectionID = 21, Title = "Sunset III", Description = "", Year = DateTime.Parse(""), Location = "Tanzania", MediaLocation = "https://i.imgur.com/K8rCgos.jpg" },
                new Photograph { CollectionID = 21, Title = "Sunset IV", Description = "", Year = DateTime.Parse(""), Location = "Tanzania", MediaLocation = "https://i.imgur.com/mbi0oM6.jpg" },
                new Photograph { CollectionID = 21, Title = "Sunset V", Description = "", Year = DateTime.Parse(""), Location = "Tanzania", MediaLocation = "https://i.imgur.com/pHe4RQO.jpg" },
                new Photograph { CollectionID = 21, Title = "Sunset VI", Description = "", Year = DateTime.Parse(""), Location = "Tanzania", MediaLocation = "https://i.imgur.com/hgxLSzW.jpg" },
                new Photograph { CollectionID = 21, Title = "Sunset VII", Description = "", Year = DateTime.Parse(""), Location = "Tanzania", MediaLocation = "https://i.imgur.com/NSOLlE0.jpg" },
                new Photograph { CollectionID = 21, Title = "Sunset VIII", Description = "", Year = DateTime.Parse(""), Location = "Tanzania", MediaLocation = "https://i.imgur.com/AD6m4mF.jpg" },
                new Photograph { CollectionID = 21, Title = "Sunset IX", Description = "", Year = DateTime.Parse(""), Location = "Tanzania", MediaLocation = "https://i.imgur.com/VzgXJgx.jpg" },
                new Photograph { CollectionID = 21, Title = "Sunset X", Description = "", Year = DateTime.Parse(""), Location = "Tanzania", MediaLocation = "https://i.imgur.com/juzL3LN.jpg" },
                new Photograph { CollectionID = 21, Title = "Sunset XI", Description = "", Year = DateTime.Parse(""), Location = "Tanzania", MediaLocation = "https://i.imgur.com/7g69BHq.jpg" },
                new Photograph { CollectionID = 21, Title = "Sunset XII", Description = "", Year = DateTime.Parse(""), Location = "Tanzania", MediaLocation = "https://i.imgur.com/TyJ1nkd.jpg" },
                new Photograph { CollectionID = 21, Title = "Sunset XIII", Description = "", Year = DateTime.Parse(""), Location = "Zanzibar, Tanzania", MediaLocation = "https://i.imgur.com/7vOzCtv.jpg" },
                new Photograph { CollectionID = 21, Title = "Kilimanjaro Boat", Description = "", Year = DateTime.Parse(""), Location = "Tanzania", MediaLocation = "https://i.imgur.com/CzhYtgx.jpg" },
                new Photograph { CollectionID = 21, Title = "Landscape", Description = "", Year = DateTime.Parse(""), Location = "Tanzania", MediaLocation = "https://i.imgur.com/08PhWJb.jpg" },
                new Photograph { CollectionID = 21, Title = "Zebras", Description = "", Year = DateTime.Parse(""), Location = "Tanzania", MediaLocation = "https://i.imgur.com/sLVaVL7.jpg" },
                new Photograph { CollectionID = 21, Title = "Big Cats", Description = "", Year = DateTime.Parse(""), Location = "Tanzania", MediaLocation = "https://i.imgur.com/zAcJNss.jpg" },
                new Photograph { CollectionID = 21, Title = "Resort", Description = "", Year = DateTime.Parse(""), Location = "Tanzania", MediaLocation = "https://i.imgur.com/hZ9hGtx.jpg" },
                new Photograph { CollectionID = 21, Title = "Gas Station", Description = "", Year = DateTime.Parse(""), Location = "Tanzania", MediaLocation = "https://i.imgur.com/NBWs6aw.jpg" },
                new Photograph { CollectionID = 21, Title = "Lioness", Description = "", Year = DateTime.Parse(""), Location = "Tanzania", MediaLocation = "https://i.imgur.com/lRpSijZ.jpg" },
                new Photograph { CollectionID = 21, Title = "Baboon", Description = "", Year = DateTime.Parse(""), Location = "Tanzania", MediaLocation = "https://i.imgur.com/K2AK3LQ.jpg" },
                new Photograph { CollectionID = 21, Title = "Mountain Blur", Description = "", Year = DateTime.Parse(""), Location = "Tanzania", MediaLocation = "https://i.imgur.com/k3HtvcR.jpg" },
                new Photograph { CollectionID = 21, Title = "Lion under the tree", Description = "", Year = DateTime.Parse(""), Location = "Tanzania", MediaLocation = "https://i.imgur.com/q22XLuG.jpg" },
                new Photograph { CollectionID = 21, Title = "Resort II", Description = "", Year = DateTime.Parse(""), Location = "Tanzania", MediaLocation = "https://i.imgur.com/8mJeCRA.jpg" },
                new Photograph { CollectionID = 21, Title = "Lions sleeping", Description = "", Year = DateTime.Parse(""), Location = "Tanzania", MediaLocation = "https://i.imgur.com/dtRNdI8.jpg" },
                new Photograph { CollectionID = 21, Title = "Blurry Boat", Description = "", Year = DateTime.Parse(""), Location = "Tanzania", MediaLocation = "https://i.imgur.com/Hb0F3pp.jpg" },
                new Photograph { CollectionID = 21, Title = "Migration", Description = "", Year = DateTime.Parse(""), Location = "Tanzania", MediaLocation = "https://i.imgur.com/0Mvq5Xk.jpg" },
                new Photograph { CollectionID = 21, Title = "Sails", Description = "", Year = DateTime.Parse(""), Location = "Tanzania", MediaLocation = "https://i.imgur.com/KQa6sNV.jpg" },
                new Photograph { CollectionID = 21, Title = "Elephant", Description = "", Year = DateTime.Parse(""), Location = "Tanzania", MediaLocation = "https://i.imgur.com/5WpvQDV.jpg" },
                new Photograph { CollectionID = 21, Title = "Late night Fishing", Description = "", Year = DateTime.Parse(""), Location = "Tanzania", MediaLocation = "https://i.imgur.com/55GrbwX.jpg" },
                new Photograph { CollectionID = 21, Title = "Resort III", Description = "", Year = DateTime.Parse(""), Location = "Tanzania", MediaLocation = "https://i.imgur.com/aih946k.jpg" },
                new Photograph { CollectionID = 21, Title = "Market", Description = "", Year = DateTime.Parse(""), Location = "Tanzania", MediaLocation = "https://i.imgur.com/LEeDUUh.jpg" },
                new Photograph { CollectionID = 21, Title = "Lionesses in tree", Description = "", Year = DateTime.Parse(""), Location = "Tanzania", MediaLocation = "https://i.imgur.com/6FL4mhV.jpg" },
                new Photograph { CollectionID = 21, Title = "Lake", Description = "", Year = DateTime.Parse(""), Location = "Tanzania", MediaLocation = "https://i.imgur.com/Z1DmW6a.jpg" },
                new Photograph { CollectionID = 21, Title = "Market II", Description = "", Year = DateTime.Parse(""), Location = "Tanzania", MediaLocation = "https://i.imgur.com/Y3LSLtO.jpg" },
                new Photograph { CollectionID = 21, Title = "Palm Tree", Description = "", Year = DateTime.Parse(""), Location = "Tanzania", MediaLocation = "https://i.imgur.com/NaQau1u.jpg" },
                new Photograph { CollectionID = 21, Title = "The block", Description = "", Year = DateTime.Parse(""), Location = "Tanzania", MediaLocation = "https://i.imgur.com/RaXoM4p.jpg" },
                new Photograph { CollectionID = 21, Title = "Giraffe in the distance", Description = "", Year = DateTime.Parse(""), Location = "Tanzania", MediaLocation = "https://i.imgur.com/XtE3qdc.jpg" },
                new Photograph { CollectionID = 21, Title = "Cat nap", Description = "", Year = DateTime.Parse(""), Location = "Tanzania", MediaLocation = "https://i.imgur.com/fQnHxyh.jpg" },
                new Photograph { CollectionID = 21, Title = "Tribes", Description = "", Year = DateTime.Parse(""), Location = "Tanzania", MediaLocation = "https://i.imgur.com/oNuqTOe.jpg" },
                new Photograph { CollectionID = 21, Title = "Mountains", Description = "", Year = DateTime.Parse(""), Location = "Tanzania", MediaLocation = "https://i.imgur.com/ACl7kAx.jpg" },
                new Photograph { CollectionID = 21, Title = "Tribal Ladies", Description = "", Year = DateTime.Parse(""), Location = "Tanzania", MediaLocation = "https://i.imgur.com/EhnHPkP.jpg" },
                new Photograph { CollectionID = 21, Title = "Tribal Ladies II", Description = "", Year = DateTime.Parse(""), Location = "Tanzania", MediaLocation = "https://i.imgur.com/NqzeSiu.jpg" },
                new Photograph { CollectionID = 21, Title = "Tribal Ladies III", Description = "", Year = DateTime.Parse(""), Location = "Tanzania", MediaLocation = "https://i.imgur.com/BEIcwEa.jpg" },
                new Photograph { CollectionID = 21, Title = "Giraffes", Description = "", Year = DateTime.Parse(""), Location = "Tanzania", MediaLocation = "https://i.imgur.com/lh0H3cL.jpg" },
                new Photograph { CollectionID = 21, Title = "Cloudy", Description = "", Year = DateTime.Parse(""), Location = "Tanzania", MediaLocation = "https://i.imgur.com/BgeIKNA.jpg" },
                new Photograph { CollectionID = 21, Title = "Gas Station", Description = "", Year = DateTime.Parse(""), Location = "Tanzania", MediaLocation = "https://i.imgur.com/ZWN2iBx.jpg" },
                new Photograph { CollectionID = 21, Title = "Zebras II", Description = "", Year = DateTime.Parse(""), Location = "Tanzania", MediaLocation = "https://i.imgur.com/YgQgk5K.jpg" },
                new Photograph { CollectionID = 21, Title = "Elephants", Description = "", Year = DateTime.Parse(""), Location = "Tanzania", MediaLocation = "https://i.imgur.com/1qgzTys.jpg" },
                new Photograph { CollectionID = 21, Title = "Sailboat", Description = "", Year = DateTime.Parse(""), Location = "Tanzania", MediaLocation = "https://i.imgur.com/ZbO3OQn.jpg" },
                new Photograph { CollectionID = 21, Title = "Elephant eating", Description = "", Year = DateTime.Parse(""), Location = "Tanzania", MediaLocation = "https://i.imgur.com/2r5nqnh.jpg" },
                new Photograph { CollectionID = 21, Title = "Cat nap II", Description = "", Year = DateTime.Parse(""), Location = "Tanzania", MediaLocation = "https://i.imgur.com/fQO4VTi.jpg" },
                new Photograph { CollectionID = 21, Title = "Cows on the move", Description = "", Year = DateTime.Parse(""), Location = "Tanzania", MediaLocation = "https://i.imgur.com/0uEYybj.jpg" },
                new Photograph { CollectionID = 21, Title = "Cat eyes", Description = "", Year = DateTime.Parse(""), Location = "Tanzania", MediaLocation = "https://i.imgur.com/eOlbglR.jpg" },
                new Photograph { CollectionID = 21, Title = "Lake II", Description = "", Year = DateTime.Parse(""), Location = "Tanzania", MediaLocation = "https://i.imgur.com/ZuRkPh1.jpg" },
                new Photograph { CollectionID = 21, Title = "Field II", Description = "", Year = DateTime.Parse(""), Location = "Tanzania", MediaLocation = "https://i.imgur.com/s8r6BWi.jpg" },
                new Photograph { CollectionID = 21, Title = "Gas Station II", Description = "", Year = DateTime.Parse(""), Location = "Tanzania", MediaLocation = "https://i.imgur.com/MiAoTJd.jpg" },
                new Photograph { CollectionID = 21, Title = "Lake III", Description = "", Year = DateTime.Parse(""), Location = "Tanzania", MediaLocation = "https://i.imgur.com/zWHBNVZ.jpg" },
                new Photograph { CollectionID = 21, Title = "Elephant in the field", Description = "", Year = DateTime.Parse(""), Location = "Tanzania", MediaLocation = "https://i.imgur.com/UjmUyDs.jpg" },
                new Photograph { CollectionID = 21, Title = "Beautiful day", Description = "", Year = DateTime.Parse(""), Location = "Tanzania", MediaLocation = "https://i.imgur.com/sx7O1cc.jpg" },
                new Photograph { CollectionID = 21, Title = "Lone Elephant", Description = "", Year = DateTime.Parse(""), Location = "Tanzania", MediaLocation = "https://i.imgur.com/cGNCmQm.jpg" },
                new Photograph { CollectionID = 21, Title = "Blurry sun", Description = "", Year = DateTime.Parse(""), Location = "Tanzania", MediaLocation = "https://i.imgur.com/fpVKT0V.jpg" },
                new Photograph { CollectionID = 21, Title = "Zebras III", Description = "", Year = DateTime.Parse(""), Location = "Tanzania", MediaLocation = "https://i.imgur.com/tSX7wzV.jpg" },
                new Photograph { CollectionID = 21, Title = "Sailboat POV", Description = "", Year = DateTime.Parse(""), Location = "Tanzania", MediaLocation = "https://i.imgur.com/zK51CAR.jpg" },
                new Photograph { CollectionID = 21, Title = "Sunrise to Sunset", Description = "", Year = DateTime.Parse(""), Location = "Tanzania", MediaLocation = "https://i.imgur.com/D64B9DN.jpg" },
                new Photograph { CollectionID = 21, Title = "Lone Elephant II", Description = "", Year = DateTime.Parse(""), Location = "Tanzania", MediaLocation = "https://i.imgur.com/8fReugx.jpg" },
                new Photograph { CollectionID = 21, Title = "Monkeys in a tree", Description = "", Year = DateTime.Parse(""), Location = "Tanzania", MediaLocation = "https://i.imgur.com/c1VsDOh.jpg" },
                new Photograph { CollectionID = 21, Title = "Tribes II", Description = "", Year = DateTime.Parse(""), Location = "Tanzania", MediaLocation = "https://i.imgur.com/yMPlMCb.jpg" },
                new Photograph { CollectionID = 21, Title = "Field view", Description = "", Year = DateTime.Parse(""), Location = "Tanzania", MediaLocation = "https://i.imgur.com/SuP7vbH.jpg" },
                new Photograph { CollectionID = 21, Title = "Lionesses in the tree II", Description = "", Year = DateTime.Parse(""), Location = "Tanzania", MediaLocation = "https://i.imgur.com/oKkU9Jv.jpg" },
                new Photograph { CollectionID = 21, Title = "Lake IV", Description = "", Year = DateTime.Parse(""), Location = "Tanzania", MediaLocation = "https://i.imgur.com/Yfn4J4L.jpg" },
                new Photograph { CollectionID = 21, Title = "Cat nap III", Description = "", Year = DateTime.Parse(""), Location = "Tanzania", MediaLocation = "https://i.imgur.com/eKnvHKO.jpg" },
                new Photograph { CollectionID = 21, Title = "Field view", Description = "", Year = DateTime.Parse(""), Location = "Tanzania", MediaLocation = "https://i.imgur.com/TfiTzgm.jpg" },
                new Photograph { CollectionID = 21, Title = "Cat nap IV", Description = "", Year = DateTime.Parse(""), Location = "Tanzania", MediaLocation = "https://i.imgur.com/vE3ozYS.jpg" },
                new Photograph { CollectionID = 21, Title = "Palm tree long", Description = "", Year = DateTime.Parse(""), Location = "Tanzania", MediaLocation = "https://i.imgur.com/Rejm0jY.jpg" },
                new Photograph { CollectionID = 21, Title = "Setting sun", Description = "", Year = DateTime.Parse(""), Location = "Tanzania", MediaLocation = "https://i.imgur.com/dhnQ81v.jpg" },
                new Photograph { CollectionID = 21, Title = "Sunrise to sunset II", Description = "", Year = DateTime.Parse(""), Location = "Tanzania", MediaLocation = "https://i.imgur.com/O12IA3l.jpg" },
                new Photograph { CollectionID = 21, Title = "Zebras", Description = "", Year = DateTime.Parse(""), Location = "Tanzania", MediaLocation = "https://i.imgur.com/A1X61L0.jpg" },
                new Photograph { CollectionID = 21, Title = "Cows", Description = "", Year = DateTime.Parse(""), Location = "Tanzania", MediaLocation = "https://i.imgur.com/L8oyjLr.jpg" },
                new Photograph { CollectionID = 21, Title = "Lake V", Description = "", Year = DateTime.Parse(""), Location = "Tanzania", MediaLocation = "https://i.imgur.com/whti7FO.jpg" }
            );
            context.SaveChanges();
        }
    }
}

