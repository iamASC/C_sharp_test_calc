using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //TESTS
            /*
            PostRecFirstTest test = new PostRecFirstTest();
            test.Test1();
            test.Test2();
            test.Test3();

            MathProcedureTest test2 = new MathProcedureTest();
            test2.MathTest();

            ResolverTest test3 = new ResolverTest();
            test3.Test();
             */

            Console.WriteLine("Please, enter your mathematical expression:");
            String input = "";
            input = Console.ReadLine();
            Resolver res = new Resolver();
            Console.WriteLine(res.Solve(input));
        
        }
    }
}
