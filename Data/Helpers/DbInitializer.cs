using Microsoft.EntityFrameworkCore;
using MyProject.Data.Entities;
using static MyProject.Data.FoodShopDbContext;

namespace MyProject.Data.Helpers
{
    public static class DbInitializer
    {
        public static void SeedEstablishment(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Establishment>().HasData(new Establishment[]
            {
                new Establishment
                {
                    Id = 1,
                    Name = "Number_1",
                    Adress = "Soborna_1 st"
                },
                new Establishment
                {
                    Id = 2,
                    Name = "Number_2",
                    Adress = "Soborna_2 st"
                },
                new Establishment
                {
                    Id = 3,
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
                    Id = 22,
                    Name = "Ingrid_1",
                    Price = 1
                },
                new Ingridient
                {
                    Id = 23,
                    Name = "Ingrid_2",
                    Price = 2
                },
                new Ingridient
                {
                    Id = 24,
                    Name = "Ingrid_3",
                    Price = 3
                },
                new Ingridient
                {
                    Id = 25,
                    Name = "Ingrid_4",
                    Price = 4
                },
                new Ingridient
                {
                    Id = 26,
                    Name = "Ingrid_5",
                    Price = 5
                },
                new Ingridient
                {
                    Id = 27,
                    Name = "Ingrid_6",
                    Price = 6
                }
            });
        }
        //public static void SeedPizza(this ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Pizza>().HasData(new Pizza[]
        //    {
        //        new Pizza
        //        {
        //            Id = 1,
        //            Name = "Neapolitana",
        //            ingridients = new List<Ingridient>
        //            {
        //                new Ingridient
        //                {
        //                    Id = 1,
        //                    Name = "Tomato Sauce",
        //                    Price = 1
        //                },
        //                new Ingridient
        //                {
        //                    Id = 1,
        //                    Name = "Sausage",
        //                    Price = 2
        //                },
        //                new Ingridient
        //                {
        //                    Id =3,
        //                    Name = "Proshutto",
        //                    Price = 3
        //                }
        //            },
        //            Price = CalculateDishPrice(new List<Ingridient>
        //            {
        //                new Ingridient{Id=1,Name = "Tomato Sauce",Price = 1},
        //                new Ingridient{Id=2,Name = "Sausage",Price = 2},
        //                new Ingridient{Id=3,Name = "Proshutto",Price = 3}
        //            })
        //        },
        //        new Pizza
        //        {
        //            Id = 2,
        //            Name = "Neapolitana-2",
        //            ingridients = new List<Ingridient>
        //            {
        //                new Ingridient
        //                {
        //                    Id=4,
        //                    Name = "Tomato Sauce",
        //                    Price = 2
        //                },
        //                new Ingridient
        //                {
        //                    Id=5,
        //                    Name = "Pork",
        //                    Price = 3
        //                },
        //                new Ingridient
        //                {

        //                    Id=6,
        //                    Name = "Mushrooms",
        //                    Price = 2
        //                }
        //            },
        //            Price = CalculateDishPrice(new List<Ingridient>
        //            {
        //                new Ingridient{Id = 4, Name = "Tomato Sauce",Price = 2},
        //                new Ingridient{Id=5,Name = "Pork",Price = 3},
        //                new Ingridient{Id=6,Name = "Mushrooms",Price = 2}
        //            })
        //        }
        //    });
        //}
        public static void SeedPizza(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pizza>().HasData(new Pizza[]
            {
        new Pizza
        {
            Id = 1,
            Name = "Neapolitana",
            Price = CalculateDishPrice(new List<Ingridient>
            {
                new Ingridient { Id = 1, Name = "Tomato Sauce", Price = 1 },
                new Ingridient { Id = 2, Name = "Sausage", Price = 2 },
                new Ingridient { Id = 3, Name = "Proshutto", Price = 3 }
            })
        },
        new Pizza
        {
            Id = 2,
            Name = "Neapolitana-2",
            Price = CalculateDishPrice(new List<Ingridient>
            {
                new Ingridient { Id = 4, Name = "Tomato Sauce", Price = 2 },
                new Ingridient { Id = 5, Name = "Pork", Price = 3 },
                new Ingridient { Id = 6, Name = "Mushrooms", Price = 2 }
            })
        }
            });
    }


