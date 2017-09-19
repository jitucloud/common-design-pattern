using System;
namespace SolidDI
{
    public class FileLogger : ILogger
    {
		public void LogMessage(string aStackTrace)
		{
			Console.WriteLine("Logged to File");
		}
	}
}
