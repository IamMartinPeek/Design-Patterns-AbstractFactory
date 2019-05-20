using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Factories;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleFactory vehicleFactory;

            Console.WriteLine("Would you like a (1)Mercedes or a (2)BMW?");
            int brandChoice = Convert.ToInt32(Console.ReadLine());
            if(brandChoice == 1)
                vehicleFactory = new MercedesFactory();
            else if(brandChoice == 2)
                vehicleFactory = new BMWFactory();
            else
                throw new ArgumentException();

            Console.WriteLine("Would you like an (1)Estate car, a (2)SUV or a (3)Convertible?");
            int vehicleTypeChoice = Convert.ToInt32(Console.ReadLine());

            if (vehicleTypeChoice == 1)
                Console.WriteLine("You got a: " + vehicleFactory.CreateEstateCar().GetType().Name);
            else if (vehicleTypeChoice == 2)
                Console.WriteLine("You got a: " + vehicleFactory.CreateSUV().GetType().Name);
            else if (vehicleTypeChoice == 3)
                Console.WriteLine("You got a: " + vehicleFactory.CreateConvertible().GetType().Name);
            else
                throw new ArgumentException();

            Console.ReadLine();

        }
    }
}
