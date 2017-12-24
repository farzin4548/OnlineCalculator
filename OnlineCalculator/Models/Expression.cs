using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineCalculator.Models
{
    public class Expression
    {
        //tessssst
        public float Operand1 { get; set; }
        public float Operand2 { get; set; }
        public Operator Operator { get; set; }

        public float Result
        {
            get
            {
                switch (Operator)
                {
                    case Operator.SUBTRACTION:
                        return Operand1 - Operand2;
                    case Operator.ADD:
                        return Operand1 + Operand2;
                    case Operator.DEVIDE:
                        if (Operand2 == 0) throw new DivideByZeroException();
                        return Operand1 / Operand2;
                    case Operator.MULTIPLY:
                        return Operand1 * Operand2;
                    default:
                        return 0;
                }
            }
        }        
    }


    public enum Operator
    {
        SUBTRACTION, ADD, DEVIDE, MULTIPLY
    }
}