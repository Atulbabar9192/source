using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstactclass
{
       public abstract class Figure
       {
        public double Hight, Width, Radius;
        public const float pi = 3.14f;
        public abstract double GetArea();
       }
        public class Rectangle : Figure
        {
        public Rectangle(double Hight, double Width)
        {
         this.Hight=Hight;
         this.Width=Width;
        }
        public override double GetArea()
        {
            return (Hight * Width);
        }
        }
        public class Circle: Figure
        {
        public Circle(double Radius)
        {
            this.Radius = Radius;
        }
        public override double GetArea()
        {
            return pi * Radius * Radius;
        }
        }
        class TestFigure
        {
        static void Main()
        {
            Rectangle r = new Rectangle(10.12, 12.15);
            Circle c = new Circle(15);
            Console.WriteLine("Area of Rectangle is:" + r.GetArea());
            Console.WriteLine("Area of Circle is:" + c.GetArea());
            Console.ReadLine();

        }
      }
}
