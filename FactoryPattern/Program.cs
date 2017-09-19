using System;

namespace FactoryPattern
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            VehicleFactory factory = new ConcreteVehicleFactory();

            IVehicle scooter = factory.GetVehicle("Scooter");
			scooter.Drive(10);

            IVehicle bike = factory.GetVehicle("Bike");
			bike.Drive(20);

			IVehicle nothing = factory.GetVehicle("dd");
            nothing.Drive(20);

			Console.ReadKey();      
        }
    }
}
