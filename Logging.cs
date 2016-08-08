using System;

namespace CopySrfLoyalty
{
	public static class Logging
	{
		public static Logging log;
		int _logLevel;
		string filename;

		public static void  SetLogLevel(int logLevel)
		{
			log._logLevel = logLevel;
		}

		public void Log (string logLevel, Exception ex)
		{

			if (logLevel <= CopySrfLoyalty)
		}

	}
}

