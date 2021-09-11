using InmobiliariaSosa.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InmobiliariaSosa.Controllers
{
    public class ContratoController : Controller
    {
        private ContratoData cdata;
        private InquilinoData idata;
        private InmuebleData inmdata;
        private GaranteData gdata;
        public ContratoController(IConfiguration configuration)
        {
            
            cdata = new ContratoData(configuration);
            idata = new InquilinoData(configuration);
            inmdata = new InmuebleData(configuration);
            gdata = new GaranteData(configuration);
        }
        // GET: ContratoController
        public ActionResult Index()
        {
            ViewBag.error = TempData["error"];
            ViewBag.Inquilinos = idata.obtenerTodo();
            ViewBag.Inmuebles = inmdata.obtenerTodo();
            ViewBag.Garantes = gdata.obtenerTodo();
            var c = cdata.obtenerTodo();
            return View(c);
        }
        // GET: Propietario/Buscar/5
        [Route("[controller]/Buscar", Name = "Buscar")]
        public IActionResult Buscar(BusquedaInmueble busInm)
        {
            try
            {
                var lista = inmdata.obtenerInmuebles(busInm.Desde, busInm.Hasta, busInm.Id);
                return Json(new { lista });
            }
            catch (Exception ex)
            {
                return Json(new { Error = ex.Message });
            }
        }
        // GET: ContratoController/Details/5
        public ActionResult Details(int id)
        {
            var c = cdata.ObtenerPorId(id);
            
            return View(c);
        }

        // GET: ContratoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ContratoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Contrato c)
        {
            try
            {
                cdata.alta(c);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                TempData["error"] = ex.Message;
                return RedirectToAction(nameof(Index));
            }
        }

        // GET: ContratoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ContratoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Contrato c)
        {
            try
            {
                cdata.Modificacion(c);
                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                TempData["error"] = ex.Message;
                return RedirectToAction(nameof(Index));
            }
        }

        // GET: ContratoController/Delete/5
        public ActionResult Delete(int id)
        {
            var c = cdata.ObtenerPorId(id);
            return View(c);
        }

        // POST: ContratoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Contrato c)
        {
            try
            {
                cdata.Baja(id);
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
