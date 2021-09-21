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
    public class PropietarioController : Controller
    {
        private IPropietarioData pd;
        public PropietarioController(IConfiguration configuration,IPropietarioData pr)
        {
            pd = pr;
        }
        // GET: PropietarioController
        public ActionResult Index()
        {
            
            ViewBag.error = TempData["error"];
            var list =pd.obtenerTodo();
            return View(list);
        }

        // GET: PropietarioController/Details/5
        public ActionResult Details(int id)
        {
            var mod = pd.ObtenerPorId(id);
            return View(mod);
        }


        // POST: PropietarioController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Propietario p)
        {
            try
            {
                pd.alta(p);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                TempData["error"] = ex.Message;
                return RedirectToAction(nameof(Index));
            }
        }

        // GET: PropietarioController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PropietarioController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Propietario p)
        {
            try
            {
                var mod =pd.ObtenerPorId(p.idPropietario);
                mod.nombre = p.nombre;
                mod.apellido = p.apellido;
                mod.dni = p.dni;
                mod.email = p.email;
                if (String.IsNullOrEmpty(p.clave))
                {

                }
                else
                {
                    mod.clave = p.clave;
                }
                pd.Modificacion(mod);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                TempData["error"] = ex.Message;
                return RedirectToAction(nameof(Index));
            }
        }

        // GET: PropietarioController/Delete/5
        public ActionResult Delete(int id)
        {
            var p = pd.ObtenerPorId(id);
            return View(p);
        }

        // POST: PropietarioController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                pd.Baja(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
