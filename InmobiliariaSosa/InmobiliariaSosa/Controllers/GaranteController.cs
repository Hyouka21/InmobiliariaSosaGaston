using InmobiliariaSosa.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InmobiliariaSosa.Controllers
{

    [Authorize]
    public class GaranteController : Controller
    {
        private IGaranteData gd;
        public GaranteController(IConfiguration configuration,IGaranteData garante)
        {
            
            gd =garante;
        }
        // GET: GaranteController
        public ActionResult Index()
        {
            ViewBag.Roles = Usuario.ObtenerRoles();
            ViewBag.error = TempData["error"];
            var i =gd.obtenerTodo();
            return View(i);
        }

        // GET: GaranteController/Details/5
        public ActionResult Details(int id)
        {
            var i = gd.ObtenerPorId(id);
            return View(i);
        }

        // GET: GaranteController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GaranteController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Garante g)
        {
            try
            {
                gd.alta(g);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                TempData["error"] = ex.Message;
                return RedirectToAction(nameof(Index));
            }
        }

        // GET: GaranteController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: GaranteController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Garante g)
        {
            try
            {
                gd.Modificacion(g);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                TempData["error"] = ex.Message;
                return RedirectToAction(nameof(Index));
            }
        }

        // GET: GaranteController/Delete/5
        public ActionResult Delete(int id)
            
        {
            var g = gd.ObtenerPorId(id);
            return View(g);
        }

        // POST: GaranteController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Garante g)
        {
            try
            {
                gd.Baja(id);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                TempData["error"] = ex.Message;
                return RedirectToAction(nameof(Index));
            }
        }
    }
}
