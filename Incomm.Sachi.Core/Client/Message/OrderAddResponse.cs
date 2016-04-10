using Incomm.Sachi.Core.Client.Data;

namespace Incomm.Sachi.Core.Client.Message
{
    public class OrderAddResponse : BaseResponse
    {
        public OrderDto Order { get; set; }
    }
}
