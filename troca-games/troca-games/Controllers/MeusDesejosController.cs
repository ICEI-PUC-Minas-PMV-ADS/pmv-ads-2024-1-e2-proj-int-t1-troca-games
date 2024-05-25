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
    public class MeusDesejosController : Controller
    {
        private readonly AppDbContext _context;

        public MeusDesejosController(AppDbContext context)
        {
            _context = context;
        }

        // LISTA DE JOGOS DE DESEJOS
        public async Task<IActionResult> Index()
        {
            var desejo = await _context.Desejos
                .Include(d => d.Jogo)
                .ToListAsync();

            return View(desejo);
        }

        // ADICIONAR DESEJO
        public IActionResult Adicionar()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Adicionar(Desejo desejo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(desejo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(desejo);
        }

        // DELETAR DESEJO
        [Authorize]
        public async Task<IActionResult> DeletarDesejo(int? id)
        {
            if (id == null)
                return NotFound();

            var desejo = await _context.Desejos.FindAsync(id);

            if (desejo == null)
                return NotFound();

            return View(desejo);
        }

        [HttpPost, ActionName("DeletarDesejo")]
        [Authorize]
        public async Task<IActionResult> DeletarDesejoConfirmed(int? id)
        {
            if (id == null)
                return NotFound();

            var desejo = await _context.Desejos.FindAsync(id);

            if (desejo == null)
                return NotFound();

            _context.Desejos.Remove(desejo);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        // DETALHES JOGO
        [Authorize]
        public async Task<IActionResult> DetalhesJogo(int? id)
        {
            if (id == null)
                return NotFound();

            var jogo = await _context.Jogos.FindAsync(id);

            if (jogo == null)
                return NotFound();

            return View(jogo);
        }
    }
}
