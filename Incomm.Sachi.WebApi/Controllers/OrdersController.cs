using System;
using System.Linq;
using System.Web.Http;
using Incomm.Sachi.Core;
using Incomm.Sachi.Core.Client.Data;
using Incomm.Sachi.Core.Client.Message;

namespace Incomm.Sachi.WebApi.Controllers
{
    public class OrdersController : ApiController
    {
        [Route("{pageSize:int}/{pageNumber:int}")] 
        [Authorize(Roles = "Baristas")]
        public IHttpActionResult Get(int pageSize, int pageNumber)
        {
            var service = new OrderService();
            var response = service.OrderList(new OrderListRequest());
            if (!response.IsSuccess) return InternalServerError();

            var totalCount = response.Orders.Count();
            var totalPages = Math.Ceiling((double)totalCount / pageSize);
            var orders = response.Orders.OrderByDescending(c => c.OrderDateTime).Skip((pageNumber - 1) * pageSize)
                                    .Take(pageSize)
                                    .ToList();
            var result = new
            {
                TotalCount = totalCount,
                TotalPages = totalPages,
                Orders = orders
            };

            return Ok(result); 

        }

        [Authorize(Roles = "Baristas")]
        public IHttpActionResult Get(int orderId)
        {
            var service = new OrderService();
            var response = service.OrderList(new OrderListRequest());
            if (!response.IsSuccess) return InternalServerError();
            var order = response.Orders.FirstOrDefault((p) => p.OrderId == orderId);
            if (order == null)
                return NotFound();
            else
                return Ok(order);
        }

        [Authorize(Roles = "Customers")]
        public IHttpActionResult Post(OrderDto order)
        {
            var service = new OrderService();
            var response = service.OrderAdd(new OrderAddRequest() {Order = order});
            return (response.IsSuccess) ? (IHttpActionResult)Ok(response.Order) : InternalServerError();
        }

        [Authorize(Roles = "Baristas")]
        public IHttpActionResult Put(int id, OrderDto order)
        {
            order.OrderId = id;
            var service = new OrderService();
            var response = service.OrderUpdate(new OrderUpdateRequest() { Order = order});
            return (response.IsSuccess) ? (IHttpActionResult)Ok() : InternalServerError();
        }

    }
}
