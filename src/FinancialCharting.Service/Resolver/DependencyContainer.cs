#region Usings

using System;

using Autofac;

using FinancialCharting.Library.Logging;
using FinancialCharting.Library.Quandl;
using FinancialCharting.Library.Quandl.Interfaces;
using FinancialCharting.Library.TALib;
using FinancialCharting.Library.TALib.Interfaces;

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
							builder.RegisterType<QuandlProvider>().As<IQuandlProvider>().SingleInstance();
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
