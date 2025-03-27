using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.DS.Y3S1.Spring_2023_A
{
    public class Q2
    {
        public static void RunMe()
        {

        }

        public static int NumDigits(Node<int> n)
        {
            Node<int> pos = n;
            int count = 0;
            while (pos != null)
            { 
                count++;
                pos=pos.GetNext();
            }
            return count;
        }

        public static int Compare(Node<int> n1, Node<int> n2)
        {
            if (NumDigits(n1) > NumDigits(n2))
                return 1;
            if (NumDigits(n1) < NumDigits(n2))
                return 2;
            return 0;
        }

    }
}
