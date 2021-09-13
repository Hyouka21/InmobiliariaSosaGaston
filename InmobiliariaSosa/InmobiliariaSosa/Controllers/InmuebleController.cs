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
    public class InmuebleController : Controller
    {
        private IInmuebleData idata;
        private IPropietarioData pdata;
        // GET: InmuebleController
        public InmuebleController(IConfiguration configuration,IInmuebleData inm ,IPropietarioData pro)
        {
            
            idata = inm;
            pdata = pro;
        }
        public ActionResult Index(int id)
        {
            ViewBag.Roles = Usuario.ObtenerRoles();
            if (id == 0)
            {
                ViewBag.error = TempData["error"];
                ViewBag.Propietarios = pdata.obtenerTodo();
                var inmuebles = idata.obtenerTodo();
                return View(inmuebles);
            }
            else
            {

                ViewBag.error = TempData["error"];
                ViewBag.Propietarios = pdata.obtenerTodo();
                var inmuebles = idata.obtenerXPropietario(id);
                return View(inmuebles);
            }
        }

        // GET: InmuebleController/Details/5
        public ActionResult Details(int id)
        {
            var i = idata.ObtenerPorId(id);
            return View(i);
        }


        // POST: InmuebleController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Inmueble i)
        {
            try
            {
                idata.alta(i);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                TempData["error"] = ex.Message;
                return RedirectToAction(nameof(Index));
            }
        }

       

        // POST: InmuebleController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Inmueble i)
        {
            try
            {
                idata.Modificacion(i);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                TempData["error"] = ex.Message;
                return RedirectToAction(nameof(Index));
            }
        }

        // GET: InmuebleController/Delete/5
        public ActionResult Delete(int id)
        {
            var i = idata.ObtenerPorId(id);
            return View(i);
        }

        // POST: InmuebleController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                idata.Baja(id);
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
