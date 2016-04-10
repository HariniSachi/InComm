using System.Web.Http;
using Incomm.Sachi.Core;
using Incomm.Sachi.Core.Client.Data;
using Incomm.Sachi.Core.Client.Message;

namespace Incomm.Sachi.WebApi.Controllers
{
    public class MenusController : ApiController
    {
        public IHttpActionResult Get()
        {
            var service = new MenuService();
            var response = service.MenuList(new MenuListRequest());
            return (response.IsSuccess) ? (IHttpActionResult)Ok(response.Menus) : InternalServerError();
        }

        [Authorize(Roles = "Baristas")]
        public IHttpActionResult Post(MenuDto menu)
        {
            var service = new MenuService();
            var response = service.MenuAdd(new MenuAddRequest() {Menu = menu});
            return (response.IsSuccess) ? (IHttpActionResult)Ok(response.Menu) : InternalServerError();
        }

        [Authorize(Roles = "Baristas")]
        public IHttpActionResult Put(int id, MenuDto menu)
        {
            menu.MenuId = id;
            var service = new MenuService();
            var response = service.MenuUpdate(new MenuUpdateRequest() { Menu = menu });
            return (response.IsSuccess) ? (IHttpActionResult)Ok() : InternalServerError();
        }
    }
}
