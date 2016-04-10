using Incomm.Sachi.Core.Client.Data;

namespace Incomm.Sachi.Core.Client.Message
{
    public class MenuUpdateRequest : BaseRequest
    {
        public MenuDto Menu { get; set; }
    }
}
