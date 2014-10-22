#region Usings

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

#endregion

namespace FinancialCharting.Library.Models.Indicator
{
	public class Indicator
	{
		private List<ArrayList> _indicatorData;

		public Indicator(string name, string type, IReadOnlyCollection<DateTime> datetime, IReadOnlyList<double> indicator)
		{
			Name = name;
			Type = type;

			if (datetime.Count == indicator.Count)
			{
				_indicatorData = datetime.Select((x, y) => new ArrayList {x, indicator[y]}).ToList();
			}
			else
			{}
		}

		public string Name { get; protected set; }

		public string Type { get; protected set; }
	}
}
