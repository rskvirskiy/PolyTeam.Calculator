using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PolyTeam.Calculator
{
    public class ConsoleOut:ICalculatorOutput
    {
        public void Out(int answerValue)
        {
            Console.WriteLine(" = ",answerValue);
        }
    }
}
