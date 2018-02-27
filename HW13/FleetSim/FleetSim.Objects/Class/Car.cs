using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FleetSim.Objects.Interface;

namespace FleetSim.Objects.Class
{
    public class Car : Vehicle, ICar
    {
        int Year;
        string Model;

        public Car()
        {
            VinNbr = Guid.NewGuid();
            CarColor = Color.Red.ToString("G");  // default is Red
        }

        public Car(string modelname)
        {
            VinNbr = Guid.NewGuid();
            Model = modelname;
            CarColor = Color.Red.ToString("G");  // default is Red
        }

        public Car(string modelname, string color, int year)
        {
            VinNbr = Guid.NewGuid();
            Year = year;
            Model = modelname;
            Boolean colorExists = Color.IsDefined(typeof(Color), color);
            if (colorExists)
            {
                CarColor = color;
            }
            else
            {
                Console.WriteLine("Car color is not defined");
            }

        }
        public void TuneUp()
        {
            int result = (Mileage - LastServicedMileage);
            if (result >= 30000)
            {
                LastServicedMileage = Mileage;
                LastServicedDate = DateTime.Now;
                Console.WriteLine("Vehicle tuned up at " + LastServicedMileage + " miles on "
                    + LastServicedDate);
            }
            if (Mileage >= 100000)
            {
                RebuildEngine();
            }
        }
        public void RebuildEngine()
        {
            Mileage = 0;
            LastServicedMileage = 0;
            Console.WriteLine("Engine rebuilt on " + LastServicedDate + " for " + Model);
        }
    }
}
