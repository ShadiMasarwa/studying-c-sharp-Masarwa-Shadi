using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace studying_c_sharp_Masarwa_Shadi.DS.Y3S1.Exams
{
    public class RunMe
    {
        public static void RunThis()
        {
            //Stack<char> st = new Stack<char>();
            //st.Push('F');
            //st.Push('O');
            //st.Push('F');
            //st.Push('A');
            //st.Push('T');
            //st.Push('A');
            //st.Push('F');
            //st.Push('O');
            //st.Push('O');
            //Console.WriteLine(q1.IsOk(st));


            Stack<int> s1 = new Stack<int>();
            s1.Push(1);
            s1.Push(2);
            s1.Push(3);
            s1.Push(4);
            s1.Push(5);
            s1.Push(6);
            Stack<int> s2 = new Stack<int>();
            s2.Push(3);
            s2.Push(6);
            s2.Push(4);
            q3.DifStack(s1, s2).ToString();
        }   

    }
}
