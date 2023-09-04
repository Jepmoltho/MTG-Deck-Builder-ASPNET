using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Backend.Controllers;

public class MtgController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public MtgController(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> getDecks()
    {
        var decks = await _context.Decks.ToListAsync();
        return Ok(decks);
    }

    public async Task<IActionResult> getCards()
    {
        var cards = await _context.Cards.ToListAsync();
        return Ok(cards);
    }
}