#region Usings

using System;

using Autofac;

using FinancialCharting.Library.Logging;
using FinancialCharting.QuandlProvider;
using FinancialCharting.QuandlProvider.Interfaces;
using FinancialCharting.TechnicalAnalysisLibrary;
using FinancialCharting.TechnicalAnalysisLibrary.Interfaces;

#endregion

namespace FinancialCharting.Service.Resolver
{
	public static class DependencyContainer
	{
		private static volatile IContainer _instance;
		private static readonly object SyncRoot = new Object();

		public static IContainer Instance
		{
			get
			{
				if (_instance == null)
				{
					lock (SyncRoot)
					{
						if (_instance == null)
						{
							var builder = new ContainerBuilder();
							builder.RegisterType<LogWrapper>().As<ILogWrapper>().SingleInstance();
							builder.RegisterType<QuandlMapper>().As<IQuandlMapper>().SingleInstance();
							builder.RegisterType<QuandlDataProvider>().As<IQuandlDataProvider>().SingleInstance();
							builder.RegisterType<TALibProvider>().As<ITALibProvider>().SingleInstance();
							builder.RegisterType<TechnicalIndicatorsManager>().As<TechnicalIndicatorsManager>().SingleInstance();
							_instance = builder.Build();
						}
					}
				}

				return _instance;
			}
		}
	}
}
