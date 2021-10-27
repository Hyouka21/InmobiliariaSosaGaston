using InmobiliariaSosa.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InmobiliariaSosa.Api
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [ApiController]
    [Route("api/[controller]")]
    public class ContratoController: ControllerBase
    {
        private readonly ApplicationDbContext applicationDbContext;
        private readonly IConfiguration configuration;

        public ContratoController(ApplicationDbContext applicationDbContext, IConfiguration configuration)
        {
            this.applicationDbContext = applicationDbContext;
            this.configuration = configuration;
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Contrato>> GetContratoXInmueble(int id)
        {
            
            try
            {
                if (ModelState.IsValid)
                {
                    return  await applicationDbContext.Contrato.Include(x=> x.Inquilino).Include(x=>x.Inmueble).Where(x =>
                   x.IdInmueble == id &&
                   x.FechaHasta > DateTime.Now && x.FechaDesde < DateTime.Now)
                    .FirstOrDefaultAsync();
                }
                else
                {
                    return BadRequest();
                }

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message.ToString());

            }
        }
    }
}
