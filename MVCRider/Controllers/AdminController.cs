using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCRiderModel;

namespace MVCRider.Controllers
{
    public class AdminController : Controller
    {
        MVCRiderModel.MVCRiderDataBaseEntities _dx = new MVCRiderModel.MVCRiderDataBaseEntities();
        //
        // GET: /Admin/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Posts()
        {
            return View(_dx.Posts.ToList());
        }

        public ActionResult PostEdit(int id)
        {
            var currentPost = _dx.Posts.Where(a => a.ID == id).FirstOrDefault();
            return View(currentPost);
        }

        [AcceptVerbs(HttpVerbs.Post)]        
        public ActionResult PostEdit(int id, FormCollection collection)
        {
            var currnetPost = _dx.Posts.FirstOrDefault(a => a.ID == id);
            if (TryUpdateModel(currnetPost))
            {
                _dx.SaveChanges();
                return RedirectToAction("Posts");
            }
            else
            {
                return View(currnetPost);
            }
        }

        public ActionResult PostCreate()
        {
            return View();
        }

        [AcceptVerbs( HttpVerbs.Post)]
        public ActionResult PostCreate(Post currentPost)
        {
            _dx.Posts.AddObject(currentPost);
            _dx.SaveChanges();
            return RedirectToAction("Posts");
        }
    }
}
