    
namespace Backend.models
{
    public class Card
    {
        public int CardId { get; set; }
        public string Name { get; set; }
        public int DeckId { get; set; }
        public Deck Deck { get; set; }
    }
}