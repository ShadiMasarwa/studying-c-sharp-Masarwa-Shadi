using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.DS.S3.T3
{
    public class Q6
    {
        public static void PutFirst(Queue<int> q,  int value)
        {
            Queue<int> temp = new Queue<int>();
            bool found = false;
            while(!q.IsEmpty() && !found)
            {
                if(q.Head() == value)
                {
                    found = true;
                    q.Remove();
                }
                else
                {
                    temp.Insert(q.Remove());
                }
            }
            while (!q.IsEmpty())
                temp.Insert(q.Remove());

            if(found)
            {
                q.Insert(value);
            }
            while (!temp.IsEmpty())
                q.Insert(temp.Remove());
        }
    }
}
