using chuska.Data.Models;

namespace chuska.Models
{
    public class ProductViewModel
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public ProductType PType { get; set; }
    }
}
