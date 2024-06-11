using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.DS.T1
{
    public class Q3
    {
        public static void RunTask()
        {
            Node<int> numbers = GenerateList(10);
            int numToDelete = 2;
            Console.WriteLine("Origin Numbers:\t\t" + numbers.ToPrint());
            numbers = Delete(numbers, numToDelete);
            if(numbers==null)
                Console.WriteLine("After Deleting ({0}): \t Chain is empty.", numToDelete);
            else
                Console.WriteLine("After Deleting ({0}): \t" + numbers.ToPrint(), numToDelete);
        }

        public static Node<int> Delete(Node<int> lst, int num) 
        {
            Node<int> curr = lst;
            Node<int> next; 
            //one or sequence of num in start of chain
            while(curr == lst && curr!=null && curr.GetValue() == num)
            {
                lst = lst.GetNext();
                curr = lst;
            }
            next = curr;
            //num in middle or end of chain
            while(next != null)
            {
                if (next.GetValue() == num)
                {
                    curr.SetNext(next.GetNext());
                    next = next.GetNext();
                }
                else
                {
                    curr = next;
                    next = next.GetNext();
                }
            }
            return lst;
        }

        public static Node<int> GenerateList(int num)
        {
            Random rnd = new Random();
            Node<int> newList = null;
            for (int i = 0; i < num; i++)
            {
                if (newList == null)
                    newList = new Node<int>(rnd.Next(1, 11));
                else
                    newList = new Node<int>(rnd.Next(1, 11), newList);
            }
            return newList;
        }
    }
}
