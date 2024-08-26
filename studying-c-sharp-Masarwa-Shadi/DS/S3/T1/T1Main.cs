using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.DS.S3.T1
{
    public class T1Main
    {
        public static void RunMe()
        {
            Stack<int> intStack1 = new Stack<int>();
            Stack<int> intStack2 = new Stack<int>();
            Stack<char> charStack = new Stack<char>();
            Random random = new Random();
            FillStackWithInts(intStack1, 10, random);
            
            FillStackWithChars(charStack, 9, random);
            FillStackWithInts(intStack2, 7,random);
            Console.WriteLine(intStack1.ToString());
            Console.WriteLine(intStack2.ToString());
            Console.WriteLine(charStack.ToString());

            Console.WriteLine("\nQ1. Stack 1 count: "+ Q1.CountStack(intStack1));
            Q2.ReverseStack(intStack2);
            Console.WriteLine("Q2. Stack 2 Reversed: " + intStack2.ToString());
            Console.WriteLine("Q3. Sum of stack1: " + Q3.SumStack(intStack1));
            Console.WriteLine("Q4. Max num in stack2: " + Q4.MaxStack(intStack2));
            Console.WriteLine("Q5. Sum of items greater than average in stack2: " + Q5.GreaterAvg(intStack2));
            Console.Write("Enter char to find its place: ");
            char ch = Console.ReadKey().KeyChar;
            Console.WriteLine($"\nQ6. Char '{ch}' is in place num: {Q6.FindPlace(charStack,ch)}");
            Console.Write("Q7. ");
            Q7.InsertLast(charStack);
            Console.WriteLine("\n"+charStack.ToString());
            Console.Write("Q8. ");
            Q8.DeleteItem(charStack);
            Console.WriteLine("\n" + charStack.ToString());
            Console.WriteLine("Q9. Merged int Stacks:");
            Console.WriteLine(Q9.Merge2Stacks(intStack1,intStack2).ToString());
            Console.WriteLine();
        }




        private static void FillStackWithInts(Stack<int> intStack, int num, Random random)
        {
            
            for (int i = 0; i < num; i++)
                intStack.Push(random.Next(1, 101));
        }
        private static void FillStackWithChars(Stack<char> charStack, int num, Random random)
        {
            for (int i = 0; i < num; i++)
                charStack.Push((char)random.Next(65, 123));
        }

    }
}
