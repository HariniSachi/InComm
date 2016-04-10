using System.Collections.Generic;
using Incomm.Sachi.Core.Domain.Model;
using NLog;

namespace Incomm.Sachi.Core.Domain.DataAccess
{
    public class MenuDao : IDao<Menu>
    {
        private readonly ILogger _logger;

        public MenuDao(ILogger logger)
        {
            _logger = logger;
        }

        public IList<Menu> FindAll()
        {
            _logger.Trace("Invoking menu data access object find all method.");

            //TODO: Implement call to data access layer
            //For now hard code the return values
            return new List<Menu>()
            {
                new Menu() {MenuId = 1, CategoryId = 1, DrinkTypeId = 1, DrinkSizeId = 1, Price = 2.00m},
               new Menu() {MenuId = 1, CategoryId = 1, DrinkTypeId = 1, DrinkSizeId = 2, Price = 3.00m}
            };
        }

        public int Add(Menu item)
        {
            _logger.Trace("Invoking menu data access object add method.");

            //TODO: Implement call to data access layer
            //For now hard code the return value.
            return 5;
        }

        public void Update(Menu item)
        {
            _logger.Trace("Invoking menu data access object update method.");
            //TODO: Implement call to data access layer
        }

        public Menu FindBy(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
