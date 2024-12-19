using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.DS.ClassProj.BinNode
{
    public class Q7
    {
        public static int NumOfFathers(BinNode<int> tr)
        {
            if (tr == null) return 0;
            if (tr.HasLeft() && tr.HasRight()) return 1 + (NumOfFathers(tr.GetLeft()) + NumOfFathers(tr.GetRight()));
            else return (NumOfFathers(tr.GetLeft()) + NumOfFathers(tr.GetRight()));

        }
    }
}
