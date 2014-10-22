#region Usings

using NLog;
using NLog.Config;
using NLog.Targets;

#endregion

namespace FinancialCharting.Library.Logging.Targets
{
	public sealed class TargetWindowsEvents
	{
		public LoggingConfiguration Initialize()
		{
			var config = new LoggingConfiguration();

			var target = new EventLogTarget();
			target.Source = "FinancialCharting";
			target.Log = "Application";
			target.MachineName = ".";
			target.Name = "EventLogTarget";
			target.Layout = "${message}";

			config.AddTarget("EventLogTarget", target);

			var rule = new LoggingRule("*", LogLevel.Debug, target);
			config.LoggingRules.Add(rule);

			return config;
		}
	}
}
