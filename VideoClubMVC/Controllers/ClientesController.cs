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
    public class ClientesController : Controller
    {
        [Dependency]
        public Servicios<ClientesModel> _clientes { get; set; }

        // GET: Clientes
        public ActionResult Index()
        {
            return View(_clientes.Get());
        }

        // GET: Clientes/Details/5
        public ActionResult Details(int id)
        {
            return View(_clientes.Get(id));
        }

        // GET: Clientes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Clientes/Create
        [HttpPost]
        public async Task<ActionResult> Create(ClientesModel modelo)
        {
            try
            {
                // TODO: Add insert logic here
                await _clientes.Add(modelo);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Clientes/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_clientes.Get(id));
        }

        // POST: Clientes/Edit/5
        [HttpPost]
        public async Task<ActionResult> Edit(int id, ClientesModel modelo)
        {
            try
            {
                // TODO: Add update logic here
                await _clientes.Update(modelo);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Clientes/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Clientes/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, ClientesModel modelo)
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
