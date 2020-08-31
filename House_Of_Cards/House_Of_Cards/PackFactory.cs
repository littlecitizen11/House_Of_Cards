using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace House_Of_Cards
{
    public class PackFactory
    {
        public Pack Pack { get; set; }
        public PackFactory()
        {
            Pack = new Pack();
            for (int i = 0; i < 50; i += 10)
            {
                Pack.CardsPack.AddRange(GenerateCardByColor((Colors)(i / 10)));
            }
        }
        public Card[] GenerateCardByColor(Colors color)
        {
            Card[] generatedCards = new Card[10];
            for (int i = 0; i < generatedCards.Length; i++)
            {
                generatedCards[i] = new Card();
                generatedCards[i].Color = color;
            }
            generatedCards[0].Number=Numbers.One;
            generatedCards[1].Number = Numbers.One;
            generatedCards[2].Number = Numbers.One;
            generatedCards[3].Number = Numbers.Two;
            generatedCards[4].Number = Numbers.Two;
            generatedCards[5].Number = Numbers.Three;
            generatedCards[6].Number = Numbers.Three;
            generatedCards[7].Number = Numbers.Four;
            generatedCards[8].Number = Numbers.Four;
            generatedCards[9].Number = Numbers.Five;
            return generatedCards;
        }
        

    }
}
