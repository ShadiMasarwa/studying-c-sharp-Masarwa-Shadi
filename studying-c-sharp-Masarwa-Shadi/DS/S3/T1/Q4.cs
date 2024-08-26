using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.DS.S3.T1
{
    public class Q4
    {
        public static int MaxStack(Stack<int> stck)
        {
            Stack<int> backup = new Stack<int>();
            int max = stck.Pop();
            backup.Push(max);
            while (!stck.IsEmpty())
            {
                int x = stck.Pop();
                if (x > max)
                    max = x;
                backup.Push(x);
            }
            while (!backup.IsEmpty())
                stck.Push(backup.Pop());
            return max;
        }
    }
}
