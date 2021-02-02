using System;

namespace Virtual
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Car();
            vehicle.Run();
            vehicle.Stopped(); 

            vehicle = new Truck();
            vehicle.Run();
            vehicle.Stopped(); 
        }
    }

    class Vehicle
    {
        public void Stopped()
        {
            Console.WriteLine("Vehicle stopped.");
        }

        public virtual void Run() { }
    }

    class Car : Vehicle
    {
        public override void Run()
        {
            Console.WriteLine("Car is running.");
        }
    }

    class Truck : Vehicle
    {
        public override void Run()
        {
            Console.WriteLine("Truck is running.");
        }
    }

}
