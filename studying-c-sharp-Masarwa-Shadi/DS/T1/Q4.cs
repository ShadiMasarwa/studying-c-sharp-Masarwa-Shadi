using System;

namespace studying_c_sharp_Masarwa_Shadi.DS.T1
{
    public class Q4
    {
        public static void RunTask()
        {
            Node<Circle> lst = new Node<Circle>(new Circle(new Point(10, 5)));
            lst = new Node<Circle>(new Circle(new Point(10, 5)), lst);
            lst = new Node<Circle>(new Circle(new Point(8, 14)), lst);
            lst = new Node<Circle>(new Circle(new Point(10, 5)), lst);
            lst = new Node<Circle>(new Circle(new Point(14, 25)), lst);
            lst = new Node<Circle>(new Circle(new Point(28, 74)), lst);
            lst = new Node<Circle>(new Circle(new Point(10, 5)), lst);
            lst = new Node<Circle>(new Circle(new Point(7, 27)), lst);
            lst = new Node<Circle>(new Circle(new Point(10, 5)), lst);

            Point p = new Point(10, 5);
            Console.WriteLine("{0} circles center in x:{1}, Y:{2}", CenterInPoint(lst, p), p.x, p.y);
        }

        private static int CenterInPoint(Node<Circle> lst, Point p)
        {
            int count = 0;
            Node<Circle> pos = lst;
            while (pos != null)
            {
                if (pos.GetValue().center.x == p.x && pos.GetValue().center.y == p.y)
                    count++;
                pos = pos.GetNext();
            }
            return count;
        }
    }
    public class Circle
    {
        public Point center;

        public Circle(Point center) 
        {
            this.center = center;
        }
    }

    public class Point
    {
        public int x;
        public int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
