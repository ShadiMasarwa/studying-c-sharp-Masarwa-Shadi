using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.DS.Y3S1.Spring_2023_A
{
    public class Q1
    {
        public static void RunMe()
        {
            Queue<int> grades = new Queue<int>();
            Queue<int> num = new Queue<int>();
            grades.Insert(80);
            grades.Insert(90);
            grades.Insert(100);
            grades.Insert(75);
            grades.Insert(96);
            grades.Insert(100);
            grades.Insert(100);
            grades.Insert(97);
            grades.Insert(96);
            grades.Insert(88);
            grades.Insert(94);
            num.Insert(3);
            num.Insert(2);
            num.Insert(4);
            num.Insert(2);
            Console.WriteLine(AverageQueue(grades, num));
        }

        public static Queue<double> AverageQueue(Queue<int>grades, Queue<int>num)
        {
            Queue<double> avg = new Queue<double>();
            while (!num.IsEmpty())
            {
                int numOfGrades = num.Remove();
                int sum = 0;
                for (int i = 0; i < numOfGrades; i++)
                    sum += grades.Remove();
                avg.Insert(sum*1.0 / numOfGrades);
            }
            return avg;
        }

    }
}
