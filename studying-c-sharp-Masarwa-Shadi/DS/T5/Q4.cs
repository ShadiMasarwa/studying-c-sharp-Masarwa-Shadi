using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.DS.T5
{
    public class Q4
    {
        public static void RunMe()
        {
            //Build BinNode<int> list (10 nodes)
            int NUM = 10;
            Random random = new Random();
            BinNode<int> lst = new BinNode<int>(random.Next(1, 101));
            BinNode<int> pos = lst;
            for (int  i = 1; i < NUM;  i++)
            {
                pos.SetRight(new BinNode<int>(pos,random.Next(1, 101), null));
                pos = pos.GetRight();
            }
            Console.WriteLine(lst.ToPrint());

            //Generate 3 more nodes
            BinNode<int> first = new BinNode<int>(random.Next(1, 101));
            BinNode<int> last = new BinNode<int>(random.Next(1, 101));
            BinNode<int> middle = new BinNode<int>(random.Next(1, 101));

            //Enter before first node
            lst.SetLeft(first);
            first.SetRight(lst);
            lst = first;
            Console.WriteLine(lst.ToPrint());

            //Enter after last node
            pos = lst.GetLast();
            pos.SetRight(last);
            last.SetLeft(pos);
            Console.WriteLine(lst.ToPrint());

            //Enter between the 4th and 5th node
            pos = lst;
            for (int i = 1; i < 4; i++)
                pos = pos.GetRight();
            pos.GetRight().SetLeft(middle);
            middle.SetRight(pos.GetRight());
            pos.SetRight(middle);
            middle.SetLeft(pos);
            Console.WriteLine(lst.ToPrint());
        }

    }
}
