using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.DS.Y3S1.Spring_2024_A
{
    public class Q7
    {
        public static bool IsUpDown(Node<int> chain)
        {
            Node<int> pose = chain;
            if (pose.HasNext() && pose.GetValue() > pose.GetNext().GetValue())
                return false;
            while (pose.HasNext() && pose.GetNext().GetValue() > pose.GetValue())
            {
                pose = pose.GetNext();
            }
            while (pose.HasNext() && pose.GetNext().GetValue() < pose.GetValue())
            {
                pose = pose.GetNext();
            }
            return !pose.HasNext();
        }
    }
}
