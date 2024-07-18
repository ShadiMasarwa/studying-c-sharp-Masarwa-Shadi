using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.DS.T5
{
    public class Q6
    {
        public static void RunMe()
        {
            //BinNode<int> lst = BuildBinList();
            //Console.WriteLine(lst.ToPrint());
            //if(IsPalindrom(lst))
            //    Console.WriteLine("Chain is Palindrom");
            //else
            //    Console.WriteLine("Chain is not Palindrom");

           
            BinNode<char> charLst = BuildBinCharList();
            Console.WriteLine(charLst.ToPrint());
            //Console.WriteLine(IsPalindrom(  charLst))

        }

        private static BinNode<char> BuildBinCharList()
        {
            char chr; 
            int count = 0;
            BinNode<char> lst = null;
            BinNode<char> pos = lst;

            Console.Write("Enter char (0 to end)--> ");
            chr = Console.ReadLine()[0];

            while (chr != '0')
            {
                count++;
                if (count == 1)
                {
                    lst = new BinNode<char>(chr);
                    pos = lst;
                }
                else
                {
                    pos.SetRight(new BinNode<char>(pos, chr, null));
                    pos = pos.GetRight();
                }

                Console.Write("Enter char (0 to end)--> ");
                chr = Console.ReadLine()[0];
            }
            return lst;
        }

        private static BinNode<int> BuildBinList()
        {
            int num, count=0;
            BinNode<int> lst = null;
            BinNode<int> pos = lst;

            Console.Write("Enter number (999 to end)--> ");
            num = int.Parse(Console.ReadLine());

            while (num != 999)
            {
                count++;
                if (count == 1)
                {
                    lst = new BinNode<int>(num);
                    pos = lst;
                }
                else
                {
                    pos.SetRight(new BinNode<int>(pos, num, null));
                    pos = pos.GetRight();
                }

                Console.Write("Enter number (999 to end)--> ");
                num = int.Parse(Console.ReadLine());
            }
            return lst;   
        }

        private static bool IsPalindrom(BinNode<int> lst)
        {
            BinNode<int> pos1 = lst;
            BinNode<int> pos2 = lst.GetLast();

            while (pos1!=pos2 && pos2.GetRight() != pos1)
            {
                if (pos1.GetValue() != pos2.GetValue())
                    return false;
                pos1 = pos1.GetRight();
                pos2 = pos2.GetLeft();
            }
            return true;
        }
    }
}
