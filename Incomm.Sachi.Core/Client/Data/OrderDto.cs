using System;
using System.Collections.Generic;

namespace Incomm.Sachi.Core.Client.Data
{
    public class OrderDto
    {
        public int OrderId { get; set; }
        public string OrderStatus { get; set; }
        public DateTime OrderDateTime { get; set; }
        public Decimal TotalPrice { get; set; }
        public IList<OrderItemDto> OrderItems { get; set; }
    }
}
