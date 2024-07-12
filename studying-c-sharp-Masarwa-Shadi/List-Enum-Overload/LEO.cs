using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.List_Enum_Overload
{
    public class LEO
    {
        public enum Colors
        {
            WHITE, BLACK, RED, GREEN, BLUE, YELLOW
        }

        public static void PrintColor(Colors color)
        {
            switch (color)
            {
                case Colors.BLACK:
                    Console.WriteLine("Black");
                    return;
                case Colors.WHITE:
                    Console.WriteLine("White");
                    return;
                case Colors.GREEN:
                    Console.WriteLine("Green");
                    return;
                case Colors.RED:
                    Console.WriteLine("Red");
                    return;
                case Colors.YELLOW:
                    Console.WriteLine("Yellow");
                    return;
                case Colors.BLUE:
                    Console.WriteLine("Blue");
                    return;
            }
        }
        public static void PrintColor(int color)
        {
            switch (color)
            {
                case 1:
                    Console.WriteLine("Black");
                    return;
                case 2:
                    Console.WriteLine("White");
                    return;
                case 3:
                    Console.WriteLine("Green");
                    return;
                case 4:
                    Console.WriteLine("Red");
                    return;
                case 5:
                    Console.WriteLine("Yellow");
                    return;
                case 6:
                    Console.WriteLine("Blue");
                    return;
                case 7:
                    Console.WriteLine("Not Valid color");
                    return;
            }
        }

        public static void ListDemo()
        {
            List<int> lst = new List<int>();
            lst.Add(10);
            lst.Add(20);
            lst.Add(30);
            lst.Add(40);
            lst.Add(50);
            lst.Add(60);
            foreach (int i in lst)
                Console.WriteLine(i + ", ");
        }
    }
}