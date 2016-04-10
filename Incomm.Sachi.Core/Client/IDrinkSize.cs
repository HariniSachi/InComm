using Incomm.Sachi.Core.Client.Message;

namespace Incomm.Sachi.Core.Client
{
    public interface IDrinkSize
    {
        DrinkSizeListResponse DrinkSizeList(DrinkSizeListRequest request);
    }
}
