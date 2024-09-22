using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.DS.S3.T4
{
    public class Q2
    {
        private static bool ValidLogic(Queue<char> q)
        {
            if (q.Head() != 'F' || q.Head() != 'T')
                return false;
            Queue<char> temp = new Queue<char>();
            bool flag = true;
            temp.Insert(q.Remove());
            //0 - curr is logical value
            //1 - curr is logical operator
            int prev = 0;
            while (!q.IsEmpty())
            {
                char curr = q.Remove();
                if ((curr == 'F' || curr == 'T') && prev == 0)
                    flag = false;
                else
                    prev = 1;

                if ((curr == 'O' || curr == 'A') && prev == 1)
                    flag = false;
                else
                    prev = 0;

                temp.Insert(curr);
            }
            while (!q.IsEmpty()) 
                q.Insert(q.Remove());
            return flag && prev==0;
        }
    }
}
