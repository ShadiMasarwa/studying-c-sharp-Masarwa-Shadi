using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.DS.S3.T5
{
    public class Ex4
    {
        public static void Exc4(Stack<int> stack)
        {
            Console.WriteLine(stack.ToString());
            Stack<int> stack2 = new Stack<int>();
            int prev = stack.Pop();
            stack2.Push(prev);
            prev = stack.Pop();
            bool isIncrease = prev>stack2.Top();
            stack2.Push(prev);
            
            while(!stack.IsEmpty())
            {
                int curent= stack.Pop();
                stack2.Push(curent);
                if (!((curent > prev && isIncrease) || (curent < prev && !isIncrease)))
                {
                    stack2.Push(curent);
                    isIncrease = !isIncrease;
                    prev = curent;
                }
            }
            while (!stack2.IsEmpty()){
                stack.Push(stack2.Pop());
            }
            Console.WriteLine(stack.ToString());

        }
    }
}
