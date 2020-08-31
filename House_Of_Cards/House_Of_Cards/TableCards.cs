using System;
using System.Collections.Generic;
using System.Text;

namespace House_Of_Cards
{
    public class TableCards
    {
        public List<Pack> Cards { get; set; }
        public TableCards()
        {
            Cards = new List<Pack>();
            Cards.Add(new Pack());
            Cards.Add(new Pack());
            Cards.Add(new Pack());
            Cards.Add(new Pack());
            Cards.Add(new Pack());
        }
    }
}
