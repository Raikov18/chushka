namespace chuska.Data.Models
{
    public class Order
    {
        public Order()
        {
            Id = Guid.NewGuid().ToString();
            Products = new HashSet<ProductOrder>();
        }
        public string Id { get; set; }
        public DateTime OrderedOn { get; set; }
        public virtual ICollection<ProductOrder> Products { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}