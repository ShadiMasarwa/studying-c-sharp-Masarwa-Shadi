using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.DS.S3.T1
{
    public class Q3
    {
        public static int SumStack(Stack<int> stck)
        {
            int sum = 0;
            Stack<int> backup = new Stack<int>();
            while (!stck.IsEmpty())
            {
                int x = stck.Pop();
                sum += x;
                backup.Push(x);
            }
            while (!backup.IsEmpty())
                stck.Push(backup.Pop());
            return sum;
        }
    }
}
