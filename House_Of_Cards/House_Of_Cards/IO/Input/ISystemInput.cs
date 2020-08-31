using System;
using System.Collections.Generic;
using System.Text;

namespace House_Of_Cards.IO.Input
{
    public interface ISystemInput
    {
        string GetStringInput();

        int GeIntInput();
    }
}
