using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using SoccerPlayers.Data;
using SoccerPlayers.Models;

namespace SoccerPlayers.Controllers
{
    public class SoccerPlayersController : Controller
    {
        private readonly SoccerPlayersContext _context;

        public SoccerPlayersController(SoccerPlayersContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.SoccerPlayer.ToListAsync());
        }


        public async Task<IActionResult> Create()
        {
            var commandNames = await _context.SoccerPlayer.Select(p => p.CommandName).Distinct().ToListAsync();
            commandNames ??= [];
            ViewData["CommandNames"] = commandNames;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,SecondName,Birthday,CommandName,Country,Gender")] SoccerPlayer soccerPlayer)
        {
            if (ModelState.IsValid)
            {
                _context.Add(soccerPlayer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(soccerPlayer);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var soccerPlayer = await _context.SoccerPlayer.FindAsync(id);
            var commandNames = await _context.SoccerPlayer.Select(p => p.CommandName).Distinct().ToListAsync();
            commandNames ??= [];
            ViewData["CommandNames"] = commandNames;
            if (soccerPlayer == null)
            {
                return NotFound();
            }
            return View(soccerPlayer);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,SecondName,Birthday,CommandName,Country,Gender")] SoccerPlayer soccerPlayer)
        {
            if (id != soccerPlayer.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(soccerPlayer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SoccerPlayerExists(soccerPlayer.Id))
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
            return View(soccerPlayer);
        }

        private bool SoccerPlayerExists(int id)
        {
            return _context.SoccerPlayer.Any(e => e.Id == id);
        }
    }
}
