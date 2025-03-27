using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.DS.Y3S1.Spring_2024_A
{
    public class Q1A
    {
        public static bool IsUniform(Stack<int> st)
        {
            if(st.IsEmpty()) return false;
            bool isEven = true;
            bool isOdd = true;
            while (!st.IsEmpty())
            {
                if (st.Pop()%2 != 0)
                    isEven = false;
                else
                    isOdd = false;
            }
            return isEven || isOdd;
        }
    }
}
