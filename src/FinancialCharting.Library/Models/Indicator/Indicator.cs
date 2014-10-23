#region Usings

using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;

using ServiceStack.Text;

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
				var arrayList = new ArrayList();

				for (var i = 0; i < datetime.Count; i++)
				{
					var item = new {Date = datetime[i], Value = indicator[i]};
					arrayList.Add(item);
				}

				IndicatorData = arrayList.ToJson();
			}
			else
			{
				throw new NotSupportedException();
			}
		}

		[DataMember(Name = "name")]
		public string Name { get; protected set; }

		[DataMember(Name = "type")]
		public string Type { get; protected set; }

		[DataMember(Name = "indicatorData")]
		public string IndicatorData { get; protected set; }
	}
}
