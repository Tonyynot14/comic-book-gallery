using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Comic_Book.Models;

namespace Comic_Book.Controllers
{
    public class ComicBooksController : Controller
    {
        // GET: ComicBooks
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Detail()
        {
            ComicBook comicBook = new ComicBook()
            {
                SeriesTitle = "The Amazing Spider-Man",
                IssueNumber = 700,
                DescriptionHtml = @"<p>Final issue! Witness the final
                hours of Doctor Octopus' life and his one,
                last, great act of revenge! Even if Spider-Man
                survives... <strong>will Peter Parker?</strong></p>",
                Artists = new Artist[]
          {
              new Artist()
              {
                Role= "Script",
                Name = "Dan Slott",
              },
              new Artist()
              {
                Role=  "Pencils",
                Name = " Humberto Ramos"
              },
              new Artist()
              {
                Role= "Inks",
                Name = "Victor Olazaba",
              },
              new Artist()
              {
                Role= "Colors",
                Name = "Edgar Delgado",
              },
              new Artist()
              {
                Role= "Letters",
                Name = "Chris Eliopoulos",
              },

          }
            };

            if (DateTime.Today.DayOfWeek == DayOfWeek.Sunday)
            {
                return Redirect("/ComicBooks/Index");
            }
            return View(comicBook);
        }
    }
}