using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCalculator.Models
{
    public interface IUSDGBPExchangeRateFeed
    {
        int GetGBPRate();
        int GetGBPRate2();
        int GetGBPRate3();
        int GetGBPRate4();
        int GetGBPRate5();
        int GetGBPRate6();
        int GetGBPRate7();
        int GetGBPRate8();
        int GetGBPRate9();
        int GetGBPRate10();
        int GetGBPRate11();
        int GetGBPRate12();
    }

    public class USDGBPExchangeRateFeed : IUSDGBPExchangeRateFeed
    {
        public int GetGBPRate() { return 0; }

        public int GetGBPRate10()
        {
            throw new NotImplementedException();
        }

        public int GetGBPRate11()
        {
            throw new NotImplementedException();
        }

        public int GetGBPRate12()
        {
            throw new NotImplementedException();
        }

        public int GetGBPRate2()
        {
            throw new NotImplementedException();
        }

        public int GetGBPRate3()
        {
            throw new NotImplementedException();
        }

        public int GetGBPRate4()
        {
            throw new NotImplementedException();
        }

        public int GetGBPRate5()
        {
            throw new NotImplementedException();
        }

        public int GetGBPRate6()
        {
            throw new NotImplementedException();
        }

        public int GetGBPRate7()
        {
            throw new NotImplementedException();
        }

        public int GetGBPRate8()
        {
            throw new NotImplementedException();
        }

        public int GetGBPRate9()
        {
            throw new NotImplementedException();
        }
    }
}
