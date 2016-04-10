namespace Incomm.Sachi.Core.Domain.Model
{
    public class Menu
    {
        public int MenuId { get; set; }
        public int DrinkTypeId { get; set; }
        public int DrinkSizeId { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
    }
}
