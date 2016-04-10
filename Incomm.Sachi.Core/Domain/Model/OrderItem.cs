using System.Collections.Generic;

namespace Incomm.Sachi.Core.Domain.Model
{
    public class OrderItem
    {
        public int OrderItemId { get; set; }
        public int MenuId { get; set; }
        public int Quantity { get; set; }
        public IList<Extra> Extras { get; set; }
    }
}
