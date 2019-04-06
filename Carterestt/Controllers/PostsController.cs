using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Carterestt.Models;
using Data;
using Microsoft.AspNet.Identity;

namespace Carterestt.Controllers
/// <summary>
/// Този клас създава публикации
/// </summary>
/// <remarks>
///     Автор: Бюлент Казали
/// </remarks>
{ 
    public class PostsController : Controller
    {
        private CarContext db = new CarContext();

        // GET: Posts
        public ActionResult Index()
        {
            return View(db.Posts.ToList());
        }

        // GET: Posts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Post post = db.Posts.Find(id);
            ApplicationDbContext applicationDbContext = new ApplicationDbContext();
            if (post.UserId != null)
            {
                var user = applicationDbContext.Users.Find(post.UserId);
                post.UserId = user.UserName;
            }
            else
            {
                post.UserId = null;
            }

            if (post == null)
            {
                return HttpNotFound();
            }
            return View(post);
        }

        // GET: Posts/Create
        [Authorize]
        public ActionResult Create()
        {
            ViewBag.Brands = db.Brands.ToList();
            return View(
            );
        }

        
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Decription,FileName,UserId")] Post post)
        {
            if (ModelState.IsValid)
            {
                post.UserId = User.Identity.GetUserId();
                var brandId = Request.Form["brandId"];
                post.BrandPosts = new List<BrandPost>() {
                    new BrandPost() { BrandId = int.Parse(brandId), Post = post }
                };
                db.Posts.Add(post);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(post);
        }

        [Authorize]
        // GET: Posts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Post post = db.Posts.Find(id);
            if (post == null)
            {
                return HttpNotFound();
            }
            return View(post);
        }

     
        [Authorize]
        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Decription,FileName,UserId")] Post post)
        {
            if (ModelState.IsValid)
            {
                post.UserId = User.Identity.GetUserId();
                db.Entry(post).State = EntityState.Modified;

                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(post);
        }

        

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
