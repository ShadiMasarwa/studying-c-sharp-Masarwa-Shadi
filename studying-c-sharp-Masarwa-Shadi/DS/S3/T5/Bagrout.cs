using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.DS.S3.T5
{
    public class Bagrout
    {
        public static void RunMe()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(2);
            stack.Push(1);
            stack.Push(2);
            Ex4.Exc4(stack);
        }
    }
}
