using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.DS.S3.T3
{
    public class Q3
    {
        public static bool FindNum(Queue<int> q, int num)
        {
            bool found = false;
            Queue<int> temp = new Queue<int>();
            while (!q.IsEmpty())
            {
                found = q.Head() == num;
                temp.Insert(q.Remove());
            }
            while (!temp.IsEmpty())
                q.Insert(temp.Remove());
            return found;
        }
    }
}
