using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.DS.Y3S1.Trees1
{
    public class RunMe
    {
        public static void RunCode()
        {
            BinNode<int> tr = new BinNode<int>(new BinNode<int>(new BinNode<int>(null, 3, null), 2, new BinNode<int>(null,6,null)), 1, new BinNode<int>(new BinNode<int>(null, 12, new BinNode<int>(new BinNode<int>(28), 15, null)), 9, null));
            Console.WriteLine("All nodes:");
            Bonus.PrintAllNodes(tr);
            Console.WriteLine();
            Console.WriteLine("Even nodes:");
            Q1.PrintEven(tr);
            Console.WriteLine();
            Console.WriteLine("Nodes Count:");
            Q2.PrintNumOfNodes(tr);
        }
    }
}
