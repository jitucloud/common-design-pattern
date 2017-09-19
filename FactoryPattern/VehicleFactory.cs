using System;
namespace FactoryPattern
{
    public abstract class VehicleFactory
    {
        public abstract IVehicle GetVehicle(string Vehicle);
	}
}
