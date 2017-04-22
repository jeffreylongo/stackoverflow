using redditTakeTwo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace redditTakeTwo.Controllers
{
    public class HomeController : Controller
    {
        public ApplicationDbContext Database = new ApplationDbContext();

        public ActionResult Index()
        {
            return View(Database.Posts.ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}