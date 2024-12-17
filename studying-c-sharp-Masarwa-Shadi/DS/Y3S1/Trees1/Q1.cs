using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.DS.Y3S1.Trees1
{
    public class Q1
    {
        public static void PrintEven (BinNode<int> tr)
        {
            if (tr != null)
            {
                if (tr.GetValue()%2==0)
                    Console.Write(tr.GetValue() + " ");
                PrintEven(tr.GetLeft());
                PrintEven(tr.GetRight());
            }
        }

    }
}
