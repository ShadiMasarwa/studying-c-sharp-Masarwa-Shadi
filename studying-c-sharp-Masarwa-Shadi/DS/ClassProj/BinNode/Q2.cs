using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.DS.ClassProj.BinNode
{
    public class Q2
    {
        public static void UpdateParent(BinNode<int> tr)
        {
            if(tr == null) return;
            if(tr.HasLeft() && tr.HasRight())
                tr.SetValue(tr.GetLeft().GetValue() + tr.GetRight().GetValue());
            UpdateParent(tr.GetLeft());
            UpdateParent(tr.GetRight());
        }
    }
}