        public static void SeedSalad(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Salad>().HasData(new Salad[]
            {
                new Salad
                {
                    Id=1001,
                    Name = "Cesair",
                    Price = CalculateDishPrice(new List<Ingridient>
                    {
                        new Ingridient{Id=7,Name = "Chicken",Price = 2},
                        new Ingridient{Id=8,Name = "Feta",Price = 5},
                        new Ingridient{Id=9,Name = "Olives",Price = 5}
                    })
                },
                new Salad
                {
                    Id=1002,
                    Name = "King",
                    Price = CalculateDishPrice(new List<Ingridient>
                    {
                        new Ingridient{Id=10,Name = "Brokkoli",Price = 3},
                        new Ingridient{Id=11,Name = "Colour cabbage",Price = 2},
                        new Ingridient{Id=12,Name = "Carrot",Price = 1}
                    })
                }
            });
        }
        public static void SeedSushi(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sushi>().HasData(new Sushi[]
            {
                new Sushi
                {
                    Id = 2001,
                    Name = "Dragon",
                    Price = CalculateDishPrice(new List<Ingridient>
                    {
                        new Ingridient{Id=13,Name = "Salmon",Price = 7},
                        new Ingridient{Id=14,Name = "Rise",Price = 1 },
                        new Ingridient{Id=15,Name = "Tune",Price = 5},
                        new Ingridient{Id=16,Name = "Sesame",Price = 6}
                    })
                },
                new Sushi
                {
                    Id = 2002,
                    Name = "Gold Dragon",
                    Price = CalculateDishPrice(new List<Ingridient>
                    {
                        new Ingridient{Id=17,Name = "Salmon",Price = 7},
                        new Ingridient{Id=18,Name = "Rise",Price = 1 },
                        new Ingridient{Id=19,Name = "Tune",Price = 5},
                        new Ingridient{Id=20,Name = "Sesame",Price = 6},
                        new Ingridient{Id=21,Name = "Cucumber",Price = 4}
                    })

                }
            });
        }
        public static void SeedPizzaIngridients(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PizzaIngridient>().HasData(new PizzaIngridient[]
            {
                new PizzaIngridient
                {
                    PizzaId = 1,
                    IngridientId = 1
                },
                new PizzaIngridient
                {
                    PizzaId = 1,
                    IngridientId = 2
                },
                new PizzaIngridient
                {
                    PizzaId = 1,
                    IngridientId = 3
                },
                new PizzaIngridient
                {
                    PizzaId = 2,
                    IngridientId = 4
                },
                new PizzaIngridient
                {
                    PizzaId = 2,
                    IngridientId = 5
                },
                new PizzaIngridient
                {
                    PizzaId = 2,
                    IngridientId = 6
                }
            });
        }


        public static void SeedSushiIngridients(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SushiIngridient>().HasData(new SushiIngridient[]
            {
                new SushiIngridient
                {
                    SushiId = 2001,
                    IngridientId = 13
                },
                new SushiIngridient
                {
                    SushiId = 2001,
                    IngridientId = 14
                },
                new SushiIngridient
                {
                    SushiId = 2001,
                    IngridientId = 15
                },
                new SushiIngridient
                {
                    SushiId = 2001,
                    IngridientId = 16
                },
                new SushiIngridient
                {
                    SushiId = 2002,
                    IngridientId = 17
                },
                new SushiIngridient
                {
                    SushiId = 2002,
                    IngridientId = 18
                },
                new SushiIngridient
                {
                    SushiId = 2002,
                    IngridientId = 19
                },
                new SushiIngridient
                {
                    SushiId = 2002,
                    IngridientId = 20
                },
                new SushiIngridient
                {
                    SushiId = 2002,
                    IngridientId = 21
                }
            });
        }
        public static void SeedSaladIngridients(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SaladIngridient>().HasData(new SaladIngridient[]
            {
                new SaladIngridient
                {
                    SaladId = 1001,
                    IngridientId = 7
                },
                new SaladIngridient
                {
                    SaladId = 1001,
                    IngridientId = 8
                },
                new SaladIngridient
                {
                    SaladId = 1001,
                    IngridientId = 9
                },
                new SaladIngridient
                {
                    SaladId = 1002,
                    IngridientId = 10
                },
                new SaladIngridient
                {
                    SaladId = 1002,
                    IngridientId = 11
                },
                new SaladIngridient
                {
                    SaladId = 1002,
                    IngridientId = 12
                }
            });
        }
        public static decimal CalculateDishPrice(List<Ingridient> ingridients)
        {
            return ingridients.Sum(ingridient => ingridient.Price);
        }
    }
}
