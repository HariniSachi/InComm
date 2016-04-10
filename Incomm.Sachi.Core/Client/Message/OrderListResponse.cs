using System.Collections.Generic;
using Incomm.Sachi.Core.Client.Data;

namespace Incomm.Sachi.Core.Client.Message
{
    public class OrderListResponse : BaseResponse
    {
        public IList<OrderDto> Orders { get; set; }
    }
}
