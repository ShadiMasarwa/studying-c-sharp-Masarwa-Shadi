using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.DS.ClassProj
{
    public class LinkedListExample
    {
        public static void RunTasks()
        {
            LinkedList<char> lst = new LinkedList<char>();
            lst.AddFirst('a');
            lst.AddLast('b');
            lst.AddLast('c');
            lst.AddLast('d');
            lst.DisplayLst();
            Console.WriteLine();
            lst.RemoveLast();
            lst.DisplayLst();
            Console.WriteLine();
            lst.RemoveFirst();
            lst.DisplayLst();
            Console.WriteLine();
            lst.AddFirst('a');
            lst.AddLast('d');
            lst.DisplayLst();
            Console.WriteLine();
        }
    }
}
