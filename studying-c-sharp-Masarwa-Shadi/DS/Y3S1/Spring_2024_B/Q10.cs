using System;

namespace studying_c_sharp_Masarwa_Shadi.DS.Y3S1.Spring_2024_B
{
    public class Q10
    {
        public static void RunTests()
        {
            One[] arr = new One[5];
            arr[0] = new One(25);
            arr[1] = new One();
            arr[2] = new Two();
            arr[3] = new Two(15, arr[0]);
            arr[4] = new Two(2, "CCC", arr[1]);
        }
    }
    public class One
    {
        protected int val;

        public One(int val)
        {
            this.val = val;
        }
        public One()
        {
            val = 10;
        }
    }
    public class Two : One
    {
        private String s;
        private One p;

        public Two()
        {
            s = "AAA";
        }

        public Two(int val, One p) : base(val)
        {
            this.p = new One(13);
            s = "CCC";
        }

        public Two(int val, string s, One p) : base(val)
        {
            this.p = p;
            this.s = s;
        }

}

}
