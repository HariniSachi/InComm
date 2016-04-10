using System.Collections.Generic;
using Incomm.Sachi.Core.Domain.Model;
using NLog;

namespace Incomm.Sachi.Core.Domain.DataAccess
{
    public class OrderStatusDao : IBaseDao<OrderStatus>
    {
        private readonly ILogger _logger;

        public OrderStatusDao(ILogger logger)
        {
            _logger = logger;
        }
        public IList<OrderStatus> FindAll()
        {
            _logger.Trace("Invoking order status data access object find all method.");

            //TODO: Implement call to data access layer
            //For now hard code the return values
            return new List<OrderStatus>()
            {
                new OrderStatus() {OrderStatusId = 1, Description = "Order Placed"},
                new OrderStatus() {OrderStatusId = 2, Description = "Prep"},
                new OrderStatus() {OrderStatusId = 3, Description = "Ready"}
            };
        }
    }
}
