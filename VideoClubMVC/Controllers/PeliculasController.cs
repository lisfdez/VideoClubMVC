using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using VideoClubMVC.Models;
using VideoClubMVC.Servicios.Base;

namespace VideoClubMVC.Controllers
{
    public class PeliculasController : Controller
    {
        [Dependency]
        public Servicios<PeliculasModel> _peliculas { get; set; }

        // GET: Peliculas
        public ActionResult Index()
        {
            return View(_peliculas.Get());
        }

        // GET: Peliculas/Details/5
        public ActionResult Details(int id)
        {
            return View(_peliculas.Get(id));
        }

        // GET: Peliculas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Peliculas/Create
        [HttpPost]
        public async Task<ActionResult> Create(PeliculasModel modelo)
        {
            try
            {
                // TODO: Add insert logic here
                await _peliculas.Add(modelo);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Peliculas/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Peliculas/Edit/5
        [HttpPost]
        public async Task<ActionResult> Edit(int id, PeliculasModel modelo)
        {
            try
            {
                // TODO: Add update logic here
                await _peliculas.Update(modelo);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Peliculas/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Peliculas/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, PeliculasModel modelo)
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
