using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcEntityframeworkAndProfiling.Models;

namespace MvcEntityframeworkAndProfiling.Controllers
{
    public class AlbumsController : Controller
    {
        //
        // GET: /Albums/

        public ActionResult Index()
        {
            using (var dbContext = new MusicDatabaseContext())
            {
                return View(dbContext.Albums.ToList());       
            }
        }
        [HttpGet()]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost()]
        public ActionResult Create(Album album)
        {
            using (var context = new MusicDatabaseContext())
            {

                context.Albums.Add(album);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
        }
        [HttpGet()]
        public ActionResult Edit(int Id)
        {
            using (var context = new MusicDatabaseContext())
            {
                var result = context.Albums.Where(a => a.ID == Id).FirstOrDefault();
                return View(result);
            }
        }

        [HttpPost()]
        public ActionResult Edit(Album album)
        {
            using (var context = new MusicDatabaseContext())
            {
                var record = context.Albums.Where(a => a.ID == album.ID).FirstOrDefault();
                if (record != null)
                    record = album;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
        }

        [HttpGet()]
        public ActionResult Delete(int id)
        {
            using (var context = new MusicDatabaseContext())
            {
                var record = context.Albums.Where(a => a.ID == id).FirstOrDefault();

                return View(record);
            }
        }

        [HttpPost()]
        public ActionResult Delete(Album album)
        {
            using (var context = new MusicDatabaseContext())
            {
                var record = context.Albums.Where(a => a.ID == album.ID).FirstOrDefault();
                 if (record != null)
                 {
                     context.Albums.Remove(record);
                     context.SaveChanges();
                 }
                return RedirectToAction("Index");
            }
        }

        public ActionResult Details(int id)
        {
            return Edit(id);
        }
    }

    public class MusicDatabaseContext : DbContext
    {
        public MusicDatabaseContext()
        {
            Database.Log = s => Debug.WriteLine(s);
        }
        public DbSet<Album> Albums { get; set; }
    }
}
