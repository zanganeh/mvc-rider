using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCRider.Controllers
{
    public class HomeController : Controller
    {
        MVCRiderModel.MVCRiderDataBaseEntities _dx = new MVCRiderModel.MVCRiderDataBaseEntities();

        public ActionResult Index()
        {
            var posts = _dx.Posts
                .Where(a =>
                    (a.Active ?? false) == true && (!a.ReleaseDate.HasValue || (a.ReleaseDate.HasValue && a.ReleaseDate.Value > DateTime.Now)))
                .OrderByDescending(a => a.CreatedDate)
                .ToList();
            return View(posts);
        }

        public ActionResult About()
        {
            return View();
        }
    }
}