using System.Collections.Generic;
using Incomm.Sachi.Core.Client.Data;

namespace Incomm.Sachi.Core.Client.Message
{
    public class MenuListResponse : BaseResponse
    {
        public IList<MenuDto> Menus { get; set; }
    }
}
