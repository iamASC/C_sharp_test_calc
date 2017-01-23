using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class PostRecFirstTest
    {
        String input = "1 + 2 * 3";
        String res = "1 2 3 * + ";
        PostRec test = new PostRec(input);
        if (test.rec != res){
            System.Console.WriteLine("Test Failed");
        }else{
            System.Console.WriteLine("Test Passed");
        }
           

    }
}
