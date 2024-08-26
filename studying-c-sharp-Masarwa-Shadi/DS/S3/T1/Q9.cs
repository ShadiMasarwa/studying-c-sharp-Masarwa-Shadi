using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.DS.S3.T1
{
    public class Q9
    {
        public static Stack<int> Merge2Stacks(Stack<int> stk1, Stack<int> stk2)
        {
            Stack<int> merged = new Stack<int>();
            while (!stk1.IsEmpty() && !stk2.IsEmpty())
            {
                merged.Push(stk1.Pop());
                merged.Push(stk2.Pop());
            }
            if(stk1.IsEmpty())
                while (!stk2.IsEmpty())
                    merged.Push(stk2.Pop());
            if (stk2.IsEmpty())
                while (!stk1.IsEmpty())
                    merged.Push(stk1.Pop());
            return merged;
        }
    }
}
