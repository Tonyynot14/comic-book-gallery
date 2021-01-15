using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Comic_Book.Models;
using Comic_Book.Data;

namespace Comic_Book.Controllers
{
    public class ComicBooksController : Controller
    {
        ComicBookRepository _comicBookRepository = null;

        public ComicBooksController()
        {
            _comicBookRepository = new ComicBookRepository();
        }
        // GET: ComicBooks
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Detail(int? id)
        {
            if(id == null)
            {
                return HttpNotFound();
            }
            ComicBook comicBook = _comicBookRepository.GetComicBook(id.Value);

            if (DateTime.Today.DayOfWeek == DayOfWeek.Sunday)
            {
                return Redirect("/ComicBooks/Index");
            }
            return View(comicBook);
        }
    }
}