using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.DS.ClassProj.BinNode
{
    public class Q5
    {
        public static int SumEven (BinNode<int> tr)
        {
            if (tr == null)
                return 0;
            return tr.GetValue() + SumEven(tr.GetLeft()) + SumEven(tr.GetRight());
        }
    }
}
