using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.DS.S3.T1
{
    public class Q1
    {
        public static int CountStack(Stack<int> stck)
        {
            Stack<int> backup = new Stack<int>();
            int num = 0;
            while (!stck.IsEmpty())
            {
                int x = stck.Pop();
                backup.Push(x);
                num++;
            }
            while (!backup.IsEmpty())
                stck.Push(backup.Pop());
            return num;
        }
    }
}
