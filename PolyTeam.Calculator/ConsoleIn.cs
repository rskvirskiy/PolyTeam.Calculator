using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PolyTeam.Calculator
{
    public class ConsoleIn:ICalculatorInput
    {
        public Int32 In()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
