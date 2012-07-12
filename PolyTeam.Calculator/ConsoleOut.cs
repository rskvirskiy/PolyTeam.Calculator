using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PolyTeam.Calculator
{
    public class ConsoleOut:ICalculatorOutput
    {
        public void Out(Int32 answerValue)
        {
            Console.WriteLine(" = ",answerValue);
            Console.ReadLine();
        }
    }
}
