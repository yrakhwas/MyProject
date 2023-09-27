namespace MyProject.Data.Entities
{
    public class SushiIngridient
    {
        public int SushiId { get; set; }
        public Sushi Sushi { get; set; }

        public int IngridientId { get; set; }
        public Ingridient Ingridient { get; set; }
    }
}
