using System;
using System.Collections.Generic;
using Incomm.Sachi.Core.Domain.Model;
using NLog;

namespace Incomm.Sachi.Core.Domain.DataAccess
{
    public class OrderDao : IDao<Order>
    {
        private readonly ILogger _logger;

        public OrderDao(ILogger logger)
        {
            _logger = logger;
        }

        public IList<Order> FindAll()
        {
            _logger.Trace("Invoking order data access object find all method.");

            //TODO: Implement call to data access layer
            //For now hard code the return values
            return new List<Order>()
            {
               new Order() {OrderId = 1, OrderStatusId = 1, OrderDateTime = DateTime.Now},
               new Order() {OrderId = 1, OrderStatusId = 2, OrderDateTime = DateTime.Now.AddMinutes(-3)}
            };
        }

        public int Add(Order item)
        {
            _logger.Trace("Invoking order data access object add method.");

            //TODO: Implement call to data access layer
            //For now hard code the return value.
            return 5;
        }

        public void Update(Order item)
        {
            _logger.Trace("Invoking order data access object update method.");
            //TODO: Implement call to data access layer
        }


        public Order FindBy(int id)
        {
            throw new NotImplementedException();
        }
    }
}
