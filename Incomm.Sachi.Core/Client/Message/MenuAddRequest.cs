using Incomm.Sachi.Core.Client.Data;

namespace Incomm.Sachi.Core.Client.Message
{
    public class MenuAddRequest : BaseRequest
    {
        public MenuDto Menu { get; set; }
    }
}
