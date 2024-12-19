using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.DS.ClassProj.BinNode
{
    public class Q1
    {
        public static void PrintLeft(BinNode<int> tr)
        {
            if (tr == null) return;
            if(tr.GetLeft() != null)
                Console.WriteLine(tr.GetLeft().GetValue());
            PrintLeft(tr.GetLeft());
            PrintLeft(tr.GetRight());
        }
    }
}
