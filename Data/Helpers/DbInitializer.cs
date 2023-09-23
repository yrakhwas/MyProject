using Microsoft.EntityFrameworkCore;
using MyProject.Data.Entities;

namespace MyProject.Data.Helpers
{
    public static class DbInitializer
    {
        public static void SeedUsers(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Establishment>().HasData(new Establishment[]
            {
                new Establishment
                {
                    Name = "Number_1",
                    Adress = "Soborna_1 st"
                },
                new Establishment
                {
                    Name = "Number_2",
                    Adress = "Soborna_2 st"
                },
                new Establishment
                {
                    Name = "Number_3",
                    Adress = "Soborna_3 st"
                }
            });
        }

        public static void SeedIngridients(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ingridient>().HasData(new Ingridient[]
            {
                new Ingridient
                {
                    Name = "Ingrid_1",
                    Price = 1
                },
                new Ingridient
                {
                    Name = "Ingrid_2",
                    Price = 2
                },
                new Ingridient
                {
                    Name = "Ingrid_3",
                    Price = 3
                },
                new Ingridient
                {
                    Name = "Ingrid_4",
                    Price = 4
                },
                new Ingridient
                {
                    Name = "Ingrid_5",
                    Price = 5
                },
                new Ingridient
                {
                    Name = "Ingrid_6",
                    Price = 6
                }
            });
        }
        public static void SeedPizza(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pizza>().HasData(new Pizza[]
            {
                new Pizza
                {
                    Name = "Pizza_1",
                    Price = 1
                },
                new Pizza
                {
                    Name = "Pizza_2",
                    Price = 2
                },
                new Pizza
                {
                    Name = "Pizza_3",
                    Price = 3
                },
                new Pizza
                {
                    Name = "Pizza_4",
                    Price = 4
                },
                new Pizza
                {
                    Name = "Pizza_5",
                    Price = 5
                },
                new Pizza
                {
                    Name = "Pizza_6",
                    Price = 6
                }
            });
        }
        public static void SeedSalad(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Salad>().HasData(new Salad[]
            {
                new Salad
                {
                    Name = "Salad_1",
                    Price = 1
                },
                new Salad
                {
                    Name = "Salad_2",
                    Price = 2
                },
                new Salad
                {
                    Name = "Salad_3",
                    Price = 3
                },
                new Salad
                {
                    Name = "Salad_4",
                    Price = 4
                },
                new Salad
                {
                    Name = "Salad_5",
                    Price = 5
                },
                new Salad
                {
                    Name = "Salad_6",
                    Price = 6
                }
            });
        }
        public static void SeedSushi(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sushi>().HasData(new Sushi[]
            {
                new Sushi
                {
                    Name = "Sushi_1",
                    Price = 1
                },
                new Sushi
                {
                    Name = "Sushi_2",
                    Price = 2
                },
                new Sushi
                {
                    Name = "Sushi_3",
                    Price = 3
                },
                new Sushi
                {
                    Name = "Sushi_4",
                    Price = 4
                },
                new Sushi
                {
                    Name = "Sushi_5",
                    Price = 5
                },
                new Sushi
                {
                    Name = "Sushi_6",
                    Price = 6
                }
            });
        }
    }
}
