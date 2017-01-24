
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class ResolverTest
    {
        public void Test()
        {
            Resolver test = new Resolver();
            Console.WriteLine("1+2+3={0}", test.Solve("1+2+3"));
            Console.WriteLine("((200 +3.16)*5 - (23/67) + 82)*18={0}", test.Solve("((200 +3.16)*5 - (23/67) + 82)*18"));
        }
    }
}
