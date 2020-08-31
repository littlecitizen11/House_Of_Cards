using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace House_Of_Cards
{
    public class Player
    {
        public List<Card> Cards { get; set; }
        public string Name { get; set; }
        public Player(string name)
        {
            Name = name;
            Cards = new List<Card>();
        }
        public Card PlayCard()
        {
            Random rnd = new Random();
            Card card = Cards[rnd.Next(0, Cards.Count)];
            Cards.Remove(card);
            return card;
        }
    }
}
