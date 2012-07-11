using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PolyTeam.Calculator
{
    public class CalculatorDistributor
    {
        private readonly ICalculatorOutput outputDirection;

        public CalculatorDistributor (ICalculatorOutput outputDirection)
        {
            this.outputDirection = outputDirection;
        }

        public CalculatorDistributor ( )
        {
            this.outputDirection = outputDirection;
        }

        public void GenericOutput ()
        {
            outputDirection.Out();
        }
    }
}
