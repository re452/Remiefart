using System;
using ououoop;

namespace ououoop
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello, World!");
            // Program2 name1 = new Program2();
            // Program2 name2 = new Program2();
            // name1.Hello("aaaa1");
            // name2.Hello("aaaa2");

            Vehicle kotse1 = new Vehicle(); // creating an instance of the base class
            Car kotse2 = new Car(); // creating an instance of the derived class
            Car kotse3 = new Car();
            kotse1.StartEngine(); // calling the method from the base class
            kotse2.UmaandarSa(); // calling the method from the derived class
            kotse2.StartEngine();
            kotse3.InputData("Red", 25500, 4); // inputting data into the derived class
            kotse3.Intro();
            kotse3.Passenger("Remie"); // method overloading
            kotse3.Passenger(4);
            kotse3.Passenger(6);
            kotse3.Travel(); // overriding the base class method

        }
    }
    public class Vehicle // base class (or parent class)
        {
        public string color;
        public double price;
        public void StartEngine() // method
        {
            Console.WriteLine("Broom broom!");
        }
        public virtual void Travel() // virtual method to allow overriding
        {
            Console.WriteLine("Travel anywhere");
        }
    }
    public class Car : Vehicle // derived class (or child class)
    {
        public int wheels;
        public void UmaandarSa()
        {
            Console.WriteLine("Umaandar sa lupa");
        }

        public void InputData(string color, double price, int wheels) // method to input data
        {
            this.color = color;
            this.price = price;
            this.wheels = wheels;
        }

        public void Intro() 
        {
            Console.WriteLine($"The car's color is {color} with the price of P{price}, and it has {wheels} wheels.");
        }
        public void Passenger(string name) // method overloading
        {
            Console.WriteLine($"Welcome {name}!");
        }
        public void Passenger(int number) // method overloading
        {

            if (number < 5)
            {
                Console.WriteLine($"Kasya kayong {number}.");
                return;
            }
            else
            {
                Console.WriteLine("Sobrang dami niyo na!");
                return;
            }

        }
        public override void Travel() // overriding the base class method
        {
            Console.WriteLine("Traveling by land");
        }
    }
}
