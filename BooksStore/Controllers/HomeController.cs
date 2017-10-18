using BooksStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BooksStore.Controllers
{
    public class HomeController : Controller
    {
        BookContext db;

        public ActionResult Index()
        {
            ViewBag.Books = db.Books;
            return View();
        }

        public ActionResult Books()
        {
            ViewBag.Message = "Your new BOOKS";

            return View();
        }

        public ActionResult Consumer()
        {
            ViewBag.Message = "Consumer information";

            return View();
        }

        public ActionResult History()
        {
            ViewBag.Message = "purchase history";

            return View();
        }
    }
}