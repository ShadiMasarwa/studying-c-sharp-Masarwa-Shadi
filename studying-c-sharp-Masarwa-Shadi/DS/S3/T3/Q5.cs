using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.DS.S3.T3
{
    public class Q5
    {
        public static bool IsIdentical(Queue<int> q1, Queue<int> q2)
        {
            bool identical = true;
            Queue<int> temp1 = new Queue<int>();
            Queue<int> temp2 = new Queue<int>();

            while (!q1.IsEmpty())
            {
                int num1 = q1.Remove();
                temp1.Insert(q1.Remove());
                if (!q2.IsEmpty())
                {
                    int num2 = q2.Remove();
                    temp2.Insert(q2.Remove());
                    if (num1 != num2)
                        identical = false;
                }
                else
                    identical = false;
            }
            if(!q2.IsEmpty())
                identical = false;

            while(!temp1.IsEmpty()) 
                q1.Insert(temp1.Remove());
            while(!temp2.IsEmpty())
                temp2.Insert(temp2.Remove());
            return identical;
        }
    }
}
