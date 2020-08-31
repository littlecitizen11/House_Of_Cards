using System;
using System.Collections.Generic;
using System.Text;

namespace House_Of_Cards
{
    public class Card:INumber,IColor
    {
        public bool CanRead { get; set; }
        public Numbers Number { get; set; }
        public Colors Color { get; set; }
        public Card()
        {
            

        }
        public Card(Numbers num, Colors color)
        {
            Number = num;
            Color = color;
            CanRead = false;
        }
    }
}
