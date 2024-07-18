using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.DS.T5
{
    public class Q123
    {
        public static void RunMe()
        {
            BinNode<int> lst = GetBinList(10, 1, 100);
            Console.WriteLine("Origin List:\t" + PrintLeftToRight(lst));
            BinNode<int> lastNode = GetLastNode(lst);
            Console.WriteLine("Reversed List:\t" + PrintRightToLeft(lastNode));
        }

        private static BinNode<int> GetBinList(int size, int from, int to)
        {
            Random random = new Random();
            BinNode<int> lst = new BinNode<int>(random.Next(from, to + 1));
            BinNode<int> pos = lst;
            for (int i= 1; i < size; i++)
            {
                pos.SetRight(new BinNode<int>(pos, random.Next(from, to+1), null ));
                pos = pos.GetRight();
            }
            return lst;
        }

        private static string PrintLeftToRight(BinNode<int> lst)
        {
            if (lst.HasRight())
                return lst.GetValue() + ", " + PrintLeftToRight(lst.GetRight());
            return lst.GetValue() + ", null";
        }

        private static string PrintRightToLeft(BinNode<int> lst)
        {
            if (lst.HasLeft())
                return lst.GetValue() + ", " + PrintRightToLeft(lst.GetLeft());
            return lst.GetValue() + ", null";
        }

        private static BinNode<int> GetLastNode(BinNode<int>lst)
        {
            BinNode<int> pos = lst;
            while (pos.HasRight())
                pos = pos.GetRight();
            return pos;
        }

    }
}
