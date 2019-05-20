using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.VehicleTypes;
using AbstractFactory.BMWVehicles;

namespace AbstractFactory.Factories
{
    public class BMWFactory : VehicleFactory
    {
        public override Convertible CreateConvertible()
        {
            return new BMWConvertible();
        }

        public override EstateCar CreateEstateCar()
        {
            return new BMWEstateCar();
        }

        public override SUV CreateSUV()
        {
            return new BMWSUV();
        }

    
    }
}
