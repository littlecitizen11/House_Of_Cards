using System;
using System.Collections.Generic;
using System.Text;

namespace House_Of_Cards.IO.Input
{
    public class ConoleInput : ISystemInput
    {
        public int GeIntInput()
        {
            return int.Parse(Console.ReadLine());
        }

        public string GetStringInput()
        {
            return Console.ReadLine();
        }
    }
}
