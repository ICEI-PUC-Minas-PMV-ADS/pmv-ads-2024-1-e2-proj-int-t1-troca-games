﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using troca_games.Models;

namespace troca_games.Controllers
{
    public class NotificacoesController : Controller
    {
        private readonly AppDbContext _context;

        public NotificacoesController(AppDbContext context)
        {
            _context = context;
        }

        // LISTA DE NOTIFICACOES
        [Authorize]
        public async Task<IActionResult> Index()
        {
            var jogo = await _context.Jogos
                .OrderBy(x => x.Nome)
                .ToListAsync();

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
