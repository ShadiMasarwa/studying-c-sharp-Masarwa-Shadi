using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.DS.ClassProj.BinNode
{
    public class Q3
    {
        public static void PlusMinus(BinNode<int> tr)
        {
            if (tr == null) return;
            if(tr.HasLeft())
                tr.GetLeft().SetValue(tr.GetLeft().GetValue() - 1);
            if (tr.HasRight())
                tr.GetRight().SetValue(tr.GetRight().GetValue() + 1);
            PlusMinus(tr.GetLeft());
            PlusMinus(tr.GetRight());
        }
    }
}
