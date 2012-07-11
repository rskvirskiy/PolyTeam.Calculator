using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PolyTeam.Calculator
{
    public class CalculatorEngine : ICalculatorEngine

    {
        public int Add(int leftOperand,int rightOperand)
        {
            return leftOperand + rightOperand;
        }

        public int Substract(int leftOperand,int rightOperand)
        {
            return leftOperand-rightOperand;
        }

        public int Multiply(int leftOperand, int rightOperand)
        {
            return leftOperand*rightOperand;
        }

        public int Divide(int leftOperand, int rightOperand)
        {
            return leftOperand/rightOperand;
        }
    }
}
