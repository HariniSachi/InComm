using System;

namespace Incomm.Sachi.Core.Domain.Model
{
    public class Order
    {
        public int OrderId { get; set; }
        public int OrderStatusId { get; set; }
        public DateTime OrderDateTime { get; set; }
        public Decimal TotalPrice { get; set; }
    }
}
