using Autofac;

namespace Incomm.Sachi.Core.Domain.IoC
{
    public static class Bootstrapper
    {
        public static IContainer BuildContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule(new ServiceModule());
            return builder.Build();
        }
    }
}
