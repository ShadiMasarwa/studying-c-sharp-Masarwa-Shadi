using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.DS.Y3S1.Trees1
{
    public class Q2
    {
        public static void PrintNumOfNodes(BinNode<int> tr)
        {
            int count = CountNodes(tr);
            Console.WriteLine(count);
        }

        private static int CountNodes(BinNode<int> tr)
        {
            if (tr == null)
            {
                return 0;
            }
            return 1 + CountNodes(tr.GetLeft()) + CountNodes(tr.GetRight());
        }
    }
}
