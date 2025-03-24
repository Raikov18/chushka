using Microsoft.AspNetCore.Identity;

namespace chuska.Data.Models
{
    public class User : IdentityUser
    {
        public User()
        {
            Orders = new HashSet<Order>();
        }
        public string FullName { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
