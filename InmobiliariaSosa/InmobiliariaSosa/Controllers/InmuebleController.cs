﻿using InmobiliariaSosa.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InmobiliariaSosa.Controllers
{
    public class InmuebleController : Controller
    {
        private InmuebleData idata;
        private PropietarioData pdata;
        // GET: InmuebleController
        public InmuebleController(IConfiguration configuration)
        {
            idata = new InmuebleData(configuration);
            pdata = new PropietarioData(configuration);
        }
        public ActionResult Index()
        {
            ViewBag.error = TempData["error"];
            ViewBag.Propietarios = pdata.obtenerTodo();
            var inmuebles = idata.obtenerTodo();
            return View(inmuebles);
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
