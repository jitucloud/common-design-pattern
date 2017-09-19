using System;
using System.IO;

namespace SolidDI
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			ExceptionLogger _exceptionLogger;

			try
			{ 
                 throw new IOException();
            }
			catch (IOException ex)
			{
				_exceptionLogger = new ExceptionLogger(new DbLogger());
				_exceptionLogger.LogException(ex);
			}
			catch (Exception ex)
			{
				_exceptionLogger = new ExceptionLogger(new FileLogger());
				_exceptionLogger.LogException(ex);
			}
		}
    }
}
