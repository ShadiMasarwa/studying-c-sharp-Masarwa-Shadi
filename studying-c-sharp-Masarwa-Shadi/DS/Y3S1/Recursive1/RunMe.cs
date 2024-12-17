using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.DS.Y3S1
{
    public class RunMe
    {
        public static void RunTests()
        {
            Queue<int> queue = new Queue<int>();
            queue.Insert(18);
            queue.Insert(5);
            queue.Insert(12);
            queue.Insert(10);
            queue.Insert(7);
            queue.Insert(8);
            queue.Insert(3);
            queue.Insert(2);
            Console.WriteLine(queue.ToString());

            //bool found = Q1.FindNum(queue, 10);
            //Console.WriteLine(found);
            Console.WriteLine(Q2.EvenNumbers(queue));
        }
    }
}
