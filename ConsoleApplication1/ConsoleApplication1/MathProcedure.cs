using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class MathProcedure
    {
        public static double BinaryProcedure(double x, double y, string sign)
        {
            switch (sign){
                case "+":
                    return x + y;
                case "-":
                    return x - y;
                case "*":
                    return x * y;
                case "/":
                    return x / y;
            }

            return -0;
            
        }
    }
}
