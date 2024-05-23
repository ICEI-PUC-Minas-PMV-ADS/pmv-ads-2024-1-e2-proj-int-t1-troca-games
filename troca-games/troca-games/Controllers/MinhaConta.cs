using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using troca_games.Models;

namespace troca_games.Controllers
{
    public class MinhaConta : Controller
    {
        private readonly AppDbContext _context;

        public MinhaConta(AppDbContext context)
        {
            _context = context;
        }

        // CONTA USUARIO
        [Authorize]
        public async Task<IActionResult> Index()
        {
            var usuarios = await _context.Usuarios
                .OrderBy(j => j.Nome)
                .ToListAsync();

            return View(usuarios);
        }

        // EDITAR CONTA
        [Authorize]
        public async Task<IActionResult> Editar(int? id)
        {
            if (id == null)
                return NotFound();

            var usuario = await _context.Usuarios.FindAsync(id);

            if (usuario == null)
                return NotFound();

            return View(usuario);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Editar(int id, Usuario usuario)
        {
            if (id != usuario.Id)
                return NotFound();

            if (ModelState.IsValid)
            {
                usuario.Senha = BCrypt.Net.BCrypt.HashPassword(usuario.Senha);

                _context.Usuarios.Update(usuario);
                await _context.SaveChangesAsync();
                await HttpContext.SignOutAsync();

                return RedirectToAction("ContaAtualizada");
            }

            return View();
        }

        // MENSAGEM CONTA ATUALIZADA
        [AllowAnonymous]
        public IActionResult ContaAtualizada()
        {
            return View();
        }

        // DELETAR CONTA
        [Authorize]
        public async Task<IActionResult> Deletar(int? id)
        {
            if (id == null)
                return NotFound();

            var usuario = await _context.Usuarios.FindAsync(id);

            if (usuario == null)
                return NotFound();

            return View(usuario);
        }

        [HttpPost, ActionName("Deletar")]
        [Authorize]
        public async Task<IActionResult> DeletarConfirmed(int? id)
        {
            if (id == null)
                return NotFound();

            var usuario = await _context.Usuarios.FindAsync(id);

            if (usuario == null)
                return NotFound();

            _context.Usuarios.Remove(usuario);
            await _context.SaveChangesAsync();
            await HttpContext.SignOutAsync();

            return RedirectToAction("ContaDeletada");
        }

        // MENSAGEM CONTA DELETADA
        [AllowAnonymous]
        public IActionResult ContaDeletada()
        {
            return View();
        }
    }
}
