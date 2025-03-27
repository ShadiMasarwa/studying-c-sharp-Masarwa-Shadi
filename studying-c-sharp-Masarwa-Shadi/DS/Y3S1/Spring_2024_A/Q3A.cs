using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.DS.Y3S1.Spring_2024_A
{
    public class Q3A
    {
        public static bool UniqNeg(Node<int> chain)
        {
            Node<int> temp = chain;
            Node<int> pos;
            while (temp.HasNext())
            {
                pos = temp.GetNext();
                while(pos != null)
                {
                    if (pos.GetValue() < 0 && pos.GetValue() == temp.GetValue())
                        return false;
                    pos = pos.GetNext();
                }
                temp = temp.GetNext();
            }
            return true;
        }
    }
}
