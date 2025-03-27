using System;

namespace studying_c_sharp_Masarwa_Shadi.DS.Y3S1.Spring_2024_B
{
    public class Q11
    {
        public static void Run()
        {
            A[] data = new A[5];
            data[0] = new A(5);
            data[1] = new B(5, 10);
            data[2] = new C(5, 10, 15);
            data[3] = data[0];
            data[4] = new B(5);
            for (int i = 0; i < data.Length; i++)
                Console.WriteLine(data[i]);
            for (int i = 0; i < data.Length; i++)
                data[i].Change();
            for (int i = 0; i < data.Length; i++)
                Console.WriteLine(data[i]);
        }
    
    }
    public class A
    {
        protected int x;
        public A()
        {
            this.x = 1;
        }
        public A(int x)
        {
            this.x = x;
        }
        public virtual void Change()
        {
            this.x = this.x * 2;
        }
        public override string ToString()
        {
            return "X=" + this.x;
        }
    }
    public class B : A
    {
        protected int y;
        public B(int y)
        {
            this.y = -y;
        }
        public B(int x, int y) : base(x)
        {
            this.y = -y;
        }
        public override string ToString()
        {
            return base.ToString() + " Y=" + this.y;
        }
    }
    public class C : B
    {
        private int z;
        public C(int x, int y, int z) : base(x, y)
        {
            this.z = z;
        }
        public override void Change()
        {
            this.x = 3 * this.x;
            this.y = 3 * this.y;
            this.z = 3 * this.z;
        }
        public override string ToString()
        {
            return base.ToString() + " Z=" + this.z;
        }
    }







}
