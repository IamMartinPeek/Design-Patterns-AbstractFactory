using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.VehicleTypes
{
    public abstract class Vehicle
    {
        protected string _Name;
        protected int _HorsePower;

        public int HorsePower { get => _HorsePower; set => _HorsePower = value; }
        public string Name { get => _Name; set => _Name = value; }
    }
}
