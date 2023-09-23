using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace MyProject.Data.Entities
{
    public class Ingridient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public ICollection<Pizza>? pizzas { get; set; }
        public ICollection<Salad>? salads { get; set; }
        public ICollection<Sushi>? sushis { get; set; }
    }
}
