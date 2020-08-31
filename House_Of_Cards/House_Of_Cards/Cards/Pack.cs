using System;
using System.Collections.Generic;
using System.Text;

namespace House_Of_Cards
{
    public class Pack
    {
        public List<Card> CardsPack { get; set; }
        public Pack()
        {
            CardsPack = new List<Card>();
        }
    }
}
