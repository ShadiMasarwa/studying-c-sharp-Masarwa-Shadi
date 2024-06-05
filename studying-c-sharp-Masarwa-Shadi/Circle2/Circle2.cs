using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.Circle2
{
    public class TestCircle2
    {
        public static void RunMe()
        {
            Circle2 c1 = new Circle2(1.1);
            Console.WriteLine("Circle 1A:");
            Console.WriteLine(c1.toString());
            Console.WriteLine("radius is: " + c1.getRadius());
            Console.WriteLine("area is: " + c1.getArea().ToString("0.00"));
            Console.WriteLine("circumference is: " + c1.getCircumference().ToString("0.00"));
            Console.WriteLine();
            c1.setRadius(2.2);
            Console.WriteLine("Circle 1B:");
            Console.WriteLine(c1.toString());
            Console.WriteLine("radius is: " + c1.getRadius());
            Console.WriteLine("area is: " + c1.getArea().ToString("0.00"));
            Console.WriteLine("circumference is: " + c1.getCircumference().ToString("0.00"));
            Console.WriteLine();
            Circle2 c2 = new Circle2();
            Console.WriteLine("Circle 2A:");
            Console.WriteLine(c2.toString());
            Console.WriteLine("radius is: " + c2.getRadius());
            Console.WriteLine("area is: " + c2.getArea().ToString("0.00"));
            Console.WriteLine("circumference is: " + c2.getCircumference().ToString("0.00"));
            Console.WriteLine();
            c2.setRadius(5.6);
            Console.WriteLine("Circle 2B:");
            Console.WriteLine(c2.toString());
            Console.WriteLine("radius is: " + c2.getRadius());
            Console.WriteLine("area is: " + c2.getArea().ToString("0.00"));
            Console.WriteLine("circumference is: " + c2.getCircumference().ToString("0.00"));


        }
    }

    
        public class Circle2
        {
            private double radius;

            public Circle2()
            {
                radius = 1.0;
            }

            public Circle2(double radius)
            {
                this.radius = radius;
            }

            public double getRadius()
            {
                return radius;
            }

            public void setRadius(double radius)
            {
                this.radius = radius;
            }


            public double getArea()
            {
                return Math.Pow(radius,2) * Math.PI;
            }

            public double getCircumference()
            {
                return  2 * radius * Math.PI;
            }

            public string toString()
            {
                return "Circle [radius=" + radius + "]";
            }
        }
}
