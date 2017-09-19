using System;
namespace FactoryPattern
{
    public class Bike :IVehicle
    {
		public void Drive(int miles)
		{
			Console.WriteLine("Drive the Bike : " + miles.ToString() + "km");
		}
    }
}
