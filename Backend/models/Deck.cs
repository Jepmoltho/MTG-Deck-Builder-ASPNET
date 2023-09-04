namespace Backend.models
{
    public class Deck
    {
        public int DeckId { get; set; }
        public string Name { get; set; }
        public List<Card> Cards { get; set; } = new List<Card>();

    }
}
