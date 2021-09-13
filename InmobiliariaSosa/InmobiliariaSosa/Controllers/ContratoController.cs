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
    public class ContratoController : Controller
    {
        
        private IContratoData cdata;
        private IInquilinoData idata;
        private IInmuebleData inmdata;
        private IGaranteData gdata;
        public ContratoController(IConfiguration configuration,IContratoData contratoI,IInquilinoData inquilino,IInmuebleData inmueble , IGaranteData garante)
        {
            
            cdata = contratoI ;
            idata = inquilino;
            inmdata = inmueble;
            gdata = garante;
        }
        // GET: ContratoController
        public ActionResult Index(int id)
        {
            if (id == 0)
            {
                ViewBag.error = TempData["error"];
                ViewBag.Inquilinos = idata.obtenerTodo();
                
                ViewBag.Garantes = gdata.obtenerTodo();
                var c = cdata.obtenerTodo();
                return View(c);
            }
            else
            {
                ViewBag.error = TempData["error"];
                ViewBag.Inquilinos = idata.obtenerTodo();
                ViewBag.Garantes = gdata.obtenerTodo();
                var c = cdata.obtenerXInmueble(id);
                return View(c);
            }
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
