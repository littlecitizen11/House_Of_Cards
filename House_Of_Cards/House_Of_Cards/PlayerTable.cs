using System;
using System.Collections.Generic;
using System.Text;

namespace House_Of_Cards
{
    public class PlayerTable
    {
        public Player[] Players { get; set; }
        public Pack TablePack { get; set; }
        public TableCards TableCard { get; set; }
        public int Disqualification { get; set; }
        public PlayerTable(int numofplayers)
        {
            Disqualification = 0;
            TableCard = new TableCards();
            Players = new Player[numofplayers];
            TablePack = new PackFactory().Pack;
            for (int i = 0; i < numofplayers; i++)
            {
                Console.WriteLine("Enter nane of player");
                Players[i] = new Player(Console.ReadLine());
                for (int j = 0; j < 5; j++)
                {
                    Players[i].Cards.Add(RandomPickCard());
                }
            }
        }
        public void PlayGame()
        {
            while(Disqualification<4&&TablePack.CardsPack.Count>0)
            {
                for (int i = 0; i < Players.Length; i++)
                {
                    var c = Players[i].PlayCard();
                    if (c.Number == Numbers.One)
                    {
                        foreach (var item in TableCard.Cards)
                        {
                            if (item.CardsPack == null)
                                item.CardsPack.Add(c);
                        }
                    }
                    foreach (var item in TableCard.Cards)
                    {
                        if (item.CardsPack != null)
                            foreach (var card in item.CardsPack)
                            {
                                if(card.Color==c.Color&&Enum)
                            }
                    }


                }
            }
        }
        public Card RandomPickCard()
        {
            Random rnd = new Random();
            Card card;
            card = TablePack.CardsPack[rnd.Next(0, TablePack.CardsPack.Count)];
            TablePack.CardsPack.Remove(card);
            return card;
        }
    }
}
