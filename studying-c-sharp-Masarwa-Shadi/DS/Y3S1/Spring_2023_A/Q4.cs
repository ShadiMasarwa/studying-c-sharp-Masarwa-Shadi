using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.DS.Y3S1.Spring_2023_A
{
    internal class Q4
    {
    }

    public class A
    {
        protected int x;
        public A()
        {
            this.x = 5;
        }
        public virtual int Method() { return 1; }
        //public virtual double Method(int i) { return i; }
        public virtual void Method(double i) { Console.Write(i); }
        public A(int x)
        {
            this.x = x;
        }
        public A(int x, int y) : this(x + y)
        {
        }
        public int Method(int i)
        {
            return x + i;
        }
        public override string ToString()
        {
            return this.x + " * ";
        }
    }
    public class B : A
    {
        private int y;
        public B(int x) : base(x, x)
        {
            this.y = x;
        }
        public B(int x, int y) : this(x * y)
        {
        }
        public B(string s)
        {
            Console.WriteLine(s + "% " + this.y);
        }
        public override string ToString()
        {
            return this.x + " " + this.y;
        }
    }

}
