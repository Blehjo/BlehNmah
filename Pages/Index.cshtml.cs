﻿using System.Collections.ObjectModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesBlehNmah.Models;

namespace RazorPagesBlehNmah.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }

    public List<Collection> GetCollections()
    {
        List<Collection> collections = new List<Collection>();
        collections.Add(new Collection { CollectionName = "Kings", CoverImage = "https://i.imgur.com/ijeK4AL.jpg", Description = "Study of Fulani and the influence of the Fulani people on west Africa. Masks begin to be used more in my art. A fascination begins on how people use masks to tap into different egos.", Year = DateTime.Parse("2005-09-01") });
        collections.Add(new Collection { CollectionName = "Masks", CoverImage = "https://i.imgur.com/6xYybdH.jpg", Description = "Full on study of masks and how it's much more than hiding who people are. Masks are used to become different parts of ourselves and communicate with people who feel the same as us.", Year = DateTime.Parse("2005-09-01") });
        collections.Add(new Collection { CollectionName = "Faces", CoverImage = "https://i.imgur.com/XW3Xqst.jpg", Description = "Were faces the first masks? With no where to hide, we put on faces and convince ourselves we're ready for action. Come and explore some of these notions.", Year = DateTime.Parse("2005-09-01") });
        collections.Add(new Collection { CollectionName = "Animals", CoverImage = "https://i.imgur.com/DesbWBo.jpg", Description = "Animals are some of our first inspirations in art. We look to animals for spiritual connections and tapping into who we aspire to be.", Year = DateTime.Parse("2005-09-01") });
        collections.Add(new Collection { CollectionName = "Portraits", CoverImage = "https://i.imgur.com/2YVJkNM.jpg", Description = "Some of Bleh Nmah's early works. Simply testing out techniques and materials. We begin to see some instances of hiding our everyday face.", Year = DateTime.Parse("2005-09-01") });
        collections.Add(new Collection { CollectionName = "Love", CoverImage = "https://i.imgur.com/c9Z3OCm.jpg", Description = "So much inspiration with the word LOVE. So much motivation. Bleh Nmah created so much art because of Love and will continue to do so. Let's give it up for love.", Year = DateTime.Parse("2005-09-01") });
        collections.Add(new Collection { CollectionName = "Fragments", CoverImage = "https://i.imgur.com/QV0TZoh.jpg", Description = "Inspired by Piet Modrian and Paul Klee. We explore color theory and the emotion that comes with it. We see the experiments and begin to understand how color combinations can evoke feelings.", Year = DateTime.Parse("2005-09-01") });
        collections.Add(new Collection { CollectionName = "Hidden", CoverImage = "https://i.imgur.com/9Il1Fbi.jpg", Description = "Bleh Nmah is a shy person at heart. We see that in this collection 'Hidden.' So many tools out there to help us hide or help us stand out. Depends on how you look at it I guess.", Year = DateTime.Parse("2005-09-01") });
        collections.Add(new Collection { CollectionName = "Prints", CoverImage = "https://i.imgur.com/AchglF9.jpg", Description = "A bit of a slow time to experiment and try out some ideas. If you like to people watch and are open to new ideas. This is the collection for you.", Year = DateTime.Parse("2005-09-01") });
        collections.Add(new Collection { CollectionName = "City", CoverImage = "https://i.imgur.com/O2mvWFE.jpg", Description = "Speaks for itself. This is the city that Bleh Nmah grew up in. The city can make you feel wonderful and horrible at the same time. It's all up to how you approach it. Good luck!", Year = DateTime.Parse("2005-09-01") });
        return collections;
    }

    public List<Painting> GetPaintings()
    {
        List<Painting> paintings = new List<Painting>();
        paintings.Add(new Painting { CollectionID = 1, Title = "Three Kings", MediaLocation = "https://i.imgur.com/HuJmoct.jpg", Description = "", Year = DateTime.Parse("2018-09-01"), Medium = "Oil Paint, Paper, Chalk, Pastel", Location = "Chicago, Illinois" });
        paintings.Add(new Painting { CollectionID = 1, Title = "Heavy is the Crown", MediaLocation = "https://i.imgur.com/ijeK4AL.jpg", Description = "", Year = DateTime.Parse("2020-09-01"), Medium = "Oil Paint, Canvas, Chalk, Pastel", Location = "Chicago, Illinois" });
        paintings.Add(new Painting { CollectionID = 1, Title = "Dead Kings", MediaLocation = "https://i.imgur.com/HxNGjRH.jpg", Description = "", Year = DateTime.Parse("2021-09-01"), Medium = "Oil Paint, Canvas", Location = "Chicago, Illinois" });
        paintings.Add(new Painting { CollectionID = 2, Title = "The Jungle", MediaLocation = "https://i.imgur.com/f2n2HSs.jpg", Description = "", Year = DateTime.Parse("2018-09-01"), Medium = "Paper, Oil Pastel, Chalk", Location = "Chicago, Illinois" });
        paintings.Add(new Painting { CollectionID = 2, Title = "Tribal Fire", MediaLocation = "https://i.imgur.com/s84GFU0.jpg", Description = "", Year = DateTime.Parse("2020-09-01"), Medium = "Canvas, Oil Paint, Oil Pastel, Chalk, Acrylic Paint", Location = "Chicago, Illinois" });
        paintings.Add(new Painting { CollectionID = 2, Title = "Masks", MediaLocation = "https://i.imgur.com/6xYybdH.jpg", Description = "", Year = DateTime.Parse("2020-09-01"), Medium = "Canvas, Oil Paint", Location = "Chicago, Illinois" });
        paintings.Add(new Painting { CollectionID = 2, Title = "Masks 2", MediaLocation = "https://i.imgur.com/A5W29DK.jpg", Description = "", Year = DateTime.Parse("2018-09-01"), Medium = "Paper, Oil Pastel, Chalk, Oil Paint", Location = "Chicago, Illinois" });
        paintings.Add(new Painting { CollectionID = 3, Title = "Against the World", MediaLocation = "https://i.imgur.com/eWJvRNj.jpg", Description = "", Year = DateTime.Parse("2018-09-01"), Medium = "Paper, Oil Paint, Acrylic, Oil Pastel, Chalk, Foil, Papier Maché", Location = "Chicago, Illinois" });
        paintings.Add(new Painting { CollectionID = 3, Title = "Buildings", MediaLocation = "https://i.imgur.com/xz8Nrzp.jpg", Description = "", Year = DateTime.Parse("2020-09-01"), Medium = "Paper, Oil Paint, Oil Pastel, Oil Stick", Location = "Chicago, Illinois" });
        paintings.Add(new Painting { CollectionID = 3, Title = "Self-Portrait 3", MediaLocation = "https://i.imgur.com/XW3Xqst.jpg", Description = "", Year = DateTime.Parse("2019-09-01"), Medium = "Sand Paper, Oil Paint, Oil Pastel, Chalk ", Location = "Chicago, Illinois" });
        paintings.Add(new Painting { CollectionID = 3, Title = "Self-Portrait 4", MediaLocation = "https://i.imgur.com/5cIWqD0.jpg", Description = "", Year = DateTime.Parse("2020-09-01"), Medium = "Sand Paper, Chalk, Oil Pastel, Oil Stick", Location = "Chicago, Illinois" });
        paintings.Add(new Painting { CollectionID = 4, Title = "Monkeys", MediaLocation = "https://i.imgur.com/wjo18wm.jpg", Description = "", Year = DateTime.Parse("2019-09-01"), Medium = "Oil Paint, Paper", Location = "Chicago, Illinois" });
        paintings.Add(new Painting { CollectionID = 4, Title = "Hidden Owl", MediaLocation = "https://i.imgur.com/1QhPUit.jpg", Description = "", Year = DateTime.Parse("2019-09-01"), Medium = "Oil Paint, Paper", Location = "Chicago, Illinois" });
        paintings.Add(new Painting { CollectionID = 4, Title = "Peacock", MediaLocation = "https://i.imgur.com/Qh99OUd.jpg", Description = "", Year = DateTime.Parse("2017-09-01"), Medium = "Chalk, Paper", Location = "Chicago, Illinois" });
        paintings.Add(new Painting { CollectionID = 4, Title = "Jones", MediaLocation = "https://i.imgur.com/DesbWBo.jpg", Description = "", Year = DateTime.Parse("2019-09-01"), Medium = "Oil Paint, Paper", Location = "Chicago, Illinois" });
        paintings.Add(new Painting { CollectionID = 5, Title = "Blur", MediaLocation = "https://i.imgur.com/KqUXpDf.jpg", Description = "", Year = DateTime.Parse("2018-09-01"), Medium = "Chalk, Paper", Location = "Chicago, Illinois" });
        paintings.Add(new Painting { CollectionID = 5, Title = "Peacock", MediaLocation = "https://i.imgur.com/0iB3VQQ.jpg", Description = "", Year = DateTime.Parse("2018-09-01"), Medium = "Chalk, Paper", Location = "Chicago, Illinois" });
        paintings.Add(new Painting { CollectionID = 5, Title = "Badu", MediaLocation = "https://i.imgur.com/efIWToz.jpg", Description = "", Year = DateTime.Parse("2018-09-01"), Medium = "Chalk, Paper", Location = "Chicago, Illinois" });
        paintings.Add(new Painting { CollectionID = 5, Title = "Eve", MediaLocation = "https://i.imgur.com/w74hIqv.jpg", Description = "", Year = DateTime.Parse("2018-09-01"), Medium = "Chalk, Paper", Location = "Chicago, Illinois" });
        paintings.Add(new Painting { CollectionID = 5, Title = "Eyes", MediaLocation = "https://i.imgur.com/2YVJkNM.jpg", Description = "", Year = DateTime.Parse("2018-09-01"), Medium = "Chalk, Paper", Location = "Chicago, Illinois" });
        paintings.Add(new Painting { CollectionID = 5, Title = "Purse", MediaLocation = "https://i.imgur.com/Rg4Guvx.jpg", Description = "", Year = DateTime.Parse("2018-09-01"), Medium = "Chalk, Paper", Location = "Chicago, Illinois" });
        paintings.Add(new Painting { CollectionID = 5, Title = "Neck", MediaLocation = "https://i.imgur.com/x3zHSsz.jpg", Description = "", Year = DateTime.Parse("2018-09-01"), Medium = "Chalk, Paper", Location = "Chicago, Illinois" });
        paintings.Add(new Painting { CollectionID = 5, Title = "Jacket", MediaLocation = "https://i.imgur.com/318GreR.jpg", Description = "", Year = DateTime.Parse("2018-09-01"), Medium = "Chalk, Paper", Location = "Chicago, Illinois" });
        paintings.Add(new Painting { CollectionID = 6, Title = "Nmah Nmah's Boy", MediaLocation = "https://i.imgur.com/H74LHjK.jpg", Description = "", Year = DateTime.Parse("2018-09-01"), Medium = "Chalk, Paper", Location = "Chicago, Illinois" });
        paintings.Add(new Painting { CollectionID = 6, Title = "Nmah Nmah's Boy", MediaLocation = "https://i.imgur.com/H74LHjK.jpg", Description = "", Year = DateTime.Parse("2018-09-01"), Medium = "Chalk, Paper", Location = "Chicago, Illinois" });
        paintings.Add(new Painting { CollectionID = 6, Title = "Three Wise Men", MediaLocation = "https://i.imgur.com/ez0dp2O.jpg", Description = "", Year = DateTime.Parse("2018-09-01"), Medium = "Chalk, Paper", Location = "Chicago, Illinois" });
        paintings.Add(new Painting { CollectionID = 6, Title = "Love", MediaLocation = "https://i.imgur.com/r6QnXbF.jpg", Description = "", Year = DateTime.Parse("2018-09-01"), Medium = "Chalk, Paper", Location = "Chicago, Illinois" });
        paintings.Add(new Painting { CollectionID = 6, Title = "Pioneers", MediaLocation = "https://i.imgur.com/c9Z3OCm.jpg", Description = "", Year = DateTime.Parse("2018-09-01"), Medium = "Chalk, Paper", Location = "Chicago, Illinois" });
        paintings.Add(new Painting { CollectionID = 6, Title = "Secret Lovers", MediaLocation = "https://i.imgur.com/pdm8osi.jpg", Description = "", Year = DateTime.Parse("2018-09-01"), Medium = "Chalk, Paper", Location = "Chicago, Illinois" });
        paintings.Add(new Painting { CollectionID = 7, Title = "Fragments", MediaLocation = "https://i.imgur.com/2gCfHFW.jpg", Description = "", Year = DateTime.Parse("2018-09-01"), Medium = "Chalk, Paper", Location = "Chicago, Illinois" });
        paintings.Add(new Painting { CollectionID = 7, Title = "Fragments 2", MediaLocation = "https://i.imgur.com/t4ALv5I.jpg", Description = "", Year = DateTime.Parse("2018-09-01"), Medium = "Chalk, Paper", Location = "Chicago, Illinois" });
        paintings.Add(new Painting { CollectionID = 7, Title = "Fragments 3", MediaLocation = "https://i.imgur.com/QV0TZoh.jpg", Description = "", Year = DateTime.Parse("2018-09-01"), Medium = "Chalk, Paper", Location = "Chicago, Illinois" });
        paintings.Add(new Painting { CollectionID = 7, Title = "Fragments 4", MediaLocation = "https://i.imgur.com/DV88QRm.jpg", Description = "", Year = DateTime.Parse("2018-09-01"), Medium = "Chalk, Paper", Location = "Chicago, Illinois" });
        paintings.Add(new Painting { CollectionID = 7, Title = "The kids are losing their minds", MediaLocation = "https://i.imgur.com/bJBaDTF.jpg", Description = "", Year = DateTime.Parse("2018-09-01"), Medium = "Chalk, Paper", Location = "Chicago, Illinois" });
        paintings.Add(new Painting { CollectionID = 7, Title = "Sad Eyes", MediaLocation = "https://i.imgur.com/x14LH9Y.jpg", Description = "", Year = DateTime.Parse("2018-09-01"), Medium = "Chalk, Paper", Location = "Chicago, Illinois" });
        paintings.Add(new Painting { CollectionID = 7, Title = "Urban Figures", MediaLocation = "https://i.imgur.com/m9nmufe.jpg", Description = "", Year = DateTime.Parse("2018-09-01"), Medium = "Chalk, Paper", Location = "Chicago, Illinois" });
        paintings.Add(new Painting { CollectionID = 7, Title = "Ascending Figure", MediaLocation = "https://i.imgur.com/nZCKF3o.jpg", Description = "", Year = DateTime.Parse("2018-09-01"), Medium = "Chalk, Paper", Location = "Chicago, Illinois" });
        paintings.Add(new Painting { CollectionID = 8, Title = "Star People", MediaLocation = "https://i.imgur.com/tke2yx4.jpg", Description = "", Year = DateTime.Parse("2018-09-01"), Medium = "Chalk, Paper", Location = "Chicago, Illinois" });
        paintings.Add(new Painting { CollectionID = 7, Title = "Stuck in the city", MediaLocation = "https://i.imgur.com/18qMbhe.jpg", Description = "", Year = DateTime.Parse("2018-09-01"), Medium = "Chalk, Paper", Location = "Chicago, Illinois" });
        paintings.Add(new Painting { CollectionID = 7, Title = "Down, but never out", MediaLocation = "https://i.imgur.com/i4WE292.jpg", Description = "", Year = DateTime.Parse("2018-09-01"), Medium = "Chalk, Paper", Location = "Chicago, Illinois" });
        paintings.Add(new Painting { CollectionID = 7, Title = "City Slickers", MediaLocation = "https://i.imgur.com/2E31Osn.jpg", Description = "", Year = DateTime.Parse("2018-09-01"), Medium = "Chalk, Paper", Location = "Chicago, Illinois" });
        paintings.Add(new Painting { CollectionID = 7, Title = "Hidden Love", MediaLocation = "https://i.imgur.com/9Il1Fbi.jpg", Description = "", Year = DateTime.Parse("2018-09-01"), Medium = "Chalk, Paper", Location = "Chicago, Illinois" });
        paintings.Add(new Painting { CollectionID = 8, Title = "Print 1", MediaLocation = "https://i.imgur.com/aX6EgSZ.jpg", Description = "", Year = DateTime.Parse("2018-09-01"), Medium = "Chalk, Paper", Location = "Chicago, Illinois" });
        paintings.Add(new Painting { CollectionID = 8, Title = "Print 2", MediaLocation = "https://i.imgur.com/g7aqfDg.jpg", Description = "", Year = DateTime.Parse("2018-09-01"), Medium = "Chalk, Paper", Location = "Chicago, Illinois" });
        paintings.Add(new Painting { CollectionID = 8, Title = "Print 3", MediaLocation = "https://i.imgur.com/OYueUbI.jpg", Description = "", Year = DateTime.Parse("2018-09-01"), Medium = "Chalk, Paper", Location = "Chicago, Illinois" });
        paintings.Add(new Painting { CollectionID = 8, Title = "Print 4", MediaLocation = "https://i.imgur.com/u3BP1Es.jpg", Description = "", Year = DateTime.Parse("2018-09-01"), Medium = "Chalk, Paper", Location = "Chicago, Illinois" });
        paintings.Add(new Painting { CollectionID = 8, Title = "Print 5", MediaLocation = "https://i.imgur.com/0zC38o9.jpg", Description = "", Year = DateTime.Parse("2018-09-01"), Medium = "Chalk, Paper", Location = "Chicago, Illinois" });
        paintings.Add(new Painting { CollectionID = 8, Title = "Print 6", MediaLocation = "https://i.imgur.com/AchglF9.jpg", Description = "", Year = DateTime.Parse("2018-09-01"), Medium = "Chalk, Paper", Location = "Chicago, Illinois" });
        paintings.Add(new Painting { CollectionID = 8, Title = "Print 7", MediaLocation = "https://i.imgur.com/o9EBHty.jpg", Description = "", Year = DateTime.Parse("2018-09-01"), Medium = "Chalk, Paper", Location = "Chicago, Illinois" });
        paintings.Add(new Painting { CollectionID = 8, Title = "Print 8", MediaLocation = "https://i.imgur.com/BPThcCQ.jpg", Description = "", Year = DateTime.Parse("2018-09-01"), Medium = "Chalk, Paper", Location = "Chicago, Illinois" });
        paintings.Add(new Painting { CollectionID = 8, Title = "Print 9", MediaLocation = "https://i.imgur.com/v3viNdd.jpg", Description = "", Year = DateTime.Parse("2018-09-01"), Medium = "Chalk, Paper", Location = "Chicago, Illinois" });
        paintings.Add(new Painting { CollectionID = 9, Title = "The round table", MediaLocation = "https://i.imgur.com/tiW0qSX.jpg", Description = "", Year = DateTime.Parse("2018-09-01"), Medium = "Chalk, Paper", Location = "Chicago, Illinois" });
        paintings.Add(new Painting { CollectionID = 9, Title = "Sunnyside", MediaLocation = "https://i.imgur.com/O2mvWFE.jpg", Description = "", Year = DateTime.Parse("2018-09-01"), Medium = "Chalk, Paper", Location = "Chicago, Illinois" });
        paintings.Add(new Painting { CollectionID = 9, Title = "Friends", MediaLocation = "https://i.imgur.com/3ykA5Wa.jpg", Description = "", Year = DateTime.Parse("2018-09-01"), Medium = "Chalk, Paper", Location = "Chicago, Illinois" });
        return paintings;
    }

}

