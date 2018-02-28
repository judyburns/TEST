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
            List<Car> theCars = new List<Car>();
            try
            {
                LoadCars(theCars);
             }
            catch (InvalidCastException e)
            {
                System.Console.WriteLine("InvalidCastException Error in loading cars. " + e.Message);
                return;
            }
            catch (Exception e)
            {
                System.Console.WriteLine("InvalidCastException Error in loading cars. " + e.Message);
                return;
            }
           
            // instantiate a random object
            Random rnd = new Random();

            // loop 10 times
            for (int counter = 0; counter <= 9; counter++)
            {
                // loop through the cars in the collection and set mileage
                foreach (Car theCar in theCars)
                {
                    theCar.MileageNbr = rnd.Next(30000, 105000);
                    theCar.TuneUp();
                }
            }
            // forces the console to wait for input allowing you to see the output
            var userinput = System.Console.ReadLine();
        }

        static List<Car> LoadCars(List<Car> theCars) {
            try
            {
                // instantiate 5 cars
                Car car1 = new Car("Mustang", "Red", 2005);
                Car car2 = new Car("Tacoma", "Blue", 2008);
                Car car3 = new Car("Explorer", "Red", 2017);
                Car car4 = new Car("Camry", "White", 1999);
                Car car5 = new Car("Kia", "Blue", 2015);

                // load cars into a collection
                theCars.Add(car1);
                theCars.Add(car2);
                theCars.Add(car3);
                theCars.Add(car4);
                theCars.Add(car5);
            }
            catch (InvalidCastException e)
            {
                System.Console.WriteLine("Error in LoadCars Method. " + e.Message);
                throw;
            }
            catch (Exception e)
            {
                System.Console.WriteLine("Error in LoadCars Method. " + e.Message);
                throw;
            }

            return theCars;
        }
    }
}
