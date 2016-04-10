using Incomm.Sachi.Core.Client.Data;

namespace Incomm.Sachi.Core.Client.Message
{
    public class OrderAddRequest : BaseRequest
    {
        public OrderDto Order { get; set; }
    }
}
