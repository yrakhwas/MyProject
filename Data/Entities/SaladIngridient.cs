namespace MyProject.Data.Entities
{
    public class SaladIngridient
    {
        public int SaladId { get; set; }
        public Salad Salad { get; set; }

        public int IngridientId { get; set; }
        public Ingridient Ingridient { get; set; }
    }
}
