using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PolyTeam.Calculator
{
    public class CalculatorEngine

    {
        public int answer;

        public int Add(int leftOperand,int rightOperand)
        {
            this.answer = leftOperand + rightOperand;
            return answer;
        }

        public int Substract(int leftOperand,int rightOperand)
        {
            this.answer = leftOperand - rightOperand;
            return answer;
        }

        public int Multiply(int leftOperand, int rightOperand)
        {
            this.answer = leftOperand * rightOperand;
            return answer;
        }

        public int Divide(int leftOperand, int rightOperand)
        {
            this.answer = leftOperand / rightOperand;
            return answer;
        }
    }
}
