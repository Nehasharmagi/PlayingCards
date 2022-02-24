using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PlayingCards.Data;
using PlayingCards.Models;

namespace PlayingCards.Controllers
{
    public class PlayingCardsController : Controller
    {
        private readonly PlayingCardsContext _context;

        public PlayingCardsController(PlayingCardsContext context)
        {
            _context = context;
        }

        // GET: PlayingCards
        public async Task<IActionResult> Index()
        {
            return View(await _context.PlayingCard.ToListAsync());
        }

        // GET: PlayingCards/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var playingCard = await _context.PlayingCard
                .FirstOrDefaultAsync(m => m.Id == id);
            if (playingCard == null)
            {
                return NotFound();
            }

            return View(playingCard);
        }

        // GET: PlayingCards/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PlayingCards/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NameOfCard,ReleaseDate,TypeOfCard,Price,Rating")] PlayingCard playingCard)
        {
            if (ModelState.IsValid)
            {
                _context.Add(playingCard);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(playingCard);
        }

        // GET: PlayingCards/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var playingCard = await _context.PlayingCard.FindAsync(id);
            if (playingCard == null)
            {
                return NotFound();
            }
            return View(playingCard);
        }

        // POST: PlayingCards/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NameOfCard,ReleaseDate,TypeOfCard,Price,Rating")] PlayingCard playingCard)
        {
            if (id != playingCard.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(playingCard);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PlayingCardExists(playingCard.Id))
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
            return View(playingCard);
        }

        // GET: PlayingCards/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var playingCard = await _context.PlayingCard
                .FirstOrDefaultAsync(m => m.Id == id);
            if (playingCard == null)
            {
                return NotFound();
            }

            return View(playingCard);
        }

        // POST: PlayingCards/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var playingCard = await _context.PlayingCard.FindAsync(id);
            _context.PlayingCard.Remove(playingCard);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PlayingCardExists(int id)
        {
            return _context.PlayingCard.Any(e => e.Id == id);
        }
    }
}
