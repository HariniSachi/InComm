using System.Collections.Generic;
using Autofac;
using AutoMapper;
using Incomm.Sachi.Core.Client.Data;
using Incomm.Sachi.Core.Domain.Converter;
using Incomm.Sachi.Core.Domain.DataAccess;
using Incomm.Sachi.Core.Domain.Model;
using NLog;

namespace Incomm.Sachi.Core.Domain.IoC
{
    public class ServiceModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<IList<Menu>, IList<MenuDto>>().ConvertUsing<MenuOutConverter>();
            });

            builder.Register(c => config.CreateMapper()).As<IMapper>().SingleInstance();
            builder.Register(c => LogManager.GetLogger("Service")).As<ILogger>().SingleInstance();
            builder.RegisterType<MenuDao>().As<IDao<Menu>>().SingleInstance().PropertiesAutowired(PropertyWiringOptions.None);
            builder.RegisterType<CategoryDao>().As<IBaseDao<Category>>().SingleInstance().PropertiesAutowired(PropertyWiringOptions.None);
            builder.RegisterType<DrinkSizeDao>().As<IBaseDao<DrinkSize>>().SingleInstance().PropertiesAutowired(PropertyWiringOptions.None);
            builder.RegisterType<DrinkTypeDao>().As<IBaseDao<DrinkType>>().SingleInstance().PropertiesAutowired(PropertyWiringOptions.None);
            builder.RegisterType<MenuService>().SingleInstance().PropertiesAutowired(PropertyWiringOptions.None);
        }
    }
}
