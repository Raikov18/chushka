using chuska.Data;
using chuska.Data.Models;
using chuska.Models;
using Microsoft.AspNetCore.Mvc;

namespace chuska.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext db;
        public ProductController(ApplicationDbContext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Add()
        {
            return this.View();
        }
        [HttpPost]
        public IActionResult Add(ProductViewModel model)
        {
            var product = new Product
            {
                Name = model.Name,
                Price = model.Price,
                Description = model.Description,
                PType = model.PType,
            };
            db.Products.Add(product);
            db.SaveChanges();
            return this.Redirect("Index");
        }
        public IActionResult Details(string id)
        {
            var productModel = db.Products.Where(x => id == x.Id).Select(x => new ProductViewModel
            {
                Name = x.Name,
                Price = x.Price,
                Description = x.Description,
                PType = x.PType,

            }).FirstOrDefault();
            return View(productModel);

        }
    }
}


