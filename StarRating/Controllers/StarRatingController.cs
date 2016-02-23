using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StarRating.Controllers
{
    public class StarRatingController : Controller
    {
        // GET: StarRating
        public ActionResult Index()
        {
            return View();
        }
    }
}