using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.DS.S3.T1
{
    public class Q5
    {
        public int GreaterAvg(Stack<int> stck)
        {
            Stack<int> backup = new Stack<int>();
            int sumAll = 0;
            int num = 0;
            while (!stck.IsEmpty())
            {
                int x = stck.Pop();
                backup.Push(x);
                sumAll += x;
                num++;
            }
            int avg = sumAll / num;
            int sumGreater = 0;
            while (!backup.IsEmpty())
            {
                int x = backup.Pop();
                if (x > avg)
                    sumGreater += x;
                stck.Push(x);
            }
            return sumGreater;
        }
    }
}
