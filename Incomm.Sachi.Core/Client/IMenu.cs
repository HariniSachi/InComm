using Incomm.Sachi.Core.Client.Message;

namespace Incomm.Sachi.Core.Client
{
    public interface IMenu
    {
        MenuListResponse MenuList(MenuListRequest request);
        MenuUpdateResponse MenuUpdate(MenuUpdateRequest request);
        MenuAddResponse MenuAdd(MenuAddRequest request);
    }
}
