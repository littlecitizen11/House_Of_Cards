using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace House_Of_Cards
{
    public class TableCards
    {
        public List<Pack> Cards { get; set; }


        public Dictionary<Colors, List<Card>> CardBoard { get; set; }

        public int NumberFinish { get; set; }


        public TableCards()
        {
            NumberFinish = 0;
            CardBoard = new Dictionary<Colors, List<Card>>();
            Cards = new List<Pack>();
            Cards.Add(new Pack());
            Cards.Add(new Pack());
            Cards.Add(new Pack());
            Cards.Add(new Pack());
            Cards.Add(new Pack());
        }
        

        public void PrintTableSituation() 
        {
            Console.WriteLine("-------------------------------------------------------------------");
            foreach (var cardColor in CardBoard)
            {
                Console.WriteLine($"Color : {cardColor.ToString()}");
                foreach (var card in cardColor.Value)
                {
                    Console.WriteLine($"card number : {(int)card.Number}");
                }
            }
            Console.WriteLine("-------------------------------------------------------------------");
        }


        public void InsertCardToBoard(Card card)
        {
            if (CardBoard.ContainsKey(card.Color))
            {
                List<Card> cards = CardBoard[card.Color];
                Card lastCard = cards.LastOrDefault();
                if (lastCard != null)
                {
                    int lastNumberCard = (int)lastCard.Number;
                    int numberCardToInsert = (int)card.Number;
                    if (lastNumberCard + 1 == numberCardToInsert)
                    {
                        CardBoard[card.Color].Add(card);
                        if (numberCardToInsert == 5)
                        {
                            NumberFinish++;
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Cant add card {numberCardToInsert} beacuse last number is {lastNumberCard}");
                    }
                }
                else
                {
                    if (card.Number == Numbers.One)
                    {
                        CardBoard[card.Color].Add(card);
                    }
                }
            }
            else
            {
                if (card.Number == Numbers.One)
                {
                    CardBoard.Add(card.Color, new List<Card>() { card });
                }
            }
        }
    }
}
