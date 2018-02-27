using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FleetSim.Objects.Class;

namespace FleetSim.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate 5 cars
            Car car1 = new Car("Mustang", "Red", 2005);
            Car car2 = new Car("Tacoma", "Blue", 2008);
            Car car3 = new Car("Explorer", "Red", 2017);
            Car car4 = new Car("Camry", "White", 1999);
            Car car5 = new Car("Kia", "Blue", 2015);

            // load the cars into a collection
            var theCars = new List<Car>
            {
                car1,
                car2,
                car3,
                car4,
                car5
            };

            // instantiate a random object
            Random rnd = new Random();

            // loop 10 times
            for (var i = 0; i <= 9; i++)
            {
                // loop through the cars in the collection and set field values
                foreach (Car theCar in theCars)
                {
                    theCar.MileageNbr = rnd.Next(30000, 105000);
                    theCar.TuneUp();
                }
            }
            // forces the console to wait for input allowing you to see the output
            var input = System.Console.ReadLine();
        }
    }
}
