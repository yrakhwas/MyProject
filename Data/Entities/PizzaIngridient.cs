namespace MyProject.Data.Entities
{
    public class PizzaIngridient
    {
        public int PizzaId { get; set; }
        public Pizza Pizza { get; set; }

        public int IngridientId { get; set; }
        public Ingridient Ingridient { get; set; }
    }
}
