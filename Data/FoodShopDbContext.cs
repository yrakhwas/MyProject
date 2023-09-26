using Microsoft.EntityFrameworkCore;
using MyProject.Data.Entities;
using MyProject.Data.Helpers;

namespace MyProject.Data
{
    public class FoodShopDbContext:DbContext
    {
        public FoodShopDbContext()
        {
           // this.Database.EnsureCreated();
        }
        public DbSet<Establishment> establishments { get; set; }
        public DbSet<Ingridient> ingridients { get; set;}
        public DbSet<Pizza> pizza { get; set; }
        public DbSet<Salad> salads { get; set; }
        public DbSet<Sushi> sushi { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-OTNHA5J\SQLEXPRESS;
                                          Initial Catalog=FoodShopDb;
                                          Integrated Security=True;
                                          Connect Timeout=30;
                                          Encrypt=False;
                                          Trust Server Certificate=False;
                                          Application Intent=ReadWrite;
                                          MultiSubnetFailover=False");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Establishment>().HasKey(e => e.Id);
            modelBuilder.Entity<Establishment>().Property(e => e.Id).ValueGeneratedOnAdd().UseIdentityColumn();
            modelBuilder.Entity<Establishment>().Property(e => e.Name).IsRequired();
            modelBuilder.Entity<Establishment>().Property(e => e.Adress).IsRequired();
            modelBuilder.Entity<PizzaIngridient>()
        .HasKey(pi => new { pi.PizzaId, pi.IngridientId });



            modelBuilder.Entity<Ingridient>().HasKey(i=> i.Id);
            modelBuilder.Entity<Ingridient>().Property(i => i.Id).ValueGeneratedOnAdd().UseIdentityColumn();
            modelBuilder.Entity<Ingridient>().Property(i => i.Name).IsRequired();
            modelBuilder.Entity<Ingridient>().Property(i => i.Price).IsRequired();


            modelBuilder.Entity<Pizza>().HasKey(p => p.Id);
            modelBuilder.Entity<Pizza>().Property(p => p.Id).ValueGeneratedOnAdd().UseIdentityColumn();
            modelBuilder.Entity<Pizza>().Property(p => p.Name).IsRequired();
            modelBuilder.Entity<Pizza>().Property(p => p.Price).IsRequired();

            modelBuilder.Entity<Salad>().HasKey(s=> s.Id);
            modelBuilder.Entity<Salad>().Property(p => p.Id).ValueGeneratedOnAdd().UseIdentityColumn();
            modelBuilder.Entity<Salad>().Property(p => p.Name).IsRequired();
            modelBuilder.Entity<Salad>().Property(p => p.Price).IsRequired();



            modelBuilder.Entity<Sushi>().HasKey(sush=>sush.Id);
            modelBuilder.Entity<Sushi>().Property(p => p.Id).ValueGeneratedOnAdd().UseIdentityColumn();
            modelBuilder.Entity<Sushi>().Property(p => p.Name).IsRequired();
            modelBuilder.Entity<Sushi>().Property(p => p.Price).IsRequired();


            modelBuilder.Entity<Establishment>().HasMany(e => e.pizzas);
            modelBuilder.Entity<Establishment>().HasMany(e => e.salads);
            modelBuilder.Entity<Establishment>().HasMany(e => e.sushis);


            modelBuilder.Entity<Ingridient>().HasMany(i => i.pizzas);
            modelBuilder.Entity<Ingridient>().HasMany(i => i.salads);
            modelBuilder.Entity<Ingridient>().HasMany(i => i.sushis);

            modelBuilder.Entity<Pizza>().HasMany(p => p.ingridients).WithMany(p => p.pizzas);
            modelBuilder.Entity<Sushi>().HasMany(s => s.ingridients).WithMany(s => s.sushis);
            modelBuilder.Entity<Salad>().HasMany(sal => sal.ingridients).WithMany(sal => sal.salads);


            modelBuilder.Entity<PizzaIngridient>()
        .HasOne(pi => pi.Pizza)
        .WithMany(p => p.PizzaIngridients)
        .HasForeignKey(pi => pi.PizzaId);

    modelBuilder.Entity<PizzaIngridient>()
        .HasOne(pi => pi.Ingridient)
        .WithMany(i => i.PizzaIngridients)
        .HasForeignKey(pi => pi.IngridientId);

            modelBuilder.SeedEstablishment();
            modelBuilder.SeedIngridients();
            modelBuilder.SeedPizza();
            modelBuilder.SeedSalad();
            modelBuilder.SeedSushi();

        }

    }
}
