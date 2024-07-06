using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.DS.ClassProj
{
    public class Wether
    {
        public static void RunMe()
        {
            bool[] days = new bool[31];
            GetArray(days);
            PrintArray(days);

            Node<Item> lst = new Node<Item>(new Item(25, 27));
            lst = new Node<Item>(new Item(20, 22), lst);
            lst = new Node<Item>(new Item(15, 16), lst);
            lst = new Node<Item>(new Item(9, 11), lst);
            lst = new Node<Item>(new Item(3, 4), lst);
            lst = new Node<Item>(new Item(1, 1), lst);

            Node<Item> pos = lst;
            while (pos != null)
            {
                Console.Write($"({pos.GetValue().from}, {pos.GetValue().to}), ");
                pos = pos.GetNext();
            }
            Console.WriteLine();
            CheckAndPrint(days, lst);
        }

        private static void CheckAndPrint(bool[] days, Node<Item> lst)
        {
            Node<Item> pos = lst;
            Console.Write("Correct days: ");
            while (pos != null)
            {
                for(int i=pos.GetValue().from; i<=pos.GetValue().to; i++)
                {
                    if(days[i]== true)
                        Console.Write(i + ", ");
                }
                pos = pos.GetNext();
            }
            Console.WriteLine();
        }
        private static void PrintArray(bool[] days)
        {
            string str = "";
            for (int i = 1; i < days.Length; i++)
            {
                if (days[i] == true)
                    str = "T";
                else
                    str = "F";
                Console.Write($"({i}-{str}) ");
            }
            Console.WriteLine();
        }

        private static void GetArray(bool[] arr)
        {
            Random rnd = new Random();
            for (int i=1; i<arr.Length; i++)
            {
                int num = rnd.Next(0,2);
                if (num == 0)
                    arr[i] = false;
                else
                    arr[i] = true;
            }
        }
    }

    class Item
    {
        public int from;
        public int to;

        public Item(int from, int to)
        {
            this.from = from;
            this.to = to;
        }
    }
}
