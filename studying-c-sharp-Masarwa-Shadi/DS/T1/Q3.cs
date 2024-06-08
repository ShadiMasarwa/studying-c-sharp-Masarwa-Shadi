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
            Console.WriteLine("After Deleting ({0}): \t" + numbers.ToPrint(), numToDelete);
        }

        public static Node<int> Delete(Node<int> lst, int num) 
        {
            Node<int> newList = null;
            Node<int> pos = lst;
            while (pos != null)
            {
                if (pos.GetValue() != num)
                {
                    if (newList == null)
                        newList = new Node<int>(pos.GetValue());
                    else
                    {
                        Node<int> after = GetLast(newList);
                        after.SetNext(new Node<int>(pos.GetValue()));

                        //newList = new Node<int>(pos.GetValue(), newList);
                    }
                }
                pos = pos.GetNext();
            }
            return newList;
        }

        public static Node<int> GetLast(Node<int> lst)

        {
            while (lst != null && lst.HasNext())
                lst = lst.GetNext();
            return lst;
        }

        public static Node<int> GenerateList(int num)
        {
            Random rnd = new Random();
            Node<int> newList = null;
            for (int i = 0; i<num; i++)
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
