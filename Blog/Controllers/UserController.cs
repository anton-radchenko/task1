using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.Controllers
{
    public class UserController : Controller
    {
        List<string[]> Reviews = new List<string[]>();
        // GET: User
        public ActionResult Index()
        {
            string[] rev1 = { "user1", "02.02.20", "Lorem ipsum dolor sit amet, consectetur adipiscing elit." };
            string[] rev2 = { "user2", "01.02.20", "Lorem ipsum dolor sit amet, consectetur adipiscing elit." };
            string[] rev3 = { "user3", "30.01.20", "Lorem ipsum dolor sit amet, consectetur adipiscing elit." };
            string[] rev4 = { "user4", "30.01.20", "Lorem ipsum dolor sit amet, consectetur adipiscing elit." };

            Reviews.Add(rev1);
            Reviews.Add(rev2);
            Reviews.Add(rev3);
            Reviews.Add(rev4);

            ViewBag.ReviewsBag = Reviews;

            return View();
        }

        [HttpGet]
        public ViewResult AddReview()
        {
            return View("~/Views/User/Index.cshtml");
        }
        [HttpPost]
        public ViewResult AddReview(string name, string review)
        {

            string data = DateTime.Now.ToString();
            string[] tempRev = { name, review, data };
            Reviews.Add(tempRev);
            ViewBag.ReviewsBag = Reviews;
            return View("~/Views/User/Index.cshtml");
        }

    }
}