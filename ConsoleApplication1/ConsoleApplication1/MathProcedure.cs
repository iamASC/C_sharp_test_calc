using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class MathProcedure
    {
        public static double BinaryProcedure(string x, string y, string sign)
        {
            switch (sign){
                case "+":
                    return Double.Parse(x) + Double.Parse(y);
                case "-":
                    return Double.Parse(x) - Double.Parse(y);
                case "*":
                    return Double.Parse(x) * Double.Parse(y);
                case "/":
                    return Double.Parse(x) / Double.Parse(y);
            }

            return -0;
            
        }
    }
}
