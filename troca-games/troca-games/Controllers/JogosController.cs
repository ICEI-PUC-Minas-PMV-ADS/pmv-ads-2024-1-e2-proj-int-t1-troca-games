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
    public class JogosController : Controller
    {
        private readonly AppDbContext _context;

        public JogosController(AppDbContext context)
        {
            _context = context;
        }

        // LISTA DE JOGOS
        [Authorize]
        public async Task<IActionResult> Index(string searchString)
        {
            var jogo = await _context.Jogos
                .OrderBy(j => j.Nome)
                .ToListAsync();

            if (!String.IsNullOrEmpty(searchString))
            {
                jogo = jogo.Where(s => s.Nome.Contains(searchString)).ToList();
            }

            return View(jogo);
        }

        // LISTA DE JOGOS DISPONIVEIS
        [Authorize]
        public async Task<IActionResult> Disponiveis(string searchString)
        {
            var jogo = await _context.Jogos
                .OrderBy(j => j.Nome)
                .ToListAsync();

            if (!String.IsNullOrEmpty(searchString))
            {
                jogo = jogo.Where(s => s.Nome.Contains(searchString)).ToList();
            }

            return View(jogo);
        }

        // LISTA DE JOGOS A VENDA
        [Authorize]
        public async Task<IActionResult> Venda(string searchString)
        {
            var jogo = await _context.Jogos
                .OrderBy(j => j.Nome)
                .ToListAsync();

            if (!String.IsNullOrEmpty(searchString))
            {
                jogo = jogo.Where(s => s.Nome.Contains(searchString)).ToList();
            }

            return View(jogo);
        }

        // LISTA DE JOGOS PARA ALUGAR
        [Authorize]
        public async Task<IActionResult> Aluguel(string searchString)
        {
            var jogo = await _context.Jogos
                .OrderBy(j => j.Nome)
                .ToListAsync();

            if (!String.IsNullOrEmpty(searchString))
            {
                jogo = jogo.Where(s => s.Nome.Contains(searchString)).ToList();
            }

            return View(jogo);
        }

        // LISTA DE JOGOS NOVOS
        [Authorize]
        public async Task<IActionResult> Novos(string searchString)
        {
            var jogo = await _context.Jogos
                .OrderBy(j => j.Nome)
                .ToListAsync();

            if (!String.IsNullOrEmpty(searchString))
            {
                jogo = jogo.Where(s => s.Nome.Contains(searchString)).ToList();
            }

            return View(jogo);
        }

        // LISTA DE JOGOS USADOS
        [Authorize]
        public async Task<IActionResult> Usados(string searchString)
        {
            var jogo = await _context.Jogos
                .OrderBy(j => j.Nome)
                .ToListAsync();

            if (!String.IsNullOrEmpty(searchString))
            {
                jogo = jogo.Where(s => s.Nome.Contains(searchString)).ToList();
            }

            return View(jogo);
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
