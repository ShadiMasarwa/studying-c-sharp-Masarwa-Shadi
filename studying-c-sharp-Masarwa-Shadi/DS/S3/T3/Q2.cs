using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.DS.S3.T3
{
    public class Q2
    {
        public static Queue<int> Clone(Queue<int> q)
        {
            Queue<int> newQueue = new Queue<int>();
            Queue<int> temp = new Queue<int>();
            while (!q.IsEmpty())
            {
                int value =  q.Remove();
                newQueue.Insert(value);
                temp.Insert(value);
            }
            while (!temp.IsEmpty())
                q.Insert(temp.Remove());
            return newQueue;
        }
    }
}
