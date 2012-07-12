using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PolyTeam.Calculator
{
    public class CalculatorEngine

    {
        private Int32 answer;

        public Int32 Add(Int32 leftOperand,Int32 rightOperand)
        {
            this.answer = leftOperand + rightOperand;
            return this.answer;
        }

        public Int32 Substract(Int32 leftOperand,Int32 rightOperand)
        {
            this.answer = leftOperand - rightOperand;
            return this.answer;
        }

        public Int32 Multiply(Int32 leftOperand, Int32 rightOperand)
        {
            this.answer = leftOperand * rightOperand;
            return this.answer;
        }

        public Int32 Divide(Int32 leftOperand, Int32 rightOperand)
        {
            this.answer = leftOperand / rightOperand;
            return this.answer;
        }
    }
}
