using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PolyTeam.Calculator
{
    public class CalculatorDistributor
    {
        private readonly ICalculatorOutput outputting;

        private readonly ICalculatorInput inputting;

        private Int32 EnteredValue;

        public CalculatorDistributor (ICalculatorOutput outputDirection, ICalculatorInput inputDirection)
        {
            this.outputting = outputDirection;
            this.inputting = inputDirection;
        }

        public CalculatorDistributor ( )
        {
            this.outputting = new ConsoleOut();
            this.inputting = new ConsoleIn();
        }

        public void GenericOutput (Int32 answerValue)
        {
            this.outputting.Out(answerValue);
        }

        public void GenericInput ()
        {
            this.EnteredValue = inputting.In();
        }
    }
}
