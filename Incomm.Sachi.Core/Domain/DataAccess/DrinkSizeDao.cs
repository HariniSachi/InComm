using System.Collections.Generic;
using Incomm.Sachi.Core.Domain.Model;
using NLog;

namespace Incomm.Sachi.Core.Domain.DataAccess
{
    public class DrinkSizeDao : IBaseDao<DrinkSize>
    {
        private readonly ILogger _logger;

        public DrinkSizeDao(ILogger logger)
        {
            _logger = logger;
        }
        public IList<DrinkSize> FindAll()
        {
            _logger.Trace("Invoking drink size data access object find all method.");

            //TODO: Implement call to data access layer
            //For now hard code the return values
            return new List<DrinkSize>()
            {
                new DrinkSize() {DrinkSizeId = 1, Description = "Small"},
                new DrinkSize() {DrinkSizeId = 2, Description = "Medium"},
                new DrinkSize() {DrinkSizeId = 3, Description = "Large"},
            };
        }
    }
}
