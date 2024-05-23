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
    public class MeusJogosController : Controller
    {
        private readonly AppDbContext _context;

        public MeusJogosController(AppDbContext context)
        {
            _context = context;
        }

        // LISTA DE JOGOS DO USUARIO
        [Authorize]
        public async Task<IActionResult> Index()
        {
            var jogo = await _context.Jogos
                .OrderBy(x => x.Nome)
                .ToListAsync();

            return View(jogo);
        }

        // ADICIONAR JOGO
        [Authorize]
        public IActionResult AdicionarJogo()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> AdicionarJogo(Jogo jogo)
        {
            if (ModelState.IsValid)
            {
                _context.Jogos.Add(jogo);
                await _context.SaveChangesAsync();

                return RedirectToAction("Index");
            }

            return View(jogo);
        }

        // EDITAR JOGO
        [Authorize]
        public async Task<IActionResult> EditarJogo(int? id)
        {
            if (id == null)
                return NotFound();

            var jogo = await _context.Jogos.FindAsync(id);

            if (jogo == null)
                return NotFound();

            return View(jogo);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> EditarJogo(int id, Jogo jogo)
        {
            if (id != jogo.Id)
                return NotFound();

            if (ModelState.IsValid)
            {
                _context.Jogos.Update(jogo);
                await _context.SaveChangesAsync();

                return RedirectToAction("Index");
            }

            return View();
        }

        // DELETAR JOGO
        [Authorize]
        public async Task<IActionResult> DeletarJogo(int? id)
        {
            if (id == null)
                return NotFound();

            var jogo = await _context.Jogos.FindAsync(id);

            if (jogo == null)
                return NotFound();

            return View(jogo);
        }

        [HttpPost, ActionName("DeletarJogo")]
        [Authorize]
        public async Task<IActionResult> DeletarJogoConfirmed(int? id)
        {
            if (id == null)
                return NotFound();

            var jogo = await _context.Jogos.FindAsync(id);

            if (jogo == null)
                return NotFound();

            _context.Jogos.Remove(jogo);
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