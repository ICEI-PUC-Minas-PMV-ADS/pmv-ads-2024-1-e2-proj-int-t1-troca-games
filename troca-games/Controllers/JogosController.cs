using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using troca_games.Models;

namespace troca_games.Controllers
{
    [Authorize]
    public class JogosController : Controller
    {
        private readonly AppDbContext _context;

        public JogosController(AppDbContext context)
        {
            _context = context;
        }

        // LISTA JOGO
        public async Task<IActionResult> Index(string searchString)
        {
            var jogo = await _context.Jogos
                .Include(j => j.Usuario)
                .OrderBy(j => j.Nome)
                .ToListAsync();

            if (!String.IsNullOrEmpty(searchString))
            {
                jogo = jogo.Where(s => s.Nome.Contains(searchString)).ToList();
            }

            return View(jogo);
        }

        // DETALHES JOGO
        public async Task<IActionResult> DetalhesJogo(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jogo = await _context.Jogos
                .Include(j => j.Usuario)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (jogo == null)
            {
                return NotFound();
            }

            ViewBag.Jogo = jogo;

            return View(jogo);
        }

        // LISTA JOGOS USUARIO
        public async Task<IActionResult> MeusJogos()
        {
            var jogo = await _context.Jogos
                .Include(j => j.Usuario)
                .OrderBy(j => j.Nome)
                .ToListAsync();

            return View(jogo);
        }

        // ADICIONAR JOGO
        public IActionResult AdicionarJogo()
        {
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "Id", "Nome");

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AdicionarJogo([Bind("Id,Nome,Console,NegociacaoJogo,CondicaoJogo,Valor,UsuarioId")] Jogo jogo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(jogo);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(MeusJogos));
            }
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "Id", "Nome", jogo.UsuarioId);
            
            return View(jogo);
        }

        // EDITAR JOGO
        public async Task<IActionResult> EditarJogo(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jogo = await _context.Jogos.FindAsync(id);

            if (jogo == null)
            {
                return NotFound();
            }

            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "Id", "Nome", jogo.UsuarioId);

            return View(jogo);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditarJogo(int id, [Bind("Id,Nome,Console,NegociacaoJogo,CondicaoJogo,Valor,UsuarioId")] Jogo jogo)
        {
            if (id != jogo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(jogo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!JogoExists(jogo.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                
                return RedirectToAction(nameof(MeusJogos));
            }

            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "Id", "Nome", jogo.UsuarioId);

            return View(jogo);
        }

        // DELETAR JOGO
        public async Task<IActionResult> DeletarJogo(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jogo = await _context.Jogos
                .Include(j => j.Usuario)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (jogo == null)
            {
                return NotFound();
            }

            return View(jogo);
        }

        [HttpPost, ActionName("DeletarJogo")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeletarJogoConfirmed(int id)
        {
            var jogo = await _context.Jogos.FindAsync(id);

            if (jogo != null)
            {
                _context.Jogos.Remove(jogo);
            }

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(MeusJogos));
        }

        private bool JogoExists(int id)
        {
            return _context.Jogos.Any(e => e.Id == id);
        }

    }
}
