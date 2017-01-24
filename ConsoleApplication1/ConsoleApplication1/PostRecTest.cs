using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class PostRecFirstTest
    {
        void Test(String input, String res)
        {
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

        public void Test1()
        {
            Test("1 + 2 * 3", "1 2 3 * +");
        }

        public void Test2()
        {
            Test("123 + 3,14 * 6666", "123 3,14 6666 * +");
        }

        public void Test3()
        {
            Test("(1.2+3,14)*(134+65)-1", "1.2 3,14 + 134 65 + * 1 -");
        }
           

    }
}
