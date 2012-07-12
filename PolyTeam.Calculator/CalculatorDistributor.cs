using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PolyTeam.Calculator
{
    public class CalculatorDistributor
    {
        private readonly ICalculatorOutput outputting;

        public int AnswerValue;

        public CalculatorDistributor (ICalculatorOutput outputDirection)
        {
            this.outputting = outputDirection;
        }

        public CalculatorDistributor ( )
        {
            this.outputting = new ConsoleOut();
        }

        public void GenericOutput ()
        {
            this.outputting.Out(AnswerValue);
        }
    }
}
