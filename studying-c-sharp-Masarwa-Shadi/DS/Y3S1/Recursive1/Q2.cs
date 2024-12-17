using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.DS.Y3S1
{
    public class Q2
    {
        public static int EvenNumbers(Queue<int> q)
        {
            if(q.IsEmpty())
                return 0;
            if (q.Remove()%2==0)
                return 1+ EvenNumbers(q);
            else
                return EvenNumbers(q);

        }
    }
}
