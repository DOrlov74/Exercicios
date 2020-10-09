using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Game_reg_1x1.Data;
using Game_reg_1x1.Models;

namespace Game_reg_1x1.Controllers
{
    public class GamesController : Controller
    {
        private readonly Game_regContext _context;

        public GamesController(Game_regContext context)
        {
            _context = context;
        }

        // GET: Games
        public async Task<IActionResult> Index()
        {
            var game_regContext = _context.Game.Include(g => g.Player1).Include(g => g.Player2).Include(g => g.Tournament);
            return View(await game_regContext.ToListAsync());
        }

        // GET: Games/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var game = await _context.Game
                .Include(g => g.Player1)
                .Include(g => g.Player2)
                .Include(g => g.Tournament)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (game == null)
            {
                return NotFound();
            }

            return View(game);
        }

        // GET: Games/Create
        public IActionResult Create()
        {
            ViewData["Player1Id"] = new SelectList(_context.Player, "Id", "Id");
            ViewData["Player2Id"] = new SelectList(_context.Player, "Id", "Id");
            ViewData["TournamentId"] = new SelectList(_context.Set<Tournament>(), "Id", "Id");
            return View();
        }

        // POST: Games/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Date,Player1Id,Player2Id,TournamentId")] Game game)
        {
            if (ModelState.IsValid)
            {
                _context.Add(game);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Player1Id"] = new SelectList(_context.Player, "Id", "Id", game.Player1Id);
            ViewData["Player2Id"] = new SelectList(_context.Player, "Id", "Id", game.Player2Id);
            ViewData["TournamentId"] = new SelectList(_context.Set<Tournament>(), "Id", "Id", game.TournamentId);
            return View(game);
        }

        // GET: Games/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var game = await _context.Game.FindAsync(id);
            if (game == null)
            {
                return NotFound();
            }
            ViewData["Player1Id"] = new SelectList(_context.Player, "Id", "Id", game.Player1Id);
            ViewData["Player2Id"] = new SelectList(_context.Player, "Id", "Id", game.Player2Id);
            ViewData["TournamentId"] = new SelectList(_context.Set<Tournament>(), "Id", "Id", game.TournamentId);
            return View(game);
        }

        // POST: Games/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Date,Player1Id,Player2Id,TournamentId")] Game game)
        {
            if (id != game.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(game);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GameExists(game.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["Player1Id"] = new SelectList(_context.Player, "Id", "Id", game.Player1Id);
            ViewData["Player2Id"] = new SelectList(_context.Player, "Id", "Id", game.Player2Id);
            ViewData["TournamentId"] = new SelectList(_context.Set<Tournament>(), "Id", "Id", game.TournamentId);
            return View(game);
        }

        // GET: Games/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var game = await _context.Game
                .Include(g => g.Player1)
                .Include(g => g.Player2)
                .Include(g => g.Tournament)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (game == null)
            {
                return NotFound();
            }

            return View(game);
        }

        // POST: Games/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var game = await _context.Game.FindAsync(id);
            _context.Game.Remove(game);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GameExists(int id)
        {
            return _context.Game.Any(e => e.Id == id);
        }
    }
}
