using System;

namespace OOPConsoleTr
{
    class Program
    {
        static void Main()
        {
            Shape Iskwer = new Square();
            Iskwer.setData("Yellow", 5);
            Iskwer.displayInfo();

            Shape Bilog = new Circle();
            Bilog.setData("Maroon", 3);
            Bilog.displayInfo();
        }
    }
    public interface Shape
    {
        double getArea();
        void displayInfo();
        void setData(string color, double sideLength);
    }
    public class Square : Shape {
        public string color;
        public double sideLength;
        public void setData(string color, double sideLength)
        {
            this.color = color;
            this.sideLength = sideLength;
        }
        public double getArea()
        {
            return sideLength * sideLength;
        }

        public void displayInfo()
        {
            Console.WriteLine($"Color: {color}, Area: {getArea()}");
        }
    }

    public class Circle : Shape {
        public string color;
        public double radius;
        public void setData(string color, double radius)
        {
            this.color = color;
            this.radius = radius;
        }
        public double getArea()
        {
            return Math.PI * radius * radius;
        }

        public void displayInfo()
        {
            Console.WriteLine($"Color: {color}, Area: {getArea()}");
        }
    }
}