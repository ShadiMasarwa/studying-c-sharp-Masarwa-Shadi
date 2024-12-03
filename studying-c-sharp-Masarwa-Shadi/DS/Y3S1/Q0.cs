using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.DS.Y3S1
{
    public class Q0
    {
        static void DeleteStackSE(Stack<int> stack, int k)
        {
            if (stack.IsEmpty() || stack.Top() < k)
                return;
            stack.Pop();
            DeleteStackSE(stack, k);
        }
    }
}
