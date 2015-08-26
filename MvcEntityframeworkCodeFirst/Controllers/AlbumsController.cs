using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcEntityframeworkAndProfiling.DbContexts;
using MvcEntityframeworkAndProfiling.Models;
using MvcEntityframeworkAndProfiling.Repositories;

namespace MvcEntityframeworkAndProfiling.Controllers
{
    public class AlbumsController : Controller
    {
        //
        // GET: /Albums/
        IRepository<Album> repository = new AlbumRepository();

        public ActionResult Index()
        {
            return View(repository.GetAll());
        }
        [HttpGet()]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost()]
        public ActionResult Create(Album album)
        {
            if (!ModelState.IsValid)
                return View(album);
            repository.Add(album);
            repository.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet()]
        public ActionResult Edit(int Id)
        {
            var result = repository.GetAll().Where(a => a.ID == Id).FirstOrDefault();
            return View(result);
        }

        [HttpPost()]
        public ActionResult Edit(Album album)
        {

            var record = repository.GetAll().Where(a => a.ID == album.ID).FirstOrDefault();
            if (record != null)
                record = album;
            repository.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet()]
        public ActionResult Delete(int id)
        {
            var record = repository.GetAll().Where(a => a.ID == id).FirstOrDefault();

            return View(record);
        }

        [HttpPost()]
        public ActionResult Delete(Album album)
        {
            var record = repository.GetAll().Where(a => a.ID == album.ID).FirstOrDefault();
            if (record != null)
            {
                repository.Remove(record);
                repository.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            return Edit(id);
        }
    }
}
