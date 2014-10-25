#region Usings

using System.Collections.Generic;
using System.Runtime.Serialization;

using FinancialCharting.Library.Models.MarketData.Common;

#endregion

namespace FinancialCharting.Library.Models.MarketData.NotImplemented
{
	/// MONEYTREE ["Year", "Biotechnology Deals", "Business Products and Services Deals", "Computers and Peripherals Deals", "Consumer Products and Services Deals","Electronics/Instrumentation Deals","Financial Services Deals","Healthcare Services Deals","Industrial/Energy Deals","IT Services Deals","Media and Entertainment Deals","Medical Devices and Equipment Deals","Networking and Equipment Deals","Other Deals","Retailing/Distribution Deals","Semiconductors Deals","Software Deals","Telecommunications Deals","Total Deals"]
	[DataContract]
	public class MoneyTreeData
	{
		[DataMember(Name = "BiotechnologyDeals")]
		public string BiotechnologyDeals { get; set; }

		[DataMember(Name = "BusinessProductsServicesDeals")]
		public string BusinessProductsServicesDeals { get; set; }

		[DataMember(Name = "ComputersPeripheralsDeals")]
		public string ComputersPeripheralsDeals { get; set; }

		[DataMember(Name = "ConsumerProductsServicesDeals")]
		public string ConsumerProductsServicesDeals { get; set; }

		[DataMember(Name = "ElectronicsInstrumentationDeals")]
		public string ElectronicsInstrumentationDeals { get; set; }

		[DataMember(Name = "FinancialServicesDeals")]
		public string FinancialServicesDeals { get; set; }

		[DataMember(Name = "HealthcareServicesDeals")]
		public string HealthcareServicesDeals { get; set; }

		[DataMember(Name = "IndustrialEnergyDeals")]
		public string IndustrialEnergyDeals { get; set; }

		[DataMember(Name = "ITServicesDeals")]
		public string ITServicesDeals { get; set; }

		[DataMember(Name = "MediaEntertainmentDeals")]
		public string MediaEntertainmentDeals { get; set; }

		[DataMember(Name = "MedicalDevicesEquipmentDeals")]
		public string MedicalDevicesEquipmentDeals { get; set; }

		[DataMember(Name = "NetworkingEquipmentDeals")]
		public string NetworkingEquipmentDeals { get; set; }

		[DataMember(Name = "OtherDeals")]
		public string OtherDeals { get; set; }

		[DataMember(Name = "RetailingDistributionDeals")]
		public string RetailingDistributionDeals { get; set; }

		[DataMember(Name = "SemiconductorsDeals")]
		public string SemiconductorsDeals { get; set; }

		[DataMember(Name = "SoftwareDeals")]
		public string SoftwareDeals { get; set; }

		[DataMember(Name = "TelecommunicationsDeals")]
		public string TelecommunicationsDeals { get; set; }

		[DataMember(Name = "TotalDeals")]
		public string TotalDeals { get; set; }
	}
}
