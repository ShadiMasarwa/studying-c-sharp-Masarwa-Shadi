using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.DS.S3.T1
{
    public class Q2
    {
        public static void ReverseStack(Stack<int> stck)
        {
            Stack<int> backup1 = new Stack<int>();
            Stack<int> backup2 = new Stack<int>();
            while (!stck.IsEmpty())
                backup1.Push(stck.Pop());
            while (!backup1.IsEmpty())
                backup2.Push(backup1.Pop());
            while (!backup2.IsEmpty())
                stck.Push(backup2.Pop());
        }
    }
}
