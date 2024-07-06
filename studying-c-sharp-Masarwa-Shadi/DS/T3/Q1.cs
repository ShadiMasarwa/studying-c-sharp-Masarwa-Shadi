using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.DS.T3
{
    public class Q1
    {

        public static void Run()
        {
            Node<RainyDays> lst = new Node<RainyDays> (new RainyDays(23,25));
            lst = new Node<RainyDays>(new RainyDays(18, 20), lst);
            lst = new Node<RainyDays>(new RainyDays(12, 13), lst);
            lst = new Node<RainyDays>(new RainyDays(9, 10), lst);
            lst = new Node<RainyDays>(new RainyDays(1, 4), lst);

            bool[] arr = new bool[31];
            FillArray(arr);
            PrintIncorrectDays(arr, lst);
        }

        private static void PrintIncorrectDays(bool[] arr, Node<RainyDays> lst)
        {
            bool[] arr2 = new bool[arr.Length];
            for (int i=1; i<arr.Length; i++) 
                arr2[i] = false;


            while (lst != null)
            {
                for(int i=lst.GetValue().From; i<=lst.GetValue().To; i++)
                    arr2[i] = true;
                lst = lst.GetNext();
            }

            Console.WriteLine(ArraysToPrint(arr, arr2));
            
            Console.WriteLine("\nIncorrect Days:");
            for (int i=1; i<arr.Length; i++)
                if (arr[i] != arr2[i])
                    Console.Write(i + ", ");
            Console.WriteLine();
        }

        private static void FillArray(bool[] arr)
        {
            Random random = new Random();
            for (int i=1; i<arr.Length; i++)
            {
                int rnd = random.Next(0, 2);
                if (rnd == 0)
                    arr[i] = false;
                else
                    arr[i] = true;
            }
        }

        private static string ArraysToPrint(bool[] arr1, bool[] arr2)
        {
            string str1 = "";
            string str2 = "";
            string str3 = "";

            for(int i=1; i<arr1.Length; i++)
            {
                str1 += $"{i}".PadRight(4);
                if (arr1[i] == true)
                    str2 += "T".PadRight(4);
                else
                    str2 += "F".PadRight(4);
                if (arr2[i] == true)
                    str3 += "T".PadRight(4);
                else
                    str3 += "F".PadRight(4);
            }
            string str = $"{str1}\n{str2}\n{str3}";
            return str;
        }
    }

    class RainyDays
    {
        private int from;
        private int to;

        public RainyDays(int from, int to)
        {
            this.from = from;
            this.to = to;
        }

        public int From { get => from; set => from = value; }
        public int To { get => to; set => to = value; }
    }
}
