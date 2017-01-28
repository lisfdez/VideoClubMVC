using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Practices.Unity;
using VideoClubMVC.Servicios.Base;
using VideoClubMVC.Models;
using System.Threading.Tasks;

namespace VideoClubMVC.Controllers
{
    public class ActoresController : Controller
    {
        //AÑADIR LAS DEPENDENCY
        [Dependency]
        public Servicios<ActoresModel> _actores { get; set; }
        

        // GET: Actores
        public ActionResult Index()
        {
            return View(_actores.Get());
        }

        // GET: Actores/Details/5
        public ActionResult Details(int id)
        {
            return View(_actores.Get(id));
        }

        // GET: Actores/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Actores/Create
        [HttpPost]
        public async Task<ActionResult> Create(ActoresModel modelo)
        {
            try
            {
                // TODO: Add insert logic here
                await _actores.Add(modelo);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Actores/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_actores.Get(id));
        }

        // POST: Actores/Edit/5
        [HttpPost]
        public async Task<ActionResult> Edit(int id, ActoresModel modelo)
        {
            try
            {
                // TODO: Add update logic here
                await _actores.Update(modelo);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Actores/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Actores/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, ActoresModel modelo)
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
