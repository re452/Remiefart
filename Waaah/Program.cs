using System;

namespace Waaah
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape iskwer = new Square("Yellow", 10);
            Console.WriteLine($"Square Color: {iskwer.color}, Area: {iskwer.getArea()}");

            Shape bilog = new Circle("Green", 5);
            Console.WriteLine($"Circle Color: {bilog.color}, Area: {bilog.getArea()}");

            iskwer.Dispose();
            bilog.Dispose();
        }
    }

    public abstract class Shape : IDisposable
    {
        public string color;
        public double sideLength;
        private bool disposed = false;

        public Shape(string color = "Unknown", double sideLength = 0)
        {
            this.color = color;
            this.sideLength = sideLength;
            Console.WriteLine("Shape Created");
        }

        ~Shape()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                Console.WriteLine("Shape Destroyed");
                disposed = true;
            }
        }

        public abstract double getArea();
        public abstract void displayColor();
    }

    public class Square : Shape
    {
        public Square(string color, double sideLength) : base(color, sideLength) { }

        public override double getArea()
        {
            return sideLength * sideLength;
        }
        public override void displayColor()
        {
            Console.WriteLine($"Square Color: {color}");
        }
    }

    public class Circle : Shape
    {
        public Circle(string color, double radius) : base(color, radius) { }

        public override double getArea()
        {
            return Math.PI * sideLength * sideLength;
        }
        public override void displayColor()
        {
            Console.WriteLine($"Circle Color: {color}");
        }
    }
}