using System;
using Incomm.Sachi.Core.Client;
using Incomm.Sachi.Core.Client.Message;

namespace Incomm.Sachi.Core
{
    public class OrderService : IOrder
    {
        public OrderListResponse OrderList(OrderListRequest request)
        {
            var response = new OrderListResponse();

            try
            {
                response.IsSuccess = true;
            }
            catch (Exception ex)
            {
                //TODO: Log exception
            }

            return response;
        }

        public OrderUpdateResponse OrderUpdate(OrderUpdateRequest request)
        {
            var response = new OrderUpdateResponse();

            try
            {
                response.IsSuccess = true;
            }
            catch (Exception ex)
            {
                //TODO: Log exception
            }

            return response;
        }

        public OrderAddResponse OrderAdd(OrderAddRequest request)
        {
            var response = new OrderAddResponse();

            try
            {
                response.IsSuccess = true;
            }
            catch (Exception ex)
            {
                //TODO: Log exception
            }

            return response;
        }

    }
}
