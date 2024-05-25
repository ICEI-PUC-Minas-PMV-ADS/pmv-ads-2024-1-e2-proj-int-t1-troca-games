using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using troca_games.Models;

namespace troca_games.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly AppDbContext _context;

        public UsuariosController(AppDbContext context)
        {
            _context = context;
        }

        // LISTA DE USUARIOS
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Index()
        {
            var usuario = await _context.Usuarios
                .OrderBy(x => x.Nome)
                .ToListAsync();

            return View(usuario);
        }

        // CADASTRAR USUARIO
        [AllowAnonymous]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Cadastrar(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                usuario.Senha = BCrypt.Net.BCrypt.HashPassword(usuario.Senha);

                _context.Usuarios.Add(usuario);
                await _context.SaveChangesAsync();

                return RedirectToAction("CadastroRealizado");
            }
            return View(usuario);
        }

        // MENSAGEM CADASTRO REALIZADO
        [AllowAnonymous]
        public IActionResult CadastroRealizado()
        {
            return View();
        }

        // LOGIN USUARIO
        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(Usuario usuario)
        {
            var dados = await _context.Usuarios
                .Where(u => u.Email == usuario.Email)
                .FirstOrDefaultAsync();

            if (dados == null)
            {
                ViewBag.message = "Usuário ou senha inválidos!";

                return View();
            }

            bool senhaValida = BCrypt.Net.BCrypt.Verify(usuario.Senha, dados.Senha);

            if (senhaValida)
            {
                var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, dados.Nome),
                        new Claim(ClaimTypes.NameIdentifier, dados.Id.ToString()),
                        new Claim(ClaimTypes.Email, dados.Email.ToString()),
                        new Claim(ClaimTypes.Role, dados.Perfil.ToString()),
                    };

                var usuarioIdentity = new ClaimsIdentity(claims, "Login");
                ClaimsPrincipal principal = new ClaimsPrincipal(usuarioIdentity);

                var props = new AuthenticationProperties
                {
                    AllowRefresh = true,
                    ExpiresUtc = DateTime.UtcNow.ToLocalTime().AddHours(8),
                    IsPersistent = true,
                };

                await HttpContext.SignInAsync(principal, props);

                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.message = "Usuário ou senha inválidos!";
            }

            return View();
        }

        // LOGOUT USUARIO
        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();

            return RedirectToAction("Index", "Home");
        }

        // DELETAR USUARIO
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeletarUsuario(int? id)
        {
            if (id == null)
                return NotFound();

            var usuario = await _context.Usuarios.FindAsync(id);
            
            if (usuario == null)
                return NotFound();

            return View(usuario);
        }

        [HttpPost, ActionName("DeletarUsuario")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeletarUsuarioConfirmed(int? id)
        {
            if (id == null)
                return NotFound();

            var usuario = await _context.Usuarios.FindAsync(id);

            if (usuario == null)
                return NotFound();
            
            _context.Usuarios.Remove(usuario);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}
