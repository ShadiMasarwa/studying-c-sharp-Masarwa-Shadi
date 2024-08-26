using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.DS.S3.T1
{
    public class Q7
    {
        public static void InsertLast(Stack<char> stk)
        {
            Console.Write("Insert Character To Insert Last: ");
            char ch = Console.ReadKey().KeyChar;
            Stack<char> backup = new Stack<char>();
            while (!stk.IsEmpty())
                backup.Push(stk.Pop());
            backup.Push(ch);
            while (!backup.IsEmpty())
                stk.Push(backup.Pop());
        }
    }
}
