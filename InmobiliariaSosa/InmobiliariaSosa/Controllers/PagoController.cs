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
    public class PagoController : Controller
    {
        private IContratoData cdata;
        private IInquilinoData idata;
        private IInmuebleData inmdata;
        private IGaranteData gdata;
        private IPagoData pdata;
        public PagoController(IContratoData c,IInquilinoData i,IInmuebleData im,IGaranteData g ,IPagoData p)
        {
            pdata = p;
            cdata = c;
            idata = i;
            inmdata = im;
            gdata = g;

        }
        // GET: PagoController
        public ActionResult Index(int id)
        {
            ViewBag.Roles = Usuario.ObtenerRoles();
            if (id != 0)
            {
                ViewBag.idContratoR = id;
                var con = cdata.ObtenerPorId(id);
                ViewBag.contrato = con;
                var list = pdata.obtenerTodoXId(id);

                return View(list);
            }
            else
            {
                TempData["error"] = "El pago que esta buscando no se encuentra";
                return RedirectToAction("Index","Contrato");
            }
        }

        // GET: PagoController/Details/5
        public ActionResult Details(int id)
        {
            var p = pdata.ObtenerPorId(id);
            return View(p);
        }

        // GET: PagoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PagoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Pago pago)
        {
            try
            {
                int id = pago.ContratoId;
                pdata.alta(pago);
              
                return RedirectToAction(nameof(Index),new { id});
            }
            catch (Exception ex)
            {
                TempData["error"] = ex.Message;
                int id = pago.ContratoId;

                return RedirectToAction(nameof(Index), new { id });
            }
        }

        // GET: PagoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PagoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int ida, Pago p)
        {
            try
            {
                int id = p.ContratoId;
                pdata.Modificacion(p);

                return RedirectToAction(nameof(Index), new { id });
            }
            catch (Exception ex)
            {
                TempData["error"] = ex.Message;
                int id = p.ContratoId;

                return RedirectToAction(nameof(Index), new { id});
            }
        }

        // GET: PagoController/Delete/5
        public ActionResult Delete(int id)
        {
            
            
            var pago =pdata.ObtenerPorId(id);
           
            return View(pago);
        }

        // POST: PagoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int ida, Pago p)
        {
            try
            {
                
                int id = pdata.ObtenerPorId(p.Id).ContratoId;
                pdata.Baja(p.Id);
                

                return RedirectToAction(nameof(Index), new { id });
            }
            catch (Exception ex)
            {
                TempData["error"] = ex.Message;
                int id = pdata.ObtenerPorId(p.Id).ContratoId;

                return RedirectToAction(nameof(Index), new { id });
            }
        }
    }
}
