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
                    Name = "Neapolitana",
                    ingridients = new List<Ingridient>
                    {
                        new Ingridient
                        {
                            Name = "Tomato Sauce",
                            Price = 1
                        },
                        new Ingridient
                        {
                            Name = "Sausage",
                            Price = 2
                        },
                        new Ingridient
                        {
                            Name = "Proshutto",
                            Price = 3
                        }
                    },
                    Price = CalculateDishPrice(new List<Ingridient>
                    {
                        new Ingridient{Name = "Tomato Sauce",Price = 1},
                        new Ingridient{Name = "Sausage",Price = 2},
                        new Ingridient{Name = "Proshutto",Price = 3}
                    })
                },
                new Pizza
                {
                    Name = "Neapolitana-2",
                    ingridients = new List<Ingridient>
                    {
                        new Ingridient
                        {
                            Name = "Tomato Sauce",
                            Price = 2
                        },
                        new Ingridient
                        {
                            Name = "Pork",
                            Price = 3
                        },
                        new Ingridient
                        {
                            Name = "Mushrooms",
                            Price = 2
                        }
                    },
                    Price = CalculateDishPrice(new List<Ingridient>
                    {
                        new Ingridient{Name = "Tomato Sauce",Price = 2},
                        new Ingridient{Name = "Pork",Price = 3},
                        new Ingridient{Name = "Mushrooms",Price = 2}
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
                    Name = "Cesair",
                    ingridients = new List<Ingridient>
                    {
                        new Ingridient
                        {
                            Name = "Chicken",
                            Price = 2
                        },
                        new Ingridient
                        {
                            Name = "Feta",
                            Price = 5
                        },
                        new Ingridient
                        {
                            Name = "Olives",
                            Price = 5
                        }
                    },
                    Price = CalculateDishPrice(new List<Ingridient>
                    {
                        new Ingridient{Name = "Chicken",Price = 2},
                        new Ingridient{Name = "Feta",Price = 5},
                        new Ingridient{Name = "Olives",Price = 5}
                    })
                },
                new Salad
                {
                    Name = "King",
                    ingridients = new List<Ingridient>
                    {
                        new Ingridient
                        {
                            Name = "Brokkoli",
                            Price = 3
                        },
                        new Ingridient
                        {
                            Name = "Colour cabbage",
                            Price = 2
                        },
                        new Ingridient
                        {
                            Name = "Carrot",
                            Price = 1
                        }
                    },
                    Price = CalculateDishPrice(new List<Ingridient>
                    {
                        new Ingridient{Name = "Brokkoli",Price = 3},
                        new Ingridient{Name = "Colour cabbage",Price = 2},
                        new Ingridient{Name = "Carrot",Price = 1}
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
                    Name = "Dragon",
                    ingridients = new List<Ingridient>
                    {
                        new Ingridient
                        {
                            Name = "Salmon",
                            Price = 7
                        },
                        new Ingridient
                        {
                            Name = "Rise",
                            Price = 1
                        },
                        new Ingridient
                        {
                            Name = "Tune",
                            Price = 5
                        },
                        new Ingridient
                        {
                            Name = "Sesame",
                            Price= 6
                        }
                    },
                    Price = CalculateDishPrice(new List<Ingridient>
                    {
                        new Ingridient{Name = "Salmon",Price = 7},
                        new Ingridient{Name = "Rise",Price = 1 },
                        new Ingridient{Name = "Tune",Price = 5},
                        new Ingridient{Name = "Sesame",Price = 6}
                    })
                },
                new Sushi
                {
                    Name = "Gold Dragon",
                    ingridients = new List<Ingridient>
                    {
                        new Ingridient
                        {
                            Name = "Salmon",
                            Price = 7
                        },
                        new Ingridient
                        {
                            Name = "Rise",
                            Price = 1
                        },
                        new Ingridient
                        {
                            Name = "Tune",
                            Price = 5
                        },
                        new Ingridient
                        {
                            Name = "Sesame",
                            Price= 6
                        },
                        new Ingridient
                        {
                            Name = "Cucumber",
                            Price= 4
                        }
                    },
                    Price = CalculateDishPrice(new List<Ingridient>
                    {
                        new Ingridient{Name = "Salmon",Price = 7},
                        new Ingridient{Name = "Rise",Price = 1 },
                        new Ingridient{Name = "Tune",Price = 5},
                        new Ingridient{Name = "Sesame",Price = 6},
                        new Ingridient{Name = "Cucumber",Price = 4}
                    })

                }
            });
        }
        public static decimal CalculateDishPrice(List<Ingridient> ingridients)
        {
            return ingridients.Sum(ingridient => ingridient.Price);
        }
    }
}
