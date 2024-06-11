using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.DS.T1
{
    public class Q5
    {
        public static void RunTasks()
        {
            //Node<Expr> lst = null;
            Node<Expr> lst = new Node<Expr>(new Expr(10, '+', 20));
            lst = new Node<Expr>(new Expr(10, '+', 20), lst);
            lst = new Node<Expr>(new Expr(100, '-', 20), lst);
            lst = new Node<Expr>(new Expr(-5, '*', 56), lst);
            lst = new Node<Expr>(new Expr(58, '/', 6), lst);
            lst = new Node<Expr>(new Expr(17, '/', 2), lst);
            lst = new Node<Expr>(new Expr(77, '+', 22), lst);
            lst = new Node<Expr>(new Expr(17, '/', 8), lst);

            Console.WriteLine("Sum of all results - " + SumExpressions(lst));

        }

        private static double SumExpressions(Node<Expr> node)
        {
            double sum = 0, result;
            while (node != null)
            {
                result = node.GetValue().Calculate();
                Console.WriteLine(node.ToString() + "= " + result);
                sum += result;
                node = node.GetNext();
            }
            return sum;
        }

    }

    public class Expr
    {
        private double num1;
        private double num2;
        private char op;

        public Expr(double num1, char op, double num2)
        {
            this.num1 = num1;
            this.num2 = num2;
            this.op = op;
        }
        public double Calculate()
        {
            switch (op)
            {
                case '+':
                    return num1 + num2;
                case '-':
                    return num1 - num2;
                case '*':
                    return num1 * num2;
                case '/':
                    return num2 / num1;
                default:
                    return 0;
            }
        }

        public double GetNum1()
        {
            return num1;
        }
        public double GetNum2()
        {
            return num2;
        }
        public char GetOp()
        {
            return op;
        }
        public override string ToString()
        {
            return num1 + " " + op + " " + num2;
        }
    }
}
