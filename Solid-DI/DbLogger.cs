using System;
namespace SolidDI
{
    public class DbLogger :ILogger
    {
		public void LogMessage(string aMessage)
		{
            Console.WriteLine("Logged to DB");	
        }
	}
}
