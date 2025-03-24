namespace chuska.Data.Models
{
    public class ProductOrder
    {
        public int Id { get; set; }
        public string ProductId { get; set; }
        public string OrderId { get; set; }
        public Product Product { get; set; }
        public Order Order { get; set; }
    }
}
