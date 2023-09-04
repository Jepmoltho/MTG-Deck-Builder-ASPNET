using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
//Refactor to use Controller 
using Backend.models;
using Backend.Controllers;


namespace aspnet_training.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    public List<Deck> Decks { get; set; } = new List<Deck>();
    public List<Card> Cards { get; set; } = new List<Card>();
    // private readonly MtgController _mtgController;


    public IndexModel(ILogger<IndexModel> logger /*, MtgController mtgController*/)
    {
        _logger = logger;
        // _mtgController = mtgController;
    }

    public void OnGet()
    {
        using var db = new ApplicationDbContext();
        Decks = db.Decks.ToList();
        Cards = db.Cards.ToList();
    }
    // public async Task OnGetAsync()
    // {
    //     // Call the getDecks method of MtgController
    //     var decksResult = await _mtgController.getDecks() as ObjectResult;
    //     if (decksResult != null && decksResult.StatusCode == 200)
    //     {
    //         Decks = decksResult.Value as List<Deck>;
    //     }

    //     // Call the getCards method of MtgController
    //     var cardsResult = await _mtgController.getCards() as ObjectResult;
    //     if (cardsResult != null && cardsResult.StatusCode == 200)
    //     {
    //         Cards = cardsResult.Value as List<Card>;
    //     }
    // }
}
