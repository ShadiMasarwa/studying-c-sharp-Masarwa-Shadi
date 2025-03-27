using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.DS.Y3S1.Spring_2024_A
{
    public class Q8
    {
        public static void LessThanAvg(BinNode<int> t)
        {
            int sum = SumNodes(t);
            int count = NumNodes(t);
            double avg = sum * 1.0 / count ;
            Console.WriteLine(avg);
            PrintLessThanAvg(t, avg);
            Console.WriteLine();
        }

        public static int SumNodes(BinNode<int> bt)
        {
            if (bt == null)
                return 0;
            return bt.GetValue() +
                    SumNodes(bt.GetLeft()) +
                    SumNodes(bt.GetRight());
        }
        public static int NumNodes(BinNode<int> bt)
        {
            if (bt == null)
                return 0;
            return 1 + NumNodes(bt.GetLeft()) + NumNodes(bt.GetRight());
        }

        public static void PrintLessThanAvg(BinNode<int> bt, double avg)
        {
            if (bt == null)
                return;
            if(bt.GetValue()<avg)
                Console.Write(bt.GetValue()+", ");
            PrintLessThanAvg(bt.GetLeft(), avg);
            PrintLessThanAvg(bt.GetRight(), avg);
        }



    }
}
