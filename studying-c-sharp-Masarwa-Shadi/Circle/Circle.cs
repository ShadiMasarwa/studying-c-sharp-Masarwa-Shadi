using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.Circle
{
    public class TestCircle1
    {  
        public static void RunMe()
        {
            Circle c1 = new Circle();
            Console.WriteLine(c1.ToString());
            Console.WriteLine("The circle has radius of " + c1.GetRadius() + " and area of " + c1.GetArea());
            c1.SetColor("black");
            Console.WriteLine(c1.ToString());
            Console.WriteLine();

            Circle c2 = new Circle(2.0);
            Console.WriteLine(c2.ToString());
            Console.WriteLine ("The circle has radius of " + c2.GetRadius() + " and area of " + c2.GetArea());
            c2.SetRadius(3.8);
            Console.WriteLine("The circle has radius of " + c2.GetRadius() + " and area of " + c2.GetArea());
        }
    }
    public class Circle
    {
        private double radius;
        private string color;

        public Circle()
        {  
            radius = 1.0;
            color = "red";
        }

        public Circle(double r)
        {  
            radius = r;
            color = "red";
        }

        public double GetRadius()
        {
            return radius;
        }

        public void SetRadius(double radius)
        {
            this.radius = radius;
        }

        public string GetColor()
        {
            return color;
        }

        public void SetColor(string color)
        {
            this.color = color;
        }

        public double GetArea()
        {
            return radius * radius * Math.PI;
        }

        public override string ToString()
        {
            return "Circle [radius=" + radius + " color=" + color + "]";
        }
    }
}
