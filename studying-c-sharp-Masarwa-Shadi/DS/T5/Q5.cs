using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.DS.T5
{
    public class Q5
    {
        public static void RunMe()
        {
            //Build BinNode<int> list (10 nodes)
            int NUM = 10;
            Random random = new Random();
            BinNode<int> lst = new BinNode<int>(random.Next(1, 101));
            BinNode<int> pos = lst;
            for (int i = 1; i < NUM; i++)
            {
                pos.SetRight(new BinNode<int>(pos, random.Next(1, 101), null));
                pos = pos.GetRight();
            }
            Console.WriteLine(lst.ToPrint());

            lst = DeleteLarger(lst, 50);
            Console.WriteLine(lst.ToPrint());

        }

        private static BinNode<int> DeleteLarger(BinNode<int> lst, int num)
        {
            BinNode<int> pos = lst;
            BinNode<int> last = lst.GetLast();

            while (pos != null)
            {
                if (pos.GetValue() > num)
                {
                    if (pos == lst)
                    {
                        lst = pos.GetRight();
                        lst.SetLeft(null);
                    }
                    else if (pos == last)
                    {
                        pos.GetLeft().SetRight(null);
                    }
                    else
                    {
                        pos.GetLeft().SetRight(pos.GetRight());
                        pos.GetRight().SetLeft(pos.GetLeft());
                    }
                }
                pos = pos.GetRight();
            }
            return lst;
        }
    }
}
