#region Usings

using Funq;

using ServiceStack.Api.Swagger;
using ServiceStack.CacheAccess;
using ServiceStack.CacheAccess.Providers;
using ServiceStack.Common;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface.Admin;
using ServiceStack.WebHost.Endpoints;

#endregion

namespace FinancialCharting.Service
{
	public sealed class AppHost : AppHostBase
	{
		public AppHost() : base("Financial Charting Services", typeof (FinancialChartingService).Assembly)
		{
			SetConfig(new EndpointHostConfig
			{
				EnableFeatures = Feature.All.Remove(Feature.Soap11 | Feature.Soap12),
				DebugMode = true,
				AdminAuthSecret = "FinancialChartingService"
			});
		}

		public override void Configure(Container container)
		{
			Plugins.Add(new RequestLogsFeature());
			Plugins.Add(new SwaggerFeature());

			container.Register<ICacheClient>(new MemoryCacheClient());
		}
	}
}
