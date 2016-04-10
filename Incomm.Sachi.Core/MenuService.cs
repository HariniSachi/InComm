using System;
using System.Collections.Generic;
using Autofac;
using AutoMapper;
using Incomm.Sachi.Core.Client;
using Incomm.Sachi.Core.Client.Data;
using Incomm.Sachi.Core.Client.Message;
using Incomm.Sachi.Core.Domain.DataAccess;
using Incomm.Sachi.Core.Domain.IoC;
using Incomm.Sachi.Core.Domain.Model;
using NLog;

namespace Incomm.Sachi.Core
{
    public class MenuService : IMenu
    {
        #region Variables

        private static readonly IContainer Container;
        private readonly ILogger _logger;
        private readonly IMapper _mapper;
        private readonly IDao<Menu> _menuRepository;
        private readonly IBaseDao<Category> _categoryRepository;
        private readonly IBaseDao<DrinkSize> _drinkSizeRepository;
        private readonly IBaseDao<DrinkType> _drinkTypeRepository;

        #endregion

       #region Ctor

        static MenuService()
        {
            Container = Bootstrapper.BuildContainer();
        }

        public MenuService()
        {
            using (var scope = Container.BeginLifetimeScope())
            {
                _logger = scope.Resolve<ILogger>();
                _mapper = scope.Resolve<IMapper>();
                _menuRepository = scope.Resolve<IDao<Menu>>();
                _categoryRepository = scope.Resolve<IBaseDao<Category>>();
                _drinkSizeRepository = scope.Resolve<IBaseDao<DrinkSize>>();
                _drinkTypeRepository = scope.Resolve<IBaseDao<DrinkType>>();
            }
        }

        #endregion

        public MenuListResponse MenuList(MenuListRequest request)
        {
            var response = new MenuListResponse();

            try
            {
                _logger.Trace("Invoking menu service menu list method.");
                response.IsSuccess = true;
            }
            catch (Exception ex)
            {
                _logger.Error(ex.ToString);
            }

            return response;
        }

        public MenuUpdateResponse MenuUpdate(MenuUpdateRequest request)
        {
            var response = new MenuUpdateResponse();

            try
            {
                response.IsSuccess = true;
            }
            catch (Exception ex)
            {
                //TODO: Log exception
            }

            return response;
        }

        public MenuAddResponse MenuAdd(MenuAddRequest request)
        {
            var response = new MenuAddResponse();

            try
            {
                response.IsSuccess = true;
            }
            catch (Exception ex)
            {
                //TODO: Log exception
            }

            return response;
        }

    }
}
