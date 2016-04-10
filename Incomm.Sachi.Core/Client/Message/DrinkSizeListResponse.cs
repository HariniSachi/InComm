using System.Collections.Generic;
using Incomm.Sachi.Core.Client.Data;

namespace Incomm.Sachi.Core.Client.Message
{
    public class DrinkSizeListResponse : BaseResponse
    {
        public IList<DrinkSizeDto> DrinkSizes { get; set; }
    }
}
