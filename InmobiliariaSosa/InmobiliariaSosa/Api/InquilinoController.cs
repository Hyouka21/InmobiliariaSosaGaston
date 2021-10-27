
using InmobiliariaSosa.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace InmobiliariaSosa.Api
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [ApiController]
    [Route("api/[controller]")]
    public class InquilinoController : ControllerBase
    {
        private readonly ApplicationDbContext applicationDbContext;
        private readonly IConfiguration configuration;

        public InquilinoController(ApplicationDbContext applicationDbContext, IConfiguration configuration)
        {
            this.applicationDbContext = applicationDbContext;
            this.configuration = configuration;
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Inquilino>> Get(int id)
        {

            try
            {

                var email = HttpContext.User.FindFirst(ClaimTypes.Email).Value;

                if (id == 0)
                {
                    return BadRequest();
                }


                return await applicationDbContext.Inquilino.Join(
                    applicationDbContext.Contrato.Where(x =>  x.IdInmueble == id),
                    inq => inq.idInquilino,
                    com => com.IdInquilino,
                    (inq, com) => inq).FirstOrDefaultAsync(); 


            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message.ToString());

            }




        }
    }
}
