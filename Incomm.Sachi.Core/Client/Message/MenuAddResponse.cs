using Incomm.Sachi.Core.Client.Data;

namespace Incomm.Sachi.Core.Client.Message
{
    public class MenuAddResponse : BaseResponse
    {
        public MenuDto Menu { get; set; }
    }
}
