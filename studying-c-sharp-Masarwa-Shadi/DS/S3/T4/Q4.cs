using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.DS.S3.T4
{
    public class Q4
    {
        public static Queue<int> MultiplyQ(Queue<int> q)
        {
            Queue<int> result = new Queue<int>();
            Queue<int> temp = new Queue<int>();
            while(!q.IsEmpty())
            {
                int num = q.Remove();
                temp.Insert(num);
                for (int i = 0; i < num; i++)
                    result.Insert(num);
            }
            while(!temp.IsEmpty())
                q.Insert(temp.Remove());

            return result;
        }
    }
}
