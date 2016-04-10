using System.Web.Http;
using Incomm.Sachi.Core;
using Incomm.Sachi.Core.Client.Message;

namespace Incomm.Sachi.WebApi.Controllers
{
    public class DrinkSizesController : ApiController
    {
        [Authorize(Roles = "Baristas")]
        public IHttpActionResult Get()
        {
            var service = new DrinkSizeService();
            var response = service.DrinkSizeList(new DrinkSizeListRequest());
            return (response.IsSuccess) ? (IHttpActionResult)Ok(response.DrinkSizes) : InternalServerError();
        }
    }
}