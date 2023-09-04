using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;


    public class ApplicationDbContext : DbContext
    {
        public DbSet<Backend.models.Card> Cards { get; set; }
        public DbSet<Backend.models.Deck> Decks { get; set; }

        public string DbPath { get; }

        public ApplicationDbContext(){
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "mtg.db");
            //DbPath = $"{path}{System.IO.Path.DirectorySeparatorChar}card.db";
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite($"Data Source={DbPath}");
        // public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){ }
    }

    // public class Deck
    // {
    //     public int DeckId { get; set; }
    //     public string Name { get; set; }
    //     public List<Card> Cards { get; set; } = new List<Card>();

    // }


    // public class Card
    // {
    //     public int CardId { get; set; }
    //     public string Name { get; set; }
    //     public int DeckId { get; set; }
    //     public Deck Deck { get; set; }
    // }