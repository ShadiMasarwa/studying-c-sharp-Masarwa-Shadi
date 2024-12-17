using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.DS.Y3S1.Trees1
{
    public class Bonus
    {
        public static void PrintAllNodes(BinNode<int> tr)
        {
            if(tr != null)
            {
                Console.Write(tr.GetValue() + " ");
                PrintAllNodes(tr.GetLeft());
                PrintAllNodes(tr.GetRight());
            }
        }
    }
}
