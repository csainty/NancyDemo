using Nancy;
using NancyDemo.Data;

namespace NancyDemo
{
	public class CustomBootstrapper : DefaultNancyBootstrapper
	{
        protected override void ConfigureApplicationContainer(TinyIoC.TinyIoCContainer container)
        {
            container.Register<IDataStore, InMemoryDataStore>().AsSingleton();
        }
	}
}