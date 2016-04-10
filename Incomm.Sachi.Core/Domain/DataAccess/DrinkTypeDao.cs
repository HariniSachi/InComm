using System.Collections.Generic;
using Incomm.Sachi.Core.Domain.Model;
using NLog;

namespace Incomm.Sachi.Core.Domain.DataAccess
{
    public class DrinkTypeDao : IBaseDao<DrinkType>
    {
        private readonly ILogger _logger;

        public DrinkTypeDao(ILogger logger)
        {
            _logger = logger;
        }
        public IList<DrinkType> FindAll()
        {
            _logger.Trace("Invoking drink type data access object find all method.");

            //TODO: Implement call to data access layer
            //For now hard code the return values
            return new List<DrinkType>()
            {
                new DrinkType() {DrinkTypeId = 1, Description = "Brewed coffee"},
                new DrinkType() {DrinkTypeId = 2, Description = "Misto"},
                new DrinkType() {DrinkTypeId = 3, Description = "Americano"},
                new DrinkType() {DrinkTypeId = 4, Description = "Late"},
                new DrinkType() {DrinkTypeId = 5, Description = "Black Tea"},
                new DrinkType() {DrinkTypeId = 6, Description = "Green Tea"}
            };
        }
    }
}
