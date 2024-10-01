using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.DS.Test2024
{
    public class Q2
    {
        public static void SecretMessage (Queue<char> num1, Queue<int> num2)
        {
            Queue<char> tempStr = new Queue<char>();
            Queue<int> tempInt = new Queue<int>();
            string st1 = "";
            char st2 ;
            while (!num2.IsEmpty())
            {
                int num = num2.Remove();
                tempInt.Insert(num);
                for(int i=0; i<num; i++)
                {
                    if (num1.IsEmpty())
                    {
                        Console.WriteLine("Error!");
                        while (!num1.IsEmpty())
                            tempStr.Insert(num1.Remove());
                        while (!tempStr.IsEmpty())
                            num1.Insert(tempStr.Remove());
                        while (!tempInt.IsEmpty())
                            num2.Insert(tempInt.Remove());
                        return;
                    }
                    st2 = num1.Remove();
                    tempStr.Insert(st2);
                    st1 += st2;
                }
                st1 += " ";
            }
            if (!num1.IsEmpty())
            {
                Console.WriteLine("Error!");
                while (!num1.IsEmpty())
                    tempStr.Insert(num1.Remove());
            }
            else
                Console.WriteLine(st1);
            while (!tempStr.IsEmpty())
                num1.Insert(tempStr.Remove());
            while (!tempInt.IsEmpty())
                num2.Insert(tempInt.Remove());
            
        }
    }
}
