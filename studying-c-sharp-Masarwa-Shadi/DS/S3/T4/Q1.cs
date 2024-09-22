using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.DS.S3.T4
{
    public class Q1
    {
        private static int CountNum(Queue<int> q, int num)
        {
            int count = 0;
            Queue<int> temp = new Queue<int>();
            while (!q.IsEmpty())
            {
                int n = q.Remove();
                if (n==num)
                    count++;
                temp.Insert(n);
            }
            while (!temp.IsEmpty())
                q.Insert(temp.Remove());
            return count;
        }

        private static Queue<int> DiffNums(Queue<int> q1, Queue<int>q2)
        {
            Queue<int> diffNums = new Queue<int>();
            Queue<int> temp = new Queue<int>();
            while (!q1.IsEmpty())
            {
                int num = q1.Remove();
                temp.Insert(num);
                int count1 = CountNum(q1, num);
                int count2 = CountNum(q2, num);
                if(count1 !=0 && count2 !=0 && count1 != count2)
                {
                    diffNums.Insert(num);
                }
            }
            return diffNums;
        }


    }
}
