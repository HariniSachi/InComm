using System.Collections.Generic;
using Incomm.Sachi.Core.Domain.Model;
using NLog;

namespace Incomm.Sachi.Core.Domain.DataAccess
{
    public class ExtraDao : IBaseDao<Extra>
    {
        private readonly ILogger _logger;

        public ExtraDao(ILogger logger)
        {
            _logger = logger;
        }
        public IList<Extra> FindAll()
        {
            _logger.Trace("Invoking extra data access object find all method.");

            //TODO: Implement call to data access layer
            //For now hard code the return values
            return new List<Extra>()
            {
                new Extra() {ExtraId = 1, Description = "Additional Flavor", Price = 0.50m},
                new Extra() {ExtraId = 1, Description = "Additional Flavor", Price = 0.50m}
            };
        }
    }
}
