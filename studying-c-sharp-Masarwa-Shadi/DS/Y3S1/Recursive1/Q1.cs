using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.DS.Y3S1
{
    public class Q1
    {
        public static bool FindNum(Queue<int> lst, int num)
        {
            if (lst.IsEmpty()) return false;
            if (lst.Remove() != num)
                return FindNum(lst, num);
            else return true;
           
        }
    }
}
