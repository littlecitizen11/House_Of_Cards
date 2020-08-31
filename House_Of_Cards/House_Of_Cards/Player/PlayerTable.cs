using House_Of_Cards.IO.Input;
using House_Of_Cards.IO.Output;
using System;
using System.Collections.Generic;
using System.Text;

namespace House_Of_Cards
{
    /// <summary>
    /// TODO : REFACTOR
    /// </summary>
    public class PlayerTable
    {
        public Player[] Players { get; set; }
        public Pack TablePack { get; set; }
        public TableCards TableCard { get; set; }
        public int Disqualification { get; set; }

        public int NumberHints { get; set; }

        private ISystemInput _systemInput;
        private ISystemOutput _systemOutput;

        public int PlayersNumber { get; set; }

        


        public PlayerTable(int numofplayers , ISystemInput systemInput , ISystemOutput systemOutput)
        {
            PlayersNumber = numofplayers;
            NumberHints = 5;
            _systemInput = systemInput;
            _systemOutput = systemOutput;
            Disqualification = 0;
            TableCard = new TableCards();
            Players = new Player[numofplayers];
            TablePack = new PackFactory().Pack;
            InitPLayersTable();


        }

        private void InitPLayersTable() 
        {
            for (int i = 0; i < PlayersNumber; i++)
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
                            }
                    }


                }
            }
        }

        public bool KeepGameRunning() 
        {
            
            return NumberHints <= 5 && TablePack.CardsPack.Count > 0 && TableCard.NumberFinish <= 5;
        }


        public void PlayHouseGame() 
        {
            _systemOutput.Print("Welcom to house card game");
            //int count = 0;
            //Player player = Players[count];
            while (KeepGameRunning()) 
            {
                foreach (var player in Players)
                {
                    PrintInternalMenu(player);
                }
                //PrintInternalMenu(player);
               // count++;
               // player = Players[count];
            }
        }

        private void PrintInternalMenu(Player player) 
        {
            Card card = player.PlayCard();
            TableCard.InsertCardToBoard(card);
            TableCard.PrintTableSituation();

            /*_systemOutput.Print("Plaese entetr which option you want");
            _systemOutput.Print("1. play card");
           
            _systemOutput.Print("2. get hint");
            string chooise = _systemInput.GetStringInput();
            if (chooise == "1")
            {
                Card card = player.PlayCard();
                TableCard.InsertCardToBoard(card);
                
                return;
            }
            else if (chooise == "2")
            {
                player.ExploseCard();
                NumberHints--;
                return;
            }
            else {

                return;
            }*/
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
