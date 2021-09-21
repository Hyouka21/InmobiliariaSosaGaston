using InmobiliariaSosa.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace InmobiliariaSosa.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IWebHostEnvironment environment;
        private readonly IConfiguration configuration;
     
        private  IUsuarioData uData;
        
        public UsuarioController(IConfiguration configuration, IWebHostEnvironment environment,IUsuarioData usu)
        {
            ViewBag.Roles = Usuario.ObtenerRoles();
            this.configuration = configuration;
            this.environment=environment;
            this.uData = usu;
        }
        // [Authorize(Policy = "Administrador")]
        // GET: UsuarioController
        [Authorize(Policy = "Administrador")]
        public ActionResult Index()
        {
            ViewBag.Roles = Usuario.ObtenerRoles();
            var usu = uData.obtenerTodo();
            return View(usu);
        }

        // GET: UsuarioController/Details/5
        [Authorize(Policy = "Administrador")]
        public ActionResult Details(int id)
        {
            var u =uData.ObtenerPorId(id);
            return View(u);
        }

        // GET: UsuarioController/Create
        [Authorize(Policy = "Administrador")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: UsuarioController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Policy = "Administrador")]
        public ActionResult Create(Usuario u)
        {
            try
            {
                string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                        password: u.Clave,
                        salt: System.Text.Encoding.ASCII.GetBytes(configuration["Salt"]),
                        prf: KeyDerivationPrf.HMACSHA1,
                        iterationCount: 1000,
                        numBytesRequested: 256 / 8));
                u.Clave = hashed;               
                int res = uData.alta(u);
                if (u.AvatarFile != null && u.Id > 0)
                {
                    string wwwPath = environment.WebRootPath;
                    string path = Path.Combine(wwwPath, "Uploads");
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                    //Path.GetFileName(u.AvatarFile.FileName);//este nombre se puede repetir
                    string fileName = "avatar_" + u.Id + Path.GetExtension(u.AvatarFile.FileName);
                    string pathCompleto = Path.Combine(path, fileName);
                    u.Avatar = Path.Combine("/Uploads", fileName);
                    using (FileStream stream = new FileStream(pathCompleto, FileMode.Create))
                    {
                        u.AvatarFile.CopyTo(stream);
                    }
                    uData.Modificacion(u);
                }
                else
                {
                    u.Avatar = Path.Combine("/Uploads", "usuario.png");
                    uData.Modificacion(u);
                }
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Roles = Usuario.ObtenerRoles();
                return RedirectToAction(nameof(Index));
            }
        }

        // GET: UsuarioController/Edit/5
        [Authorize(Policy = "Administrador")]
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UsuarioController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Policy = "Administrador")]
        public ActionResult Edit(int id, Usuario u)
        {
            try
            {
                Usuario usuViejo = uData.ObtenerPorId(u.Id);
                
                if (u.Clave == null)
                {
                    u.Clave = usuViejo.Clave;
                }
                else
                {
                    string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                       password: u.Clave,
                       salt: System.Text.Encoding.ASCII.GetBytes(configuration["Salt"]),
                       prf: KeyDerivationPrf.HMACSHA1,
                       iterationCount: 1000,
                       numBytesRequested: 256 / 8));
                    u.Clave = hashed;

                }
                if (u.AvatarFile != null && u.Id > 0)
                {
                    string wwwPath = environment.WebRootPath;
                    if (usuViejo.Avatar != @"/Uploads\usuario.png") {
                        string urlAvatar = usuViejo.Avatar.Substring(1);
                        System.IO.File.Delete(Path.Combine(wwwPath, urlAvatar));
                    }
                   
                    string path = Path.Combine(wwwPath, "Uploads");
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                    
                    //Path.GetFileName(u.AvatarFile.FileName);//este nombre se puede repetir
                    string fileName = "avatar_" + u.Id + Path.GetExtension(u.AvatarFile.FileName);
                    string pathCompleto = Path.Combine(path, fileName);
                    u.Avatar = Path.Combine("/Uploads", fileName);
                    using (FileStream stream = new FileStream(pathCompleto, FileMode.Create))
                    {
                        u.AvatarFile.CopyTo(stream);
                    }
                    uData.Modificacion(u);
                }
                else
                {
                    u.Avatar = usuViejo.Avatar;
                    uData.Modificacion(u);
                }

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                return View();
            }
        }

        // GET: UsuarioController/Delete/5
        [Authorize(Policy = "Administrador")]
        public ActionResult Delete(int id)
        {
            var u = uData.ObtenerPorId(id);
            return View(u);
        }

        // POST: UsuarioController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Policy = "Administrador")]
        public ActionResult Delete(int id, Usuario u)
        {
            try
            {
                uData.Baja(u.Id);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                return View();
            }
        }
        [Authorize]
        public async Task<ActionResult> Logout()
        {
            await HttpContext.SignOutAsync(
                CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Home");
        }
        [AllowAnonymous]
        public async Task<IActionResult> Login(UsuarioView login)
        {
            try
            {
                string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                         password: login.Clave,
                         salt: System.Text.Encoding.ASCII.GetBytes(configuration["Salt"]),
                         prf: KeyDerivationPrf.HMACSHA1,
                         iterationCount: 1000,
                         numBytesRequested: 256 / 8));

                var e = uData.ObtenerPorEmail(login.Email);
                if (e == null || e.Clave != hashed)
                {
                   
                    TempData["error"] = "El email o la clave no son correctos";
                    return RedirectToAction(nameof(Index), "Home");
                }

                var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, e.Email),
                        new Claim("FullName", e.Nombre + " " + e.Apellido),
                        new Claim("fotoUrl", e.Avatar),
                        new Claim(ClaimTypes.Role, e.RolNombre),
                    };

                var claimsIdentity = new ClaimsIdentity(
                    claims, CookieAuthenticationDefaults.AuthenticationScheme);

                await HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(claimsIdentity));


                if (TempData["url"] != null)
                {
                    return Redirect(TempData["url"].ToString());
                }
                else
                {
                    return RedirectToAction(nameof(Index), "Home");
                }
            }
            catch (Exception ex)
            {
                return RedirectToAction(nameof(Index),"Home");
            }
        }
        [Authorize]
        public IActionResult Perfil(Usuario u, String UrlReturn)
        {
            string url = Request.Headers["referer"].FirstOrDefault();
            Usuario usuViejo = uData.ObtenerPorId(u.Id);
            u.Rol = usuViejo.Rol;
            if (u.Clave == null || u.ClaveNueva == null)
            {
                u.Clave = usuViejo.Clave;
            }
            else
            {
                string hashedNuevo = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                   password: u.ClaveNueva,
                   salt: System.Text.Encoding.ASCII.GetBytes(configuration["Salt"]),
                   prf: KeyDerivationPrf.HMACSHA1,
                   iterationCount: 1000,
                   numBytesRequested: 256 / 8));

                string hashedViejo = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                   password: u.Clave,
                   salt: System.Text.Encoding.ASCII.GetBytes(configuration["Salt"]),
                   prf: KeyDerivationPrf.HMACSHA1,
                   iterationCount: 1000,
                   numBytesRequested: 256 / 8));
                if (usuViejo.Clave == hashedViejo)
                {
                    u.Clave = hashedNuevo;
                }
                else
                {
                    TempData["error"] = "La contraseña ingresada es incorrecta";
                    if (string.IsNullOrEmpty(url))
                    {
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        return Redirect(url);
                    }
                }
               

            }
            if (u.AvatarFile != null && u.Id > 0)
            {
                string wwwPath = environment.WebRootPath;
                if (usuViejo.Avatar != @"/Uploads\usuario.png")
                {
                    string urlAvatar = usuViejo.Avatar.Substring(1);
                    System.IO.File.Delete(Path.Combine(wwwPath, urlAvatar));
                }

                string path = Path.Combine(wwwPath, "Uploads");
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                //Path.GetFileName(u.AvatarFile.FileName);//este nombre se puede repetir
                string fileName = "avatar_" + u.Id + Path.GetExtension(u.AvatarFile.FileName);
                string pathCompleto = Path.Combine(path, fileName);
                u.Avatar = Path.Combine("/Uploads", fileName);
                using (FileStream stream = new FileStream(pathCompleto, FileMode.Create))
                {
                    u.AvatarFile.CopyTo(stream);
                }
                uData.Modificacion(u);
            }
            else
            {
                u.Avatar = usuViejo.Avatar;
                uData.Modificacion(u);
            }

            if (string.IsNullOrEmpty(url))
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return Redirect(url);
            }

        }
        [Authorize]
        [Route("[controller]/Datos", Name = "Datos")]
        public IActionResult Datos(IFormCollection correo)
        {
            try
            {
                var usu = uData.ObtenerPorEmail(correo["correo"]);
                usu.Clave = null;
                return Json(new { usu });
            }
            catch (Exception ex)
            {
                return Json(new { Error = ex.Message });
            }
        }

    }
}
