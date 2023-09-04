using System;
using System.Linq;
using Backend.models;

namespace SeedDb
{
    public class DbSeeder
    {
        public static void seedTheDb()
        {

            using var db = new ApplicationDbContext();

            //Create
            // Deck Alpha = new Deck { Name = "Alpha" };
            // db.Add(Alpha);
            // Deck Beta = new Deck { Name = "Beta" };
            // db.Add(Beta);
            // Deck Unlimited = new Deck { Name = "Unlimited" };
            // db.Add(Unlimited);

            // db.Add(new Card { Name = "Black Lotus", DeckId = 1, Deck = Alpha });
            // db.Add(new Card { Name = "Mox Sapphire", DeckId = 1, Deck = Alpha });
            // db.Add(new Card { Name = "Mox Jet", DeckId = 1, Deck = Alpha });
            // db.Add(new Card { Name = "Mox Ruby", DeckId = 2, Deck = Beta });


            db.SaveChanges();

            Console.WriteLine("Getting all cards");
            var cards = db.Cards
                .OrderBy(b => b.CardId)
                .ToList();

            //Update
            // Console.WriteLine("Adding a cards to decks");
            // foreach (Card card in cards)
            // {
            //     if (card.DeckId == 1)
            //     {
            //         Alpha.Cards.Add(card);
            //     }
            //     if (card.DeckId == 2)
            //     {
            //         Beta.Cards.Add(card);
            //     }
            //     if (card.DeckId == 3)
            //     {
            //         Unlimited.Cards.Add(card);
            //     }
            // }

            //printing all decks and their cards
            Console.WriteLine("Printing all decks and their cards");
            foreach (Deck deck in db.Decks)
            {
                Console.WriteLine($"Deck: {deck.Name}");
                foreach (Card card in deck.Cards)
                {
                    Console.WriteLine(" " + $"Card: {card.Name}");
                }
            }


            //Delete
            // foreach (Deck deck in db.Decks){
            //     db.Remove(deck);
            // }

            // foreach (Card card in cards){
            //     db.Remove(card);
            // }
            db.SaveChanges();
        }
    }

}

// using var db = new ApplicationDbContext();
// Console.WriteLine($"db.DbPath: {db.DbPath}");
// Console.WriteLine("Inserting new Deck");


// //Create
// Deck Alpha = new Deck{Name = "Alpha"};
// db.Add(Alpha);
// Deck Beta = new Deck{Name = "Beta"};
// db.Add(Beta);
// Deck Unlimited = new Deck{Name = "Unlimited"};
// db.Add(Unlimited);

// db.Add(new Card{Name = "Black Lotus", DeckId = 1, Deck = Alpha});
// db.Add(new Card{Name = "Mox Sapphire", DeckId = 1, Deck = Alpha});
// db.Add(new Card{Name = "Mox Jet", DeckId = 1, Deck = Alpha});
// db.Add(new Card{Name = "Mox Ruby", DeckId = 2, Deck = Beta});
// db.SaveChanges();

// Console.WriteLine("Getting all cards");
// var cards = db.Cards
//     .OrderBy(b => b.CardId)
//     .ToList();

// //Update
// Console.WriteLine("Adding a cards to decks");
// foreach (Card card in cards){
//     if (card.DeckId == 1){
//         Alpha.Cards.Add(card);
//     }
//     if (card.DeckId == 2){
//         Beta.Cards.Add(card);
//     }
//     if (card.DeckId == 3){
//         Unlimited.Cards.Add(card);
//     }
// }


// //printing all decks and their cards
// Console.WriteLine("Printing all decks and their cards");
// foreach (Deck deck in db.Decks){
//     Console.WriteLine($"Deck: {deck.Name}");
//     foreach (Card card in deck.Cards){
//         Console.WriteLine(" " + $"Card: {card.Name}");
//     }
// }


// //Delete
// foreach (Deck deck in db.Decks){
//     db.Remove(deck);
// }

// foreach (Card card in cards){
//     db.Remove(card);
// }
// db.SaveChanges();