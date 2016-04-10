using System.Collections.Generic;

namespace Incomm.Sachi.Core.Client.Data
{
    public class OrderItemDto
    {
        public int OrderItemId { get; set; }
        public int MenuId { get; set; }
        public int Quantity { get; set; }
        public IList<ExtraDto> Extras { get; set; }
    }
}
