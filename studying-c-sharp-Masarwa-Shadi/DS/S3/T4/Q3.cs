using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.DS.S3.T4
{
    public class Q3
    {
        public static Queue<int> Devided(Queue<int> q)
        {
            Queue<int> newQ = new Queue<int>();
            Queue<int> temp = new Queue<int>();
            int max = q.Remove();
            while(!q.IsEmpty())
            {
                int num = q.Remove();
                temp.Insert(num);
                if (num != -1)
                {
                    if (num>max)
                        max = num;
                }
                else
                {
                    newQ.Insert(max);
                    max = q.Head();
                }
            }
            q.Insert(temp.Remove());
            return newQ;
        }
    }
}
