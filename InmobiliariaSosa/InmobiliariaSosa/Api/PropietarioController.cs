
using InmobiliariaSosa.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace InmobiliariaSosa.Api
{   
    [Authorize]
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
        [AllowAnonymous]
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

   
                 return Ok(new { token = GenerarTokenJWT(login) });
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
        private string GenerarTokenJWT(UsuarioView usuarioInfo)
        {
            // CREAMOS EL HEADER //
            var _symmetricSecurityKey = new SymmetricSecurityKey(
                    Encoding.UTF8.GetBytes(configuration["JWT:ClaveSecreta"])
                );
            var _signingCredentials = new SigningCredentials(
                    _symmetricSecurityKey, SecurityAlgorithms.HmacSha256
                );
            var _Header = new JwtHeader(_signingCredentials);

            // CREAMOS LOS CLAIMS //
            var _Claims = new[] {
                new Claim(JwtRegisteredClaimNames.Email, usuarioInfo.Email),
    
            };

            // CREAMOS EL PAYLOAD //
            var _Payload = new JwtPayload(
                    issuer: configuration["JWT:Issuer"],
                    audience: configuration["JWT:Audience"],
                    claims: _Claims,
                    notBefore: DateTime.UtcNow,
                    // Exipra a la 24 horas.
                    expires: DateTime.UtcNow.AddHours(24)
                );

            // GENERAMOS EL TOKEN //
            var _Token = new JwtSecurityToken(
                    _Header,
                    _Payload
                );

            return new JwtSecurityTokenHandler().WriteToken(_Token);
        }
    }
}
