#region Usings

using System.Collections.Generic;
using System.Runtime.Serialization;

using FinancialCharting.Library.Models.MarketData.Common;

#endregion

namespace FinancialCharting.Library.Models.MarketData.NotImplemented
{
	/// BARB ["Date","FTSE","FTSE-MVP"]
	[DataContract]
	public class BarbData
	{
		[DataMember(Name = "FTSE")]
		public double FTSE { get; set; }

		[DataMember(Name = "FTSEMVP")]
		public double FTSEMVP { get; set; }
	}
}
