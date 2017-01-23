using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class PostRec
    {
        Dictionary<char,int> opPrior = new Dictionary<char,int>();
        String rec="";
        
        public PostRec(String input)
        {
            opPrior.Add('+', 10);
            opPrior.Add('-', 10);
            opPrior.Add('*', 20);
            opPrior.Add('/', 20);
            opPrior.Add('^', 30);
            MakePostRec(input);
        }

        void MakePostRec(String input)
        {
            Stack<char> stck = new Stack<char>();
            foreach (char x in input){
                if (Char.IsDigit(x))
                    rec += x+" ";
                else if (x == '(')
                    stck.Push(x);
                else if (x == ')')
                {
                    while (stck.Peek()!='(')
                        rec+=stck.Pop()+" ";
                    stck.Pop();
                }
                else if (opPrior.ContainsKey(x))
                {
                    while(true)
                    {
                        if (stck.Count() == 0)
                            break;
                        if (stck.Peek() == '(' || opPrior[stck.Peek()] < opPrior[x])
                            break;
                        rec += stck.Pop()+" ";
                    }
                    stck.Push(x);
                }
            }
            while (stck.Count() > 1)
                rec += stck.Pop()+" ";
            rec += stck.Pop();
        }
        

        public String Val()
        {
            return rec;
        }
    }
}
