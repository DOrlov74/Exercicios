using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_exercicio1.Models
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BDProdutos_ex1;Integrated Security=True");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Produto> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>().HasData(
                new Produto() { Id = 1, Name = "apple", Price = 1.69M},
                new Produto() { Id = 2, Name = "pear", Price = 1.99M},
                new Produto() { Id = 3, Name = "cola", Price = 2.0M}
            );
            base.OnModelCreating(modelBuilder);
        }
    }
}
