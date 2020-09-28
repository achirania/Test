using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Calculator
{
    public class CalcHelper
    {
        public static double Add(string a, string b)
        {
            try
            {
                double eval = Convert.ToDouble(a) + Convert.ToDouble(b);
                return(eval);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static double Subtract(string a, string b)
        {
            try
            {
                double eval = Convert.ToDouble(a) - Convert.ToDouble(b);
                return (eval);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static double Multiply(string a, string b)
        {
            try
            {
                double eval = Convert.ToDouble(a) * Convert.ToDouble(b);
                return (eval);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static double Divide(string a, string b)
        {
            try
            {
                double eval = Convert.ToDouble(a) / Convert.ToDouble(b);
                return (eval);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}