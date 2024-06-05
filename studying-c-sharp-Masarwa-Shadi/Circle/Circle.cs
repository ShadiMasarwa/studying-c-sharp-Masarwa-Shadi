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
            Console.WriteLine(c1.toString());
            Console.WriteLine("The circle has radius of " + c1.getRadius() + " and area of " + c1.getArea());
            c1.setColor("black");
            Console.WriteLine(c1.toString());
            Console.WriteLine();

            Circle c2 = new Circle(2.0);
            Console.WriteLine(c2.toString());
            Console.WriteLine ("The circle has radius of " + c2.getRadius() + " and area of " + c2.getArea());
            c2.setRadius(3.8);
            Console.WriteLine("The circle has radius of " + c2.getRadius() + " and area of " + c2.getArea());
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

        public double getRadius()
        {
            return radius;
        }

        public void setRadius(double radius)
        {
            this.radius = radius;
        }

        public string getColor()
        {
            return color;
        }

        public void setColor(string color)
        {
            this.color = color;
        }

        public double getArea()
        {
            return radius * radius * Math.PI;
        }

        public string toString()
        {
            return "Circle [radius=" + radius + " color=" + color + "]";
        }
    }
}
