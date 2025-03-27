using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.DS.Y3S1.Spring_2023_B
{
    public class Q1
    {
        public static void RunMe()
        {
            Queue<int> q = new Queue<int>();
            q.Insert(80);
            q.Insert(90);
            q.Insert(100);
            q.Insert(-1);
            q.Insert(75);
            q.Insert(96);
            q.Insert(-1);
            q.Insert(100);
            q.Insert(100);
            q.Insert(97);
            q.Insert(96);
            q.Insert(-1);
            q.Insert(-1);
            q.Insert(88);
            q.Insert(94);
            q.Insert(-1);
            Console.WriteLine("Original: " + q);
            Queue<int> tests = ArrangeData(q);
            Console.WriteLine("After: " + q);
            Console.WriteLine("Tests: " + tests);
        }

        public static Queue<int> ArrangeData(Queue<int> marks)
        {
            Queue<int> tests = new Queue<int>();
            Queue<int> temp = new Queue<int>();

            while (!marks.IsEmpty())
            {
                int count = 0;
                while (marks.Head() != -1)
                {
                    temp.Insert(marks.Remove());
                    count++;
                }
                tests.Insert(count);
                marks.Remove();
            }
            while(!temp.IsEmpty())
                marks.Insert(temp.Remove());
            return tests;
        }
    }
}
