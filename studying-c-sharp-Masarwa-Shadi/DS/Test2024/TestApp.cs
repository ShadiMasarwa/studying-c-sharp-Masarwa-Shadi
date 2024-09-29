using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.DS.Test2024
{
    public class TestApp
    {
        public static void RunMe()
        {
            Queue<int> q1 = new Queue<int>();
            Queue<int> q2 = new Queue<int>();
            q1.Insert(9);
            q1.Insert(9);
            q1.Insert(9);
            q2.Insert(9);
            q2.Insert(9);
            q2.Insert(9);
            Console.WriteLine("Before:");
            Console.WriteLine(q1.ToString());
            Console.WriteLine(q2.ToString());
            Queue<int> Result = Q1.SumLongNumbers(q1, q2);
            Console.WriteLine("Result:");
            Console.WriteLine(Result.ToString());
            Console.WriteLine("After:");

            Console.WriteLine(q1.ToString());
            Console.WriteLine(q2.ToString());

            //Queue<char> q1 = new Queue<char>();
            //q1.Insert('H');
            //q1.Insert('e');
            //q1.Insert('l');
            //q1.Insert('l');
            //q1.Insert('o');
            //q1.Insert('W');
            //q1.Insert('o');
            //q1.Insert('r');
            //q1.Insert('l');
            //q1.Insert('d');
            //Queue<int> q2 = new Queue<int>();
            //q2.Insert(6);
            //q2.Insert(5);
            //Q2.secretMessage(q1, q2);





        }
    }
}
