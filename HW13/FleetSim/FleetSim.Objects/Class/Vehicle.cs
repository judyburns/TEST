using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetSim.Objects.Class
{
    enum Color : byte { Red, White, Blue };
    public class Vehicle
    {
        protected Guid Vin;
        protected int Mileage;
        protected string CarColor;
        protected DateTime LastServicedDate;
        protected int LastServicedMileage;

        public Guid VinNbr
        {
            get { return Vin; }
            set { Vin = value; }
        }

        public int MileageNbr
        {
            get { return Mileage; }
            set { Mileage = value; }
        }
    }
}

