using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineCalculator.Models
{
    public class StringCalculation
    {
        public int Add(string expr)
        {
            //if(expr == string.Empty) { return 0; }
            if (string.IsNullOrWhiteSpace(expr)) return 0;

            var splitedExpr = expr.Split(new char[] { ',', '\n' });
            if (splitedExpr.Length > 2 || splitedExpr.Length < 2)
                throw new ArgumentException();
            if((splitedExpr[0]).Contains("-") ||(splitedExpr[1]).Contains("-"))
                throw new ArgumentException();

            return int.Parse(splitedExpr[0]) + int.Parse(splitedExpr[1]);
        }

        public double Sinus(string expr)
        {
            double result = Math.Sin(double.Parse(expr));
            return Math.Round(result,0);
        }
        public int Minus(string expr)
        {
            if (string.IsNullOrWhiteSpace(expr)) return 0;
            var splitedExpr = expr.Split(new char[] { ',', '\n' });
            if (splitedExpr.Length > 2 || splitedExpr.Length < 2)
                throw new ArgumentException();
            if ((splitedExpr[0]).Contains("-") || (splitedExpr[1]).Contains("-"))
                throw new ArgumentException();

            return int.Parse(splitedExpr[0]) - int.Parse(splitedExpr[1]);
        }
    }
}