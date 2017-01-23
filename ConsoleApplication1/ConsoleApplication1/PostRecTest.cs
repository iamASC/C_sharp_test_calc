using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class PostRecFirstTest
    {
        public void SimpleTest()
        {
            String input = "1 + 2 * 3";
            String res = "1 2 3 * +";
            PostRec test = new PostRec(input);
            Console.WriteLine(test.Val());
            if (test.Val() != res)
            {
                System.Console.WriteLine("Test Failed");
            }
            else
            {
                System.Console.WriteLine("Test Passed");
            }
        }
           

    }
}
