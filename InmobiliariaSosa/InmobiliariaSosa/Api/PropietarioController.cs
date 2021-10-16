
using InmobiliariaSosa.Models;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
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
    public class PropietarioController : ControllerBase
    {
        private readonly ApplicationDbContext applicationDbContext;
        private readonly IConfiguration configuration;

        public PropietarioController(ApplicationDbContext applicationDbContext, IConfiguration configuration)
        {
            this.applicationDbContext = applicationDbContext;
            this.configuration = configuration;
        }
        [HttpPost("login")]
        public async Task<ActionResult<Propietario>> Login([FromForm]UsuarioView login)
        {
            Propietario propietario = null;
            try
            {
                propietario= await applicationDbContext.Propietario.FirstOrDefaultAsync(x => x.email == login.Email);

                string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                         password: login.Clave,
                         salt: System.Text.Encoding.ASCII.GetBytes(configuration["Salt"]),
                         prf: KeyDerivationPrf.HMACSHA1,
                         iterationCount: 1000,
                         numBytesRequested: 256 / 8));


                if (propietario == null || propietario.clave != hashed)
                {

                    return NotFound();

                }

                propietario.clave = "";
                return Ok(propietario);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message.ToString());

            }
            
        }
        [HttpPut("{id}")]
        public async Task<ActionResult> Put([FromForm] Propietario prop, int id)
        {

            try
            {
                Propietario propietarioV = await applicationDbContext.Propietario.FirstOrDefaultAsync(x => x.email == prop.email);
                
                if (prop.idPropietario != id)
                {
                    return BadRequest("El id del propietario no coincide con el de la url");
                }
             

                if (prop.clave == null)
                {
                    prop.clave = propietarioV.clave;
                }
                else
                {
                    string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                       password: prop.clave,
                       salt: System.Text.Encoding.ASCII.GetBytes(configuration["Salt"]),
                       prf: KeyDerivationPrf.HMACSHA1,
                       iterationCount: 1000,
                       numBytesRequested: 256 / 8));
                    prop.clave = hashed;

                }
                applicationDbContext.Entry(propietarioV).CurrentValues.SetValues(prop);
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
