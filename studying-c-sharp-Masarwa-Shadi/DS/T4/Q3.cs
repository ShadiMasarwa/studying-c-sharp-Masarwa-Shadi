using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.DS.T4
{
    public class Q3
    {
        public static void RunMe()
        {
            Node<int> circleLst = new Node<int>(1);
            Node<int> pos = circleLst;
            for (int i = 2; i <= 5; i++)
            {
                pos.SetNext(new Node<int>(i));
                pos = pos.GetNext();
            }
            pos.SetNext(circleLst);
            Console.WriteLine(circleLst.ToPrintCircleChain());

            Node<int> pos1 = circleLst;
            Node<int> pos2 = circleLst.GetNext();
            do
            {
                Console.Write(pos1.GetValue());
                do
                {
                    Console.Write(pos2.GetValue());
                    pos2 = pos2.GetNext();
                } while (pos2 != pos1);
                Console.WriteLine();
                pos1 = pos1.GetNext();
                pos2 = pos1.GetNext();
            } while (pos1 != circleLst);
        }
    }
}
