using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCRiderModel;

namespace MVCRider.Controllers
{
    public class PostController : Controller
    {
        //
        // GET: /Post/

        public ActionResult Index()
        {
            var ctx = new MVCRiderDataBaseEntities();
            var posts = ctx.Posts;
            return View(posts);
        }

        //
        // GET: /Post/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Post/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Post/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            //UpdateModel
            var ctx = new MVCRiderDataBaseEntities();
            var newPost = ctx.Posts.CreateObject();
            TryUpdateModel(newPost);
            if (ModelState.IsValid)
            {
                ctx.AddToPosts(newPost);
                ctx.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(newPost);
            }
        }
        
        //
        // GET: /Post/Edit/5
 
        public ActionResult Edit(int id)
        {
            var ctx = new MVCRiderDataBaseEntities();
            var currentPost = ctx.Posts.Where(a => a.ID == id).First();
            return View(currentPost);
        }

        //
        // POST: /Post/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                var ctx = new MVCRiderDataBaseEntities();
                var currentPost = ctx.Posts.Where(a => a.ID == id).First();
                TryUpdateModel(currentPost);
                if (ModelState.IsValid)
                {
                    ctx.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(currentPost);
                }                
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Post/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Post/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
