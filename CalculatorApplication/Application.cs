using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PolyTeam.Calculator;

namespace CalculatorApplication
{
    class Application
    {
        static void Main(string[] args)
        {
            var CalculatorApp = new CalculatorEngine();
            var inOut = new CalculatorDistributor();
            Int32 leftArgument;
            Int32 rightArgument;
            var answer = new Int32();
            leftArgument = inOut.GenericInput();
            string symbol = Console.ReadLine();
            rightArgument = inOut.GenericInput();
            if (symbol == "+")
            {
                answer = CalculatorApp.Add(leftArgument, rightArgument);
            }
            inOut.GenericOutput(answer);


        }
    }
}
