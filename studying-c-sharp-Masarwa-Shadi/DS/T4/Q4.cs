using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.DS.T4
{
    public class Q4
    {
        public static void RunMe()
        {
            Game board = new Game(10);
            //Console.WriteLine(board.head.ToPrintCircleChain());
            Node<int> lastNum = board.GetLastNode();
            Node<int> pos = board.head;
            Console.ForegroundColor= ConsoleColor.White;
            Console.WriteLine("*************************************");
            Console.WriteLine("Start Position:");
            board.Print(pos);
            Console.WriteLine("*************************************");

            while (pos != lastNum)
            {
                int dice = board.Dice();
                Node<int> prevNode = pos;
                pos = pos.GetNext();
                for (int i = 0; i < dice-1; i++)
                {
                    prevNode = prevNode.GetNext();
                    pos = pos.GetNext();
                }
                if (pos.GetValue() == 0)
                {
                    board.Print(pos);
                    Console.ForegroundColor= ConsoleColor.Green;
                    Console.WriteLine("0 - One step back");
                    Console.ForegroundColor= ConsoleColor.White;

                    pos = prevNode;
                }
                board.Print(pos);

            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("*************************************");
            Console.WriteLine("Game Over");
            Console.WriteLine("*************************************");
        }
    }

    public class Game
    {
        public Node<int> head = null;
        int maxNum = 5;

        public Game(int num)
        {
            Node<int> pos = head;
            Random random = new Random();

            for (int i = 1; i <= num; i++)
            {
                if (head == null)
                {
                    head = new Node<int>(random.Next(1,maxNum));
                    pos = head;
                }
                else
                {
                    if (pos.GetValue() != 0)
                        pos.SetNext(new Node<int>(random.Next(0, maxNum)));
                    else
                        pos.SetNext(new Node<int>(random.Next(1, maxNum)));
                    pos = pos.GetNext();
                }
                
            }
            Node<int> temp = new Node<int>(random.Next(1, maxNum), head);
            pos.SetNext(temp);
        }
        public int Dice()
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());

            int num1 = random.Next(1,7);
            int num2 = random.Next(1, 7);
            Console.ForegroundColor= ConsoleColor.Blue;
            Console.WriteLine($"Dice({num1},{num2}) = {num1+num2}");
            Console.ForegroundColor = ConsoleColor.White;

            return num1 +num2;
        }

        public Node<int> GetLastNode()
        {
            Node<int> pos = head;
            while (pos.GetNext()!=head)
                pos=pos.GetNext();
            return pos;
        }

        public void Print(Node<int> pos)
        {
            Node<int> posTemp = head;
            do
            {
                if (posTemp == pos)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(posTemp.GetValue());
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(", ");
                }
                else
                    Console.Write(posTemp.GetValue() + ", ");
                posTemp = posTemp.GetNext();
            } while (posTemp != head);
            Console.Write("Loop\n");
        }
        }
        
    }

