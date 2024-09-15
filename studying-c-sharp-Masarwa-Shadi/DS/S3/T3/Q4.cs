using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.DS.S3.T3
{
    public class Q4
    {
        public static bool IsOrdered(Queue<int> q)
        {
            bool ordered = true;
            Queue<int> temp = new Queue<int>();
            int prev = q.Head();
            temp.Insert(q.Remove());
            while (!q.IsEmpty())
            {
                ordered = q.Head() < prev;
                temp.Insert(q.Remove());
            }
            while (!temp.IsEmpty())
            {
                q.Insert(temp.Remove());
            }
            return ordered;
        }
    }
}
