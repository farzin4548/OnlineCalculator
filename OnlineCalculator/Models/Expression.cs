using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineCalculator.Models
{
    public class Expression
    {
        //ss2
        private IUSDGBPExchangeRateFeed uSDGBPExchangeRateFeed;

        public Expression(IUSDGBPExchangeRateFeed uSDGBPExchangeRateFeed)
        {
            this.uSDGBPExchangeRateFeed = uSDGBPExchangeRateFeed;
        }
        public Expression()
        {
        }
        public float Operand1
        {
            get; set;
        }
        public float Operand2 { get; set; }
        public Operator? Operators { get; set; }
        public int ConvertUSDtoGBP(int USDValue)
        {
            return this.uSDGBPExchangeRateFeed.GetGBPRate();
        }

        public float Result
        {
            get
            {
                if (!Operators.HasValue) { return 0; }
                switch (Operators.Value)
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

        public void Reset()
        {
            Operand1 = 0;
            Operand2 = 0;
        }
    }


    public enum Operator
    {
        SUBTRACTION, ADD, DEVIDE, MULTIPLY
    }
}