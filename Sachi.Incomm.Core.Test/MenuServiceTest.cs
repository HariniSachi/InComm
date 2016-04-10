using Incomm.Sachi.Core;
using Incomm.Sachi.Core.Client.Message;
using NUnit.Framework;

namespace Sachi.Incomm.Core.Test
{
    public class MenuServiceTest
    {
        [Test]
        public void ShouldListMenu()
        {
            var service = new MenuService();
            var response = service.MenuList(new MenuListRequest());
            Assert.Equals(true, response.IsSuccess);
        }
    }
}
