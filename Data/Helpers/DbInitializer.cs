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
                    Id = 1,
                    Name = "Ingrid_1",
                    Price = 1
                },
                new Ingridient
                {
                    Id = 2,
                    Name = "Ingrid_2",
                    Price = 2
                },
                new Ingridient
                {
                    Id = 3,
                    Name = "Ingrid_3",
                    Price = 3
                },
                new Ingridient
                {
                    Id = 4,
                    Name = "Ingrid_4",
                    Price = 4
                },
                new Ingridient
                {
                    Id = 5,
                    Name = "Ingrid_5",
                    Price = 5
                },
                new Ingridient
                {
                    Id = 6,
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
                    Id = 1,
                    Name = "Neapolitana",
                    //ingridients = new List<Ingridient>
                    //{
                    //    new Ingridient
                    //    {   
                    //        Id = 1000,
                    //        Name = "Tomato Sauce",
                    //        Price = 1
                    //    },
                    //    new Ingridient
                    //    {   
                    //        Id = 1001,
                    //        Name = "Sausage",
                    //        Price = 2
                    //    },
                    //    new Ingridient
                    //    {
                    //        Id =1003,
                    //        Name = "Proshutto",
                    //        Price = 3
                    //    }
                    //},
                    Price = CalculateDishPrice(new List<Ingridient>
                    {
                        new Ingridient{Id=1000,Name = "Tomato Sauce",Price = 1},
                        new Ingridient{Id=1001,Name = "Sausage",Price = 2},
                        new Ingridient{Id=1003,Name = "Proshutto",Price = 3}
                    })
                },
                new Pizza
                {
                    Id = 2,
                    Name = "Neapolitana-2",
                    //ingridients = new List<Ingridient>
                    //{
                    //    new Ingridient
                    //    {
                    //        Id=1006,
                    //        Name = "Tomato Sauce",
                    //        Price = 2
                    //    },
                    //    new Ingridient
                    //    {
                    //        Id=1007,
                    //        Name = "Pork",
                    //        Price = 3
                    //    },
                    //    new Ingridient
                    //    {

                    //        Id=1008,
                    //        Name = "Mushrooms",
                    //        Price = 2
                    //    }
                    //},
                    Price = CalculateDishPrice(new List<Ingridient>
                    {
                        new Ingridient{Id = 1006, Name = "Tomato Sauce",Price = 2},
                        new Ingridient{Id=1007,Name = "Pork",Price = 3},
                        new Ingridient{Id=1008,Name = "Mushrooms",Price = 2}
                    })
                }
            });
            modelBuilder.Entity<Pizza>
        }
        public static void SeedSalad(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Salad>().HasData(new Salad[]
            {
                new Salad
                {
                    Id=1,
                    Name = "Cesair",
                    ingridients = new List<Ingridient>
                    {
                        new Ingridient
                        {
                            Id=1012,
                            Name = "Chicken",
                            Price = 2
                        },
                        new Ingridient
                        {

                            Id=1013,
                            Name = "Feta",
                            Price = 5
                        },
                        new Ingridient
                        {

                            Id=1014,
                            Name = "Olives",
                            Price = 5
                        }
                    },
                    Price = CalculateDishPrice(new List<Ingridient>
                    {
                        new Ingridient{Id=1015,Name = "Chicken",Price = 2},
                        new Ingridient{Id=1016,Name = "Feta",Price = 5},
                        new Ingridient{Id=1017,Name = "Olives",Price = 5}
                    })
                },
                new Salad
                {
                    Id=2,
                    Name = "King",
                    ingridients = new List<Ingridient>
                    {
                        new Ingridient
                        {
                            Id=1018,
                            Name = "Brokkoli",
                            Price = 3
                        },
                        new Ingridient
                        {
                            Id=1019,
                            Name = "Colour cabbage",
                            Price = 2
                        },
                        new Ingridient
                        {
                            Id=1020,
                            Name = "Carrot",
                            Price = 1
                        }
                    },
                    Price = CalculateDishPrice(new List<Ingridient>
                    {
                        new Ingridient{Id=1021,Name = "Brokkoli",Price = 3},
                        new Ingridient{Id=1022,Name = "Colour cabbage",Price = 2},
                        new Ingridient{Id=1023,Name = "Carrot",Price = 1}
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
                    Id = 1,
                    Name = "Dragon",
                    ingridients = new List<Ingridient>
                    {
                        new Ingridient
                        {
                            Id=1024,
                            Name = "Salmon",
                            Price = 7
                        },
                        new Ingridient
                        {
                            Id=1025,
                            Name = "Rise",
                            Price = 1
                        },
                        new Ingridient
                        {

                            Id=1026,
                            Name = "Tune",
                            Price = 5
                        },
                        new Ingridient
                        {

                            Id=1027,
                            Name = "Sesame",
                            Price= 6
                        }
                    },
                    Price = CalculateDishPrice(new List<Ingridient>
                    {
                        new Ingridient{Id=1028,Name = "Salmon",Price = 7},
                        new Ingridient{Id=1029,Name = "Rise",Price = 1 },
                        new Ingridient{Id=1030,Name = "Tune",Price = 5},
                        new Ingridient{Id=1031,Name = "Sesame",Price = 6}
                    })
                },
                new Sushi
                {
                    Id = 2,
                    Name = "Gold Dragon",
                    ingridients = new List<Ingridient>
                    {
                        new Ingridient
                        {
                            Id=1032,
                            Name = "Salmon",
                            Price = 7
                        },
                        new Ingridient
                        {

                            Id=1033,
                            Name = "Rise",
                            Price = 1
                        },
                        new Ingridient
                        {
                            Id=1034,
                            Name = "Tune",
                            Price = 5
                        },
                        new Ingridient
                        {

                            Id=1035,
                            Name = "Sesame",
                            Price= 6
                        },
                        new Ingridient
                        {

                            Id=1036,
                            Name = "Cucumber",
                            Price= 4
                        }
                    },
                    Price = CalculateDishPrice(new List<Ingridient>
                    {
                        new Ingridient{Id=1037,Name = "Salmon",Price = 7},
                        new Ingridient{Id=1038,Name = "Rise",Price = 1 },
                        new Ingridient{Id=1039,Name = "Tune",Price = 5},
                        new Ingridient{Id=1040,Name = "Sesame",Price = 6},
                        new Ingridient{Id=1041,Name = "Cucumber",Price = 4}
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
