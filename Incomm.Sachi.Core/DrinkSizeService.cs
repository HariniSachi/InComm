using System;
using Incomm.Sachi.Core.Client;
using Incomm.Sachi.Core.Client.Message;

namespace Incomm.Sachi.Core
{
    public class DrinkSizeService : IDrinkSize
    {
        public DrinkSizeListResponse DrinkSizeList(DrinkSizeListRequest request)
        {
            var response = new DrinkSizeListResponse();

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
