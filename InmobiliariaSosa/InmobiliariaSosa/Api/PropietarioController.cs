
using InmobiliariaSosa.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.AspNetCore.Http;
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
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [ApiController]
    [Route("api/[controller]")]
    public class PropietarioController : ControllerBase
    {
        private readonly ApplicationDbContext applicationDbContext;
        private readonly IConfiguration configuration;
        private readonly IHttpContextAccessor contextAccessor;

        public PropietarioController(ApplicationDbContext applicationDbContext, IConfiguration configuration, IHttpContextAccessor contextAccessor)
        {
            this.applicationDbContext = applicationDbContext;
            this.configuration = configuration;
            this.contextAccessor = contextAccessor;
        }
        [AllowAnonymous]
        [HttpPost("login")]
        public async Task<ActionResult<TokenDto>> Login([FromForm]UsuarioView login)
        {
             
            try
            {
                if (ModelState.IsValid)
                {
                    Propietario propietario = await applicationDbContext.Propietario.FirstOrDefaultAsync(x => x.email == login.Email);

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


                    return Ok( new TokenDto { Token = GenerarTokenJWT(login) });
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
        [HttpGet("obtenerusuario")]
        public async Task<ActionResult<Propietario>> ObtenerUsuario()
        {
            try
            {

                var email = HttpContext.User.FindFirst(ClaimTypes.Email).Value;
                      
                return await applicationDbContext.Propietario.FirstOrDefaultAsync(x => x.email == email);

            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut("actualizar")]
        public async Task<ActionResult<Propietario>> Put([FromBody] Propietario prop)
        {

            try
            {
             //   if (ModelState.IsValid)
             //   {
                 
                    var email = HttpContext.User.FindFirst(ClaimTypes.Email).Value;
                    Propietario propietarioV = await applicationDbContext.Propietario.FirstOrDefaultAsync(x => x.email == email);

                    if(prop.idPropietario != propietarioV.idPropietario)
                    {
                        return Unauthorized();
                    }


                    if (prop.clave == null || prop.clave=="")
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

                    return await applicationDbContext.Propietario.FirstOrDefaultAsync(x => x.email == email);
              //  }
              //  else
              //  {
               //     return BadRequest();
               // }
                

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
                new Claim(ClaimTypes.Email, usuarioInfo.Email),
    
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
