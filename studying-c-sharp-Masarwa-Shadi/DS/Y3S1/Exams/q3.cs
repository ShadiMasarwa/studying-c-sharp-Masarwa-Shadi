using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.DS.Y3S1.Exams
{
    public class q3
    {
        public static Stack<int> DifStack(Stack<int> stack1, Stack<int> stack2)
        {
            Stack<int> tempStack = new Stack<int>();
            while (!stack1.IsEmpty())
            {
                int num = stack1.Pop();
                if (!FoundInSecond(stack2, num))
                {
                    tempStack.Push(num);
                }
            }
            return tempStack;
        }

        public static bool FoundInSecond(Stack<int> stack, int num)
        {
            Stack<int> temp = stack;
            while(!temp.IsEmpty()){
                if (temp.Pop() == num)
                    return true;
            }
            return false;
        }
    }
}
