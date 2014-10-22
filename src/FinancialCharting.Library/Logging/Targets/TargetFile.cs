#region Usings

using System.IO;

using NLog;
using NLog.Config;
using NLog.Targets;

#endregion

namespace FinancialCharting.Library.Logging.Targets
{
	public class TargetFile
	{
		public LoggingConfiguration Initialize()
		{
			var config = new LoggingConfiguration();

			var target = new FileTarget();
			target.Name = "EventLogTarget";
			target.FileName = Directory.GetCurrentDirectory() + "log.txt";
			target.Layout = @"${longdate} ${message}";

			config.AddTarget("FileTarget", target);

			var rule = new LoggingRule("*", LogLevel.Debug, target);
			config.LoggingRules.Add(rule);

			return config;
		}
	}
}
