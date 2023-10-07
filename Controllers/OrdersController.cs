using Microsoft.AspNetCore.Mvc;
using MyProject.Data;

namespace MyProject.Controllers
{
    public class OrdersController : Controller
    {
        private readonly FoodShopDbContext ctx;
        public OrdersController(FoodShopDbContext ctx)
        {
            this.ctx = ctx;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create() 
        {
            //List<int>? ids = HttpContent.Session.Get<List<int>>("cart_items");

            //List<>

            return View();
        }
    }
}
