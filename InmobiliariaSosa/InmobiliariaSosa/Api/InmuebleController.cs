using InmobiliariaSosa.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InmobiliariaSosa.Api
{
    [ApiController]
    [Route("api/[controller]")]
    public class InmuebleController : ControllerBase
    {
        private readonly ApplicationDbContext applicationDbContext;
        private readonly IConfiguration configuration;

        public InmuebleController(ApplicationDbContext applicationDbContext, IConfiguration configuration)
        {
            this.applicationDbContext = applicationDbContext;
            this.configuration = configuration;
        }
        [HttpGet("{id:int}")]
        public async Task<ActionResult<List<Inmueble>>> Get(int id)
        {
            
            try
            {
                var propietario = await applicationDbContext.Propietario.AnyAsync(x => x.idPropietario == id);

                if (!propietario)
                {

                    return NotFound();

                }
                var inmuebles =  await applicationDbContext.Inmueble.Where(x => x.IdPropietario == id).ToListAsync();

                
                return Ok(inmuebles);


            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message.ToString());

            }
           
            


        }
        [HttpGet("contrato/{id}")]
        public async Task<ActionResult<List<Inmueble>>> GetAlquilados(int id)
        {
            List<Inmueble> lista = null;
            try
            {
                var propietario = await applicationDbContext.Propietario.AnyAsync(x => x.idPropietario == id);

                if (!propietario)
                {

                    return NotFound();

                }


                var inmuebles = await applicationDbContext.Inmueble.Join(
                    applicationDbContext.Contrato.Where(x=>x.FechaHasta>DateTime.Now&& x.FechaDesde< DateTime.Now),
                    inm => inm.Id,
                    com => com.IdInmueble,
                    (inm, com) => inm)
                    .Where(x => x.IdPropietario == id).ToListAsync();

                return Ok(inmuebles);


            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message.ToString());

            }
        }
        [HttpPut("{id}")]//Cambiar Estado
        public async Task<ActionResult> Put([FromForm] byte estado, int id)
        {

            try
            {
                Inmueble inmuebleV = await applicationDbContext.Inmueble.FirstOrDefaultAsync(x => x.Id == id);


                inmuebleV.Estado = estado;
                applicationDbContext.Update(inmuebleV);
                await applicationDbContext.SaveChangesAsync();
                return Ok();

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }


        }



    }
}
