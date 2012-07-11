using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PolyTeam.Calculator
{
    public interface ICalculatorEngine
    {
        int Add(int leftOperand, int rightOperand);
        int Substract(int leftOperand, int rightOperand);
        int Multiply(int leftOperand, int rightOperand);
        int Divide(int leftOperand, int rightOperand);
    }
}
