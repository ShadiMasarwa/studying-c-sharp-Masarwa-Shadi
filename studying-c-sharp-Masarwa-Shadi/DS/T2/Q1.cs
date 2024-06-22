using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.DS.T2
{
    public class Q1
    {
        public static void Run()
        {
            Node<Polynom> pol1 = new Node<Polynom>(new Polynom(-16, 0));
            pol1 = new Node<Polynom>(new Polynom(5, 3), pol1);
            pol1 = new Node<Polynom>(new Polynom(1, 5), pol1);

            Node<Polynom> pol2 = new Node<Polynom>(new Polynom(24, 1));
            pol2 = new Node<Polynom>(new Polynom(6, 3), pol2);
            pol2 = new Node<Polynom>(new Polynom(2, 4), pol2);

            Console.Write("Polynom 1: ");
            PrintList(pol1);
            Console.Write("Polynom 2: ");
            PrintList(pol2);
            Node<Polynom> mergedPolynom = MergedPolynom(pol1, pol2);
            Console.Write("Merged list: ");
            PrintList(mergedPolynom);
            Console.Write("Merged polynom: ");
            PrintPolynom(mergedPolynom);
        }

        private static Node<Polynom> MergedPolynom(Node<Polynom> pol1, Node<Polynom> pol2)
        {
            Node<Polynom> newPol = null;
            Node<Polynom> pos = pol1;
            while (pos.HasNext())
                pos = pos.GetNext();
            pos.SetNext(pol2);
            int maxPower = Math.Max(pol1.GetValue().Num2, pol2.GetValue().Num2);
            for (int i = maxPower; i >= 0; i--)
            {
                pos = pol1;
                int num = 0;
                while (pos != null)
                {
                    if (pos.GetValue().Num2 == i)
                        num += pos.GetValue().Num1;
                    pos = pos.GetNext();
                }
                if (num != 0)
                {
                    if (newPol == null)
                        newPol = new Node<Polynom>(new Polynom(num, i));
                    else
                    {
                        Node<Polynom> temp = newPol;
                        while (temp.HasNext())
                            temp = temp.GetNext();
                        temp.SetNext(new Node<Polynom>(new Polynom(num, i)));
                    }
                }
            }
            return newPol;



        }

        private static void PrintList(Node<Polynom> lst)
        {
            while (lst != null)
            {
                lst.GetValue().Print();
                lst = lst.GetNext();
            }
            Console.WriteLine("Null");
        }

        private static void PrintPolynom(Node<Polynom> lst)
        {
            string str = "";
            Node<Polynom> first = lst;
            while (lst != null)
            {
                if (lst.GetValue().Num1 > 0 && lst != first)
                    str += "+";
                if(lst.GetValue().Num1!=1)
                    str += lst.GetValue().Num1.ToString();

                if (lst.GetValue().Num2 > 0)
                    str += "X";
                if (lst.GetValue().Num2 > 1)
                    str += "^" + lst.GetValue().Num2.ToString();
                lst = lst.GetNext();
            }
            Console.WriteLine(str);
        }
    }

    public class Polynom
    {
        private int num1;
        private int num2;

        public Polynom(int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }

        public int Num1 { get => num1; set => num1 = value; }
        public int Num2 { get => num2; set => num2 = value; }
        public void Print()
        {
            Console.Write($"({num1},{num2}) => ");
        }
    }

}

