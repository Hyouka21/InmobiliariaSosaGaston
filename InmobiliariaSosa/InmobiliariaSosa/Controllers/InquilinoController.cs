using InmobiliariaSosa.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InmobiliariaSosa.Controllers
{
    public class InquilinoController : Controller
    {
        // GET: InquilinoController
        private InquilinoData idata;
        public InquilinoController()
        {
            idata = new InquilinoData();
        }
        public ActionResult Index()
        {
            ViewBag.error = TempData["error"];
            var lista = idata.obtenerTodo();
            return View(lista);
        }

        // GET: InquilinoController/Details/5
        public ActionResult Details(int id)
        {
            var mod = idata.ObtenerPorId(id);
            return View(mod);
        }



        // POST: InquilinoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Inquilino i)
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


        // POST: InquilinoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Inquilino i)
        {
            try
            {
                var inq =idata.ObtenerPorId(i.idInquilino);
                inq.nombre = i.nombre;
                inq.apellido = i.apellido;
                inq.dni = i.dni;
                inq.email = i.email;
                inq.telefono = i.telefono;
                idata.Modificacion(inq);
                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                TempData["error"] = ex.Message;
                return RedirectToAction(nameof(Index));
            }
        }

        // GET: InquilinoController/Delete/5
        public ActionResult Delete(int id)
        {
            var inq = idata.ObtenerPorId(id);
            return View(inq);
        }

        // POST: InquilinoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                idata.Baja(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
