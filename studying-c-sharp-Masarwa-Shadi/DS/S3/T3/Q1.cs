using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.DS.S3.T3
{
    public class Q1
    {
    public static int Count(Queue<int> q)
        {
            int count = 0;
            Queue<int> temp = new Queue<int>();
            while (!q.IsEmpty())
            {
                temp.Insert(q.Remove());
                count++;
            }
            while (!temp.IsEmpty())
                q.Insert(temp.Remove());
            return count;
        }
    }

   
}
