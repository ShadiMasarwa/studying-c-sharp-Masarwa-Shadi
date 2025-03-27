using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.DS.Y3S1.Spring_2024_A
{
    public class Q9
    {
        public static void RunTests()
        {
            One[] arr = new One[6];
            arr[0] = new One(2);
            arr[1] = new Two(4);
            arr[2] = new Two(3, 6);
            arr[3] = arr[0];
            arr[4] = new Two(4);
            arr[5] = arr[1];
            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine(arr[i]);
            //for (int i = 0; i < arr.Length; i++)
            //    arr[i].Update(i + 3);
            //for (int i = 0; i < arr.Length; i++)
            //    Console.WriteLine(arr[i]);
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i].Update(i + 3);
                Console.WriteLine(arr[i]);
            }
        }
    }

    public class One
    {
        protected int n1;
        public One()
        {
            this.n1 = 1;
        }
        public One(int val)
        {
            this.n1 = val;
        }
        public virtual void Update(int k)
        {
            this.n1 = this.n1 * k;
        }
        public override string ToString()
        {
            return "One: n1=" + this.n1;
        }
    }
    public class Two : One
    {
        protected int n2;
        public Two(int val) : base()
        {
            this.n2 = val;
        }
        public Two(int val1, int val2) : base(val1)
        {
            this.n2 = val2;
        }
        public override void Update(int k)
        {
            base.Update(k);
            this.n2 = this.n2 * k;
        }
        public override string ToString()
        {
            return base.ToString() + " Two: n2=" + this.n2;
        }
    }
}
