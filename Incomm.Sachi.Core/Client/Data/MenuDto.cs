using System.Collections.Generic;

namespace Incomm.Sachi.Core.Client.Data
{
    public class MenuDto
    {
        public int MenuId { get; set; }
        public string DrinkType { get; set; }
        public string DrinkSize { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        public LinkDto Link { get; set; }
    }
}
