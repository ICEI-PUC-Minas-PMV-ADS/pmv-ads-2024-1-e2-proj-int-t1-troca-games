using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using troca_games.Models;

namespace troca_games.Controllers
{
    public class JogosReservadosController : Controller
    {
        private readonly AppDbContext _context;

        public JogosReservadosController(AppDbContext context)
        {
            _context = context;
        }

        // LISTA DE JOGOS RESERVADOS
        [Authorize]
        public async Task<IActionResult> Index()
        {
            var jogo = await _context.Jogos
                .OrderBy(x => x.Nome)
                .ToListAsync();

            return View(jogo);
        }

        // RESERVAR JOGO
        [Authorize]
        public async Task<IActionResult> ReservarJogo(int? id)
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
        public async Task<IActionResult> ReservarJogo(int id, Jogo jogo)
        {
            if (id != jogo.Id)
                return NotFound();

            if (ModelState.IsValid)
            {
                _context.Jogos.Update(jogo);
                await _context.SaveChangesAsync();

                return RedirectToAction("JogoReservado");
            }

            return View();
        }

        // MENSAGEM JOGO RESERVADO
        [AllowAnonymous]
        public IActionResult JogoReservado()
        {
            return View();
        }

        // CANCELAR RESERVA
        [Authorize]
        public async Task<IActionResult> CancelarReserva(int? id)
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
        public async Task<IActionResult> CancelarReserva(int id, Jogo jogo)
        {
            if (id != jogo.Id)
                return NotFound();

            if (ModelState.IsValid)
            {
                _context.Jogos.Update(jogo);
                await _context.SaveChangesAsync();

                return RedirectToAction("ReservaCancelada");
            }

            return View();
        }

        // MENSAGEM JOGO CANCELADO
        [AllowAnonymous]
        public IActionResult ReservaCancelada()
        {
            return View();
        }
    }
}
