using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Incomm.Sachi.Core.Client.Data;
using Incomm.Sachi.Core.Domain.Model;

namespace Incomm.Sachi.Core.Domain.Converter
{
    public class MenuOutConverter : ITypeConverter<IList<Menu>, IList<MenuDto>>
    {
        public IList<MenuDto> Convert(ResolutionContext context)
        {
            IList<MenuDto> destination = null;
            var source = (IList<Menu>)context.SourceValue;

            if (source != null)
            {
                destination = source.Select(c => new MenuDto()
                {
                    MenuId = c.MenuId,
                    Price = c.Price,
                    Link = new LinkDto() {Rel = "self", Href = string.Format("api/menus/{0}", c.MenuId), Method = "PUT"}
                }).ToList();
            }

            return destination;
        }
    }

    public class MenuCategoryConverter : ITypeConverter<IList<Category>, IList<MenuDto>>
    {
        public IList<MenuDto> Convert(ResolutionContext context)
        {
            IList<MenuDto> destination = null;
            var source = (IList<Category>)context.SourceValue;

            if (source != null)
            {
                destination = source.Select(c => new MenuDto()
                {
                   Category = c.Description
                }).ToList();
            }

            return destination;
        }
    }

    public class MenuDrinkSizeConverter : ITypeConverter<IList<DrinkSize>, IList<MenuDto>>
    {
        public IList<MenuDto> Convert(ResolutionContext context)
        {
            IList<MenuDto> destination = null;
            var source = (IList<DrinkSize>)context.SourceValue;

            if (source != null)
            {
                destination = source.Select(c => new MenuDto()
                {
                    DrinkSize = c.Description
                }).ToList();
            }

            return destination;
        }
    }

    public class MenuDrinkTypeConverter : ITypeConverter<IList<DrinkType>, IList<MenuDto>>
    {
        public IList<MenuDto> Convert(ResolutionContext context)
        {
            IList<MenuDto> destination = null;
            var source = (IList<DrinkType>)context.SourceValue;

            if (source != null)
            {
                destination = source.Select(c => new MenuDto()
                {
                    DrinkType = c.Description
                }).ToList();
            }

            return destination;
        }
    }
}
