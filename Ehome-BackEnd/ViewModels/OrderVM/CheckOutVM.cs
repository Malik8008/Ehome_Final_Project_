namespace Ehome_BackEnd.ViewModels
{
    public class CheckOutVM
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal SalePrice { get; set; }
        public decimal Discount { get; set; }
        public decimal CostPrice { get; set; }
        public int Count { get; set; }
        public string Image { get; set; }
        public string Category { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Adress { get; set; }
        public string Phone { get; set; }
    }
}
