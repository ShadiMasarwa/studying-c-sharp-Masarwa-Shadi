using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.DS.T4
{
    public class Q1
    {

        public static void RunMe()
        {
            Node<int> lst = new Node<int>(1);
            Node<int> pos = lst;
            for (int i = 2; i <= 10; i++)
            {
                pos.SetNext(new Node<int>(i));
                pos = pos.GetNext();
            }
            pos.SetNext(lst);
            Console.WriteLine(lst.ToPrintCircleChain());
            SelectAndRemove(lst, 1);

        }
        private static void SelectAndRemove(Node<int> lst, int num)
        { 
            Node<int> pos1 = lst;
            Node<int> pos2 = lst;
            
            while (pos1 != null)
            {
                for (int i = 1; i <= num; i++)
                {
                    if (i != num)
                    {
                        pos1 = pos1.GetNext();
                        pos2 = pos2.GetNext();
                    }
                    else
                        pos1 = pos1.GetNext();
                }
                if (pos1 == pos2)
                {
                    Console.WriteLine(pos1.GetValue());
                    return;
                }
                else
                {
                    num = pos1.GetValue();
                    PrintCircleChain(lst,num);
                    Console.WriteLine(num);
                    pos2.SetNext(pos1.GetNext());
                    if (pos1 == lst)
                        lst = pos2;
                    pos1 = pos2;
                }
            }
        }
        private static void PrintCircleChain(Node<int> lst, int num)
        {
            //Console.Write(lst.GetValue());
            Node<int> pos = lst;
            do
            {
                if (pos.GetValue() == num)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(num);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(", ");
                }
                else
                    Console.Write(pos.GetValue()+ ", ");
                pos = pos.GetNext();
            } while (pos != lst);
                Console.Write("Loop\n");
        }
    }
}
