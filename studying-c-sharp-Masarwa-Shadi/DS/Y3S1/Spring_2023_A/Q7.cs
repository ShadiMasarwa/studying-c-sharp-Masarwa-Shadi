namespace studying_c_sharp_Masarwa_Shadi.DS.Y3S1.Spring_2023_A
{
    public class Q7
    {
        public static void RunMe()
        {
            BinNode<int> four = new BinNode<int>(4);
            BinNode<int> one = new BinNode<int>(1);
            BinNode<int> nine= new BinNode<int>(9);
            BinNode<int> twenty = new BinNode<int>(20);
            BinNode<int> two = new BinNode<int>(2);
            BinNode<int> seven= new BinNode<int>(7);
            //four.SetLeft(one);
            //one.SetRight(nine);
            four.SetRight(twenty);
            //twenty.SetLeft(two);
            twenty.SetRight(seven);
            System.Console.WriteLine(What(four));
            System.Console.WriteLine(Why(four));
        }
        public static string What(BinNode<int> t)
        {
            string output = "(";
            if (t.GetLeft() != null)
                output += What(t.GetLeft());
            output += t.GetValue();
            if (t.GetRight() != null)
                output += What(t.GetRight());
            output += ")";
            return output;
        }
        public static string Why(BinNode<int> t)
        {
            string output = "(";
            output += t.GetValue();
            if (t.GetLeft() != null)
                output += Why(t.GetLeft());
            if (t.GetRight() != null)
                output += Why(t.GetRight());
            output += ")";
            return output;
        }

    }
}
