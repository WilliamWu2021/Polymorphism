using System;

namespace Abstract
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

            vehicle = new RaceCar();
            vehicle.Run();
            vehicle.Stopped();
        }
    }

    abstract class Vehicle
    {
        //public void Stopped()
        //{
        //    Console.WriteLine("Vehicle stopped.");
        //}

        abstract public void Run();

        abstract public void Stopped(); 
    }

    class Car : Vehicle
    {
        public override void Run()
        {
            Console.WriteLine("Car is running.");
        }

        public override void Stopped()
        {
            Console.WriteLine("Car stopped.");
        }
    }

    class Truck : Vehicle
    {
        public override void Run()
        {
            Console.WriteLine("Truck is running.");
        }

        public override void Stopped()
        {
            Console.WriteLine("Truck stopped.");
        }
    }

    class RaceCar : Vehicle
    {
        public override void Run()
        {
            Console.WriteLine("RaceCar is running.");
        }

        public override void Stopped()
        {
            Console.WriteLine("RaceCar stopped.");
        }
    }
}
