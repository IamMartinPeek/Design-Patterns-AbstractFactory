using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.VehicleTypes;
using AbstractFactory.MercedesVehicles;

namespace AbstractFactory.Factories
{
    public class MercedesFactory : VehicleFactory
    {
        public override Convertible CreateConvertible()
        {
            return new MercedesConvertible();
        }

        public override EstateCar CreateEstateCar()
        {
            return new MercedesEstateCar();
        }

        public override SUV CreateSUV()
        {
            return new MercedesSUV();
        }

    }
}
