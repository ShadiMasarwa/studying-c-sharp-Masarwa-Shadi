using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.DS.ClassProj.BinNode
{
    public class Q4
    {
        public static int CountNodes(BinNode<int> tr)
        {
            if (tr == null) return 0;
            return 1+ (CountNodes(tr.GetLeft()) + CountNodes(tr.GetRight()));
        }
    }
}
