using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class MathProcedureTest
    {
        public void MathTest(){
            Console.WriteLine("3+5={0}",MathProcedure.BinaryProcedure("3","5","+"));
            Console.WriteLine("12*34={0}", MathProcedure.BinaryProcedure("12", "34", "*"));
            Console.WriteLine("4/0.5={0}", MathProcedure.BinaryProcedure("4", "0,5", "/"));
        }
    }
}
