using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineCalculator.Models
{
    public class Expression
    {
        public float Operand1 { get; set; }
        public float Operand2 { get; set; }
        public Operator Operator { get; set; }
        //public float Result
        //{
        //    get
        //    {
        //        switch (Operator)
        //        {
        //            case Operator.SUBTRACTION:
        //                return Operand1 - Operand2;
        //                break;
        //            case Operator.ADD:
        //                break;
        //            case Operator.DEVIDE:
        //                break;
        //            case Operator.MULTIPLY:
        //                break;
        //            default:
        //                break;
        //        }
        //    }
        //}

                                           //public float Result { get {
                                           //        switch(this.Operator)
                                           //           // switch (switch_on)
                                           //        {
                                           //            case Operator.ADD:
                                           //                Operand1 + Operand2;


        //            default:
        //        }

        //    } set; }
        //public 
    }


    public enum Operator
    {
        SUBTRACTION, ADD, DEVIDE, MULTIPLY
    }
}