namespace Ehome_BackEnd.ViewModels.Furniture
{
    public class BasketVM
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public int Count { get; set; }
        public string Image { get; set; }
        public string Category { get; set; }
    }
}
