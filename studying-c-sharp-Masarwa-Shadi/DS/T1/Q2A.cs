using System;
using System.Collections.Generic;

namespace studying_c_sharp_Masarwa_Shadi.DS.T1
{
    public class Q2A
    {


        public static void RunMe()
        {
            Node<char> chain1 = GenerateChain(1);
            Node<char> chain2 = GenerateChain(2);
            Console.WriteLine("Question 1");
            Console.WriteLine("----------");
            Console.WriteLine("1st Chain: " + chain1.ToPrint());
            Console.WriteLine("2nd Chain: " + chain2.ToPrint());
            if (IsMatchingChains(chain1, chain2))
                Console.WriteLine("Chains are matching");
            else
                Console.WriteLine("Chains are not matching");
            Console.WriteLine();
            Console.WriteLine("Question 2");
            Console.WriteLine("----------");
            Node<char> chain3 = GenerateRandomChain(10);
            Console.WriteLine("1st Chain: " + chain3.ToPrint());
            Node<char> chain4 = GenerateMatchingChain(chain3);
            Console.WriteLine("2nd Chain: " + chain4.ToPrint());
        }

        private static Node<char> GenerateMatchingChain(Node<char> chain)
        {
            Node<char> newChain = null;
            char ch = ' ';
            while (chain != null)
            {
                Node<char> after = GetLast(newChain);
                switch (chain.GetValue())
                {
                    case 'A':
                        ch = 'T';
                        break;
                    case 'T':
                        ch = 'A';
                        break;
                    case 'C':
                        ch = 'G';
                        break;
                    case 'G':
                        ch = 'C';
                        break;
                }
                if (newChain == null)
                    newChain = new Node<char>(ch);
                else
                    after.SetNext(new Node<char>(ch));
                chain = chain.GetNext();
            }
            return newChain;
        }
        public static Node<char> GetLast(Node<char> lst)

        {
            while (lst != null && lst.HasNext())
                lst = lst.GetNext();
            return lst;
        }

        private static Node<char> GenerateRandomChain(int num)
        {
            Random random = new Random();
            Node<char> newChain = null;
            for (int i = 0; i < num; i++)
            {

                char ch;
                int rndNum = random.Next(1, 5);
                switch (rndNum)
                {
                    case 1:
                        ch = 'A';
                        break;
                    case 2:
                        ch = 'C';
                        break;
                    case 3:
                        ch = 'G';
                        break;
                    default:
                        ch = 'T';
                        break;
                }
                newChain = new Node<char>(ch, newChain);
            }
            return newChain;
        }


        private static bool IsMatchingChains(Node<char> chain1, Node<char> chain2)
        {
            if (NodeLength(chain1) != NodeLength(chain2))
                return false;

            Node<char> pos1 = chain1;
            Node<char> pos2 = chain2;
            while (pos1 != null)
            {
                if (!IsMatch(pos1.GetValue(), pos2.GetValue()))
                    return false;
                pos1 = pos1.GetNext();
                pos2 = pos2.GetNext();
            }
            return true;
        }

        private static bool IsMatch(char a, char b)
        {
            if (a == 'A' && b == 'T') return true;
            if (a == 'T' && b == 'A') return true;
            if (a == 'C' && b == 'G') return true;
            if (a == 'G' && b == 'C') return true;
            return false;
        }

        private static int NodeLength(Node<char> node)
        {
            int len = 0;
            while (node != null)
            {
                len++;
                node = node.GetNext();
            }
            return len;
        }

        private static Node<char> GenerateChain(int num)
        {
            Node<char> newChain;
            if (num == 1)
            {
                newChain = new Node<char>('C');
                newChain = new Node<char>('T', newChain);
                newChain = new Node<char>('C', newChain);
                newChain = new Node<char>('G', newChain);
            }
            else
            {
                newChain = new Node<char>('T');
                newChain = new Node<char>('A', newChain);
                newChain = new Node<char>('G', newChain);
                newChain = new Node<char>('C', newChain);
            }
            return newChain;
        }
    }

}
