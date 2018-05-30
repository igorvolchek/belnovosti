using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using belnovosti.Models;
namespace belnovosti.Controllers
{
    public class HomeController : Controller
    {
        ArticleContext db = new ArticleContext();
        public ActionResult Index()
        {
            var articles = db.Articles;
            ViewBag.Articles = articles;
            return View();
        }
        [HttpGet]
        [Authorize]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [Authorize]
        public ActionResult Create(Article article)
        {

            HttpCookie cookie = Request.Cookies["UserInfo"];
            if (cookie != null)
            {
                article.Author = cookie["Username"];
            }
            db.Articles.Add(article);
            db.SaveChanges();
            return Redirect("/Home/Index");
        }
       
       
        [Authorize]
        public ActionResult Delete(int id)
        {
            Article b = new Article();
            b = db.Articles.Find(id);
            db.Articles.Remove(b);
            db.SaveChanges();
            return Redirect("/Account/Manage");
        }
        public ActionResult Content(int id)
        {
            Article b = db.Articles.Find(id);
            if (b == null)
            {
                return HttpNotFound();
            }

            return View(b);

        }
}
}