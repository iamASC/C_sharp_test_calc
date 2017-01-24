using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Resolver
    {
        public double Solve(String expression)
        {
            PostRec postExpr = new PostRec(expression);
            Stack<double> stck = new Stack<double>();
            String[] lexems = postExpr.Val().Split(' ');
            foreach (String str in lexems)
            {
                double tmp = 0;
                if (Double.TryParse(str, out tmp))
                    stck.Push(tmp);
                else
                    stck.Push(MathProcedure.BinaryProcedure(stck.Pop(), stck.Pop(), str));
            }
            return stck.Pop();
        }
    }
}
