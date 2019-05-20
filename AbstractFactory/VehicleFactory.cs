using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.VehicleTypes;

namespace AbstractFactory
{
    public abstract class VehicleFactory
    {
        public abstract SUV CreateSUV();
        public abstract Convertible CreateConvertible();
        public abstract EstateCar CreateEstateCar();
    
    }
}
