using System;
using System.Collections.Generic;
using System.Text;

namespace House_Of_Cards.IO.Output
{
    public class ConsoleOutput : ISystemOutput
    {
        public void Print(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
