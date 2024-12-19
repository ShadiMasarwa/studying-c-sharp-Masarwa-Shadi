using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.DS.ClassProj.BinNode
{
    public class RunTasks
    {
        public static void RunMe()
        {
            BinNode<int> tr = new BinNode<int>(10);
            //BinNode<int> tr1 = new BinNode<int>(7);
            BinNode<int> tr2 = new BinNode<int>(9);
            BinNode<int> tr3 = new BinNode<int>(18);
            BinNode<int> tr4 = new BinNode<int>(4);
            BinNode<int> tr5 = new BinNode<int>(5);
            //BinNode<int> tr6 = new BinNode<int>(1);
            BinNode<int> tr7 = new BinNode<int>(3);
            BinNode<int> tr8 = new BinNode<int>(12);
            BinNode<int> tr9 = new BinNode<int>(25);
            BinNode<int> tr10 = new BinNode<int>(17);
            BinNode<int> tr11 = new BinNode<int>(6);

            tr3.SetLeft(tr5);
            tr3.SetRight(tr4);
            tr2.SetLeft(tr3);
            tr.SetLeft(tr2);
            tr8.SetLeft(tr11);
            tr7.SetLeft(tr8);
            tr9.SetRight(tr10);
            tr7.SetRight(tr9);
            tr.SetRight(tr7);

            //Q1.PrintLeft(tr);
            Console.WriteLine(tr.ToString());
            Q2.UpdateParent(tr);
            Console.WriteLine(tr.ToString());
            Q3.PlusMinus(tr);
            Console.WriteLine(tr.ToString());
            Console.WriteLine(Q4.CountNodes(tr));
            Console.WriteLine(Q5.SumEven(tr));
            Console.WriteLine(Q6.NumOfLeafes(tr));
            Console.WriteLine(Q7.NumOfFathers(tr));

        }
    }
}
