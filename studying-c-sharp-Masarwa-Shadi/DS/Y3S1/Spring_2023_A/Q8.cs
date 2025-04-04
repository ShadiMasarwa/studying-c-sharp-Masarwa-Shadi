﻿using System;

namespace studying_c_sharp_Masarwa_Shadi.DS.Y3S1.Spring_2023_A
{
    public class Q8
    {
        public static void RunMe()
        {
            Tester.Run(); 
        }
    }
    public class Tester
    {
        public static void Print(One[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(i + " " + arr[i]);
            }
        }
        public static void DoF(One[] arr, int num)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i].F(num);
            }
        }
        public static void What(One[] arr)
        {
            int k = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] is Two)
                    k++;
            }
            k = arr.Length - k;
            Console.WriteLine("k = " + k);
        }
        public static void Run()
        {
            One[] arr = new One[6];
            arr[0] = new One();
            arr[1] = new One(3);
            arr[2] = new Two();
            arr[3] = new Two(2);
            arr[4] = new Two(5);
            arr[5] = arr[1];
            Print(arr);
            DoF(arr, 2);
            Print(arr);
            //What(arr);
        }
    }

    public class One
    {
        protected int x;
        public One()
        {
            this.x = 1;
        }
        public One(int x)
        {
            this.x = x;
        }
        public virtual void F(int x)
        {
            this.x += x;
        }
        public override string ToString()
        {
            return "x=" + this.x;
        }
    } // end of One
    public class Two : One
    {
        public Two() : base(3)
        {
        }
        public Two(int x)
        {
            base.F(x);
            F(x);
        }
        public override void F(int x)
        {
            this.x -= x;
            base.F(x);
        }
    }// end of Two
}
