using System;
namespace SolidDI
{
    public class ExceptionLogger
    {
		private ILogger logger;

		public ExceptionLogger(ILogger aLogger)
		{
			logger = aLogger;
		}

		public void LogException(Exception aException)
		{
			string strMessage = GetUserReadableMessage(aException);
			logger.LogMessage(strMessage);
		}

		private string GetUserReadableMessage(Exception aException)
		{
			string strMessage = string.Empty;

            strMessage = "Exception thrown";

            return strMessage;
		}
    }
}
