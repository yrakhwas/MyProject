namespace MyProject.Data.Entities
{
    public class Salad
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public ICollection<Ingridient> ingridients { get; set; }
        public ICollection<Establishment>? establishments { get; set; }
    }
}
