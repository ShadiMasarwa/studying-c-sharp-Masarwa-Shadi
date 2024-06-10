using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.DS.ClassProj
{
    class a2
    {
        public static void RunMe()
        {
            Node<int> lst = new Node<int>(100);
            lst = new Node<int>(78, lst);
            lst = new Node<int>(39, lst);
            lst = new Node<int>(22, lst);
            lst = new Node<int>(25, lst);
            lst = new Node<int>(10, lst);
            lst = new Node<int>(8, lst);
            Console.WriteLine(lst.ToPrint());

            Console.WriteLine(Check(lst));
        }

        private static bool Check(Node<int> lst)
        {
            Node<int> pos = lst;
            while(pos != null)
            {
                if (pos.HasNext() && (pos.GetValue() > pos.GetNext().GetValue()))
                    return false;
                pos = pos.GetNext();
            }
            return true;

        }
    }
}
