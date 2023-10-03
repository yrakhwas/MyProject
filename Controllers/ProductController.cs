using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyProject.Data;

namespace MyProject.Controllers
{
    public class ProductController : Controller
    {
        private readonly FoodShopDbContext ctx;
        public ProductController()
        {
            ctx = new FoodShopDbContext();
        }
        public ProductController(FoodShopDbContext ctx)
        {
            this.ctx = ctx;
        }
        private void LoadIngridients()
        {
            this.ViewBag.Pizzas = new SelectList(ctx.pizza.ToList(), "Id", "Name");
            this.ViewBag.Sushis = new SelectList(ctx.sushi.ToList(), "Id", "Name");
            this.ViewBag.Salads = new SelectList(ctx.salads.ToList(), "Id", "Name");
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
