namespace chuska.Data.Models
{
    public class Product
    {
        public Product()
        {
            Id = Guid.NewGuid().ToString();
            Orders = new HashSet<ProductOrder>();
        }
        public string Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public ProductType PType { get; set; }
        public virtual ICollection<ProductOrder> Orders { get; set; }
    }
    public enum ProductType { Food, Domestic, Health, Cosmetic }
}
