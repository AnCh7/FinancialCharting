#region Usings

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using FinancialCharting.Library.ProjectExceptions;

#endregion

namespace FinancialCharting.Library.Models.Indicator
{
	[DataContract]
	public class Indicator
	{
		public Indicator(string name, string type, List<DateTime> datetime, List<double> indicator)
		{
			Name = name;
			Type = type;

			if (datetime.Count == indicator.Count)
			{
				IndicatorData = new Dictionary<DateTime, double>();

				for (var i = 0; i < datetime.Count; i++)
				{
					IndicatorData.Add(datetime[i], indicator[i]);
				}
			}
			else
			{
				throw new IndicatorException("This indicator type is not supported");
			}
		}

		[DataMember(Name = "name")]
		public string Name { get; protected set; }

		[DataMember(Name = "type")]
		public string Type { get; protected set; }

		[DataMember(Name = "indicatorData")]
		public Dictionary<DateTime, double> IndicatorData { get; protected set; }
	}
}
