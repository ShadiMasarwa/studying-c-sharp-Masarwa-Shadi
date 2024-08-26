using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.DS.S3.T1
{
    public class Q8
    {
        public static void DeleteItem(Stack<char> stk)
        {
            Console.Write("Insert Character To Delete: ");
            char ch = Console.ReadKey().KeyChar;
            Stack<char> backup = new Stack<char>();
            while(!stk.IsEmpty())
            {
                char ch2 = stk.Pop();
                if (ch2 != ch)
                    backup.Push(ch2);
            }
            while(!backup.IsEmpty())
                stk.Push(backup.Pop());
        }
    }
}
