using Microsoft.EntityFrameworkCore;

namespace MyProject.Data.Entities
{
    public class Establishment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public ICollection<Pizza>? pizzas { get; set; }
        public ICollection<Salad>? salads { get; set; }
        public ICollection<Sushi>? sushis { get; set; }
    }
}
