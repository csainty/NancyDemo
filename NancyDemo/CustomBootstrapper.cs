using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy.Bootstrappers.Ninject;
using NancyDemo.Data;
using Ninject;

namespace NancyDemo
{
	public class CustomBootstrapper : NinjectNancyBootstrapper
	{
		protected override void InitialiseInternal(IKernel container)
		{
			base.InitialiseInternal(container);
			container.Bind<IDataStore>().To<InMemoryDataStore>().InSingletonScope();
		}
	}
}