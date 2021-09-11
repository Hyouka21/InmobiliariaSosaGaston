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
    public class PagoController : Controller
    {
        private ContratoData cdata;
        private InquilinoData idata;
        private InmuebleData inmdata;
        private GaranteData gdata;
        private PagoData pdata;
        public PagoController(IConfiguration configuration)
        {
            pdata = new PagoData(configuration);
            cdata = new ContratoData(configuration);
            idata = new InquilinoData(configuration);
            inmdata = new InmuebleData(configuration);
            gdata = new GaranteData(configuration);

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
