using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Car();
            vehicle.Run();
            ((Car)vehicle).Stopped();
            vehicle.Fuel();


            vehicle = new Truck();
            vehicle.Run();
            vehicle.Stopped();
            vehicle.Fuel();

            //RaceCar raceCar = new RaceCar();
            //raceCar.Run();
            //raceCar.Stopped();
            //raceCar.Fuel();
            vehicle = new RaceCar();
            vehicle.Run();
            ((RaceCar)vehicle).Stopped();
            vehicle.Fuel();

            IVehicle vehicle1 = new test();
            vehicle1.SayHi(); 
        }
    }

    interface IVehicle
    {
        public void SayHi()
        {
            Console.WriteLine("Hello!");
        }
        //public void Stopped()
        //{
        //    Console.WriteLine("Vehicle stopped.");
        //}

        void Run();

        void Stopped();

        void Fuel();
    }

    class test : IVehicle
    {
        public void Fuel()
        {
            throw new NotImplementedException();
        }

        public void Run()
        {
            throw new NotImplementedException();
        }

        public void Stopped()
        {
            throw new NotImplementedException();
        }
    }

    abstract class Vehicle : IVehicle
    {
        abstract public void Fuel();

        abstract public void Run();

        public void Stopped()
        {
            Console.WriteLine("Vehicle stopped.");
        }
    }

    class Car : Vehicle
    {
        public override void Fuel()
        {
            Console.WriteLine("Car is fueling");
        }

        public override void Run()
        {
            Console.WriteLine("Car is running.");
        }

        public new void Stopped()
        {
            Console.WriteLine("Car stopped.");
        }
    }

    class Truck : Vehicle
    {
        public override void Fuel()
        {
            Console.WriteLine("Truck is fueling");
        }

        public override void Run()
        {
            Console.WriteLine("Truck is running.");
        }

        public new void Stopped()
        {
            Console.WriteLine("Truck stopped.");
        }
    }

    class RaceCar : Vehicle
    {
        public override void Fuel()
        {
            Console.WriteLine("RaceCar is fueling");
        }

        public override void Run()
        {
            Console.WriteLine("RaceCar is running.");
        }

        public new void Stopped()
        {
            Console.WriteLine("RaceCar stopped.");
        }
    }
} 
