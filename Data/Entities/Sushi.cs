﻿namespace MyProject.Data.Entities
{
    public class Sushi
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public ICollection<Ingridient> ingridients { get; set; }
        public ICollection<Establishment>? establishments { get; set; }
        public ICollection<SushiIngridient> SushiIngridients { get; set; }
        public Sushi()
        {
            ingridients = new List<Ingridient>();
            CalculatePrice();
        }
        private void CalculatePrice()
        {
            Price = (decimal)ingridients.Sum(ingredient => ingredient.Price);
        }
        // Додавання інгредієнта до піци
        public void AddIngredient(Ingridient ingredient)
        {
            ingridients.Add(ingredient);
            CalculatePrice();
        }

        // Видалення інгредієнта з піци
        public void RemoveIngredient(Ingridient ingredient)
        {
            ingridients.Remove(ingredient);
            CalculatePrice();
        }
    }
}
