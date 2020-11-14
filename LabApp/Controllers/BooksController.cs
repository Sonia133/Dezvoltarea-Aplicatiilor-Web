using LabApp.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LabApp.Models;

namespace LabApp.Controllers
{
    public class BooksController : Controller
    {
        private DbCtx db = new DbCtx();
        // GET: Books

        [HttpGet]
        public ActionResult Index()
        {
            List<Book> books = db.Books.Include("Publisher").ToList();
            ViewBag.Books = books;
            return View();
        }

        [HttpGet]
        public ActionResult New()
        {
            Book book = new Book
            {
                Genres = new List<Genre>()
            };
            return View(book);
        }

        [HttpPost]
        public ActionResult Create(Book bookRequest)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    bookRequest.Publisher = db.Publishers.FirstOrDefault(predicate => predicate.PublisherId.Equals(1));
                    bookRequest.DateCreation = DateTime.Now;
                    db.Books.Add(bookRequest);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(bookRequest);
            }
            catch(Exception e)
            {
                return View(bookRequest);
            }
        }

        [HttpGet]
        public ActionResult Details(int? id)
        {
            if (id.HasValue)
            {
                Book book = db.Books.Find(id);
                if (book != null)
                {
                    return View(book);
                }
                return HttpNotFound("Couldn't find a book with this id!");
            }
            return HttpNotFound("Missing book id parameter!");
        }
    }
}