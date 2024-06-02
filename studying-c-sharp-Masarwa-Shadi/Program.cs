using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using studying_c_sharp_Masarwa_Shadi.demo;
using studying_c_sharp_Masarwa_Shadi.T1;
using studying_c_sharp_Masarwa_Shadi.DS;

namespace studying_c_sharp_Masarwa_Shadi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Level1.RunMe();
            //Console.WriteLine("aaa");
            Node<int> n1 = new Node<int>(10);
            Node<int> n2 = new Node<int>(15);
            Node<int> n3 = new Node<int>(17);
            Node<int> n4 = new Node<int>(16);
            Node<int> n5 = new Node<int>(48);
            n1.SetNext(n2);
            n2.SetNext(n3);
            n3.SetNext(n4);
            n4.SetNext(n5);
            
            Node<int> result = Q1.Even(n1);
            Console.WriteLine(result.ToPrint());
        }
    }
}
