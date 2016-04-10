using Incomm.Sachi.Core.Client.Message;

namespace Incomm.Sachi.Core.Client
{
    public interface IOrder
    {
        OrderListResponse OrderList(OrderListRequest request);
        OrderUpdateResponse OrderUpdate(OrderUpdateRequest request);
        OrderAddResponse OrderAdd(OrderAddRequest request);
    }
}
