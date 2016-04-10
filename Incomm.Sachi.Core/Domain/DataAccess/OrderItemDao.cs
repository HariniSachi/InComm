using System;
using System.Collections.Generic;
using Incomm.Sachi.Core.Domain.Model;
using NLog;

namespace Incomm.Sachi.Core.Domain.DataAccess
{
    public class OrderItemDao : IDao<OrderItem>
    {
        private readonly ILogger _logger;

        public OrderItemDao(ILogger logger)
        {
            _logger = logger;
        }

        public IList<OrderItem> FindAll()
        {
            _logger.Trace("Invoking order item data access object find all method.");

            //TODO: Implement call to data access layer
            //For now hard code the return values
            return new List<OrderItem>()
            {
               new OrderItem() {OrderItemId = 1, MenuId = 1, Quantity = 1},
               new OrderItem() {OrderItemId = 1, MenuId = 2, Quantity = 1},
            };
        }

        public int Add(OrderItem item)
        {
            _logger.Trace("Invoking order item data access object add method.");

            //TODO: Implement call to data access layer
            //For now hard code the return value.
            return 5;
        }

        public void Update(OrderItem item)
        {
            _logger.Trace("Invoking order item data access object update method.");
            //TODO: Implement call to data access layer
        }


        public OrderItem FindBy(int id)
        {
            throw new NotImplementedException();
        }
    }
}
