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
    public class PagoController : ControllerBase
    {
        private readonly ApplicationDbContext applicationDbContext;
        private readonly IConfiguration configuration;

        public PagoController(ApplicationDbContext applicationDbContext, IConfiguration configuration)
        {
            this.applicationDbContext = applicationDbContext;
            this.configuration = configuration;
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<List<Pago>>> GetPagoXContrato(int id)
        {

            try
            {
                var pagos = await applicationDbContext.Pago.Include(x=>x.Contrato).Where(x =>
                   x.ContratoId == id 
                    ).ToListAsync();

                return Ok(pagos);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message.ToString());

            }

        }
    }
}
