using System;

namespace House_Of_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerTable pl = new PlayerTable(2);
            foreach (var item in pl.Players)
            {
                Console.WriteLine(item.Name+" : ");
                foreach (var i in item.Cards)
                {
                    Console.Write(i.Color +" ");
                    Console.WriteLine(i.Number);
                }
                Console.WriteLine("--------");
            }
        }
    }
}
