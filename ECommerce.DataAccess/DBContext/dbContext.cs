using ECommerce.Models.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DataAccess.DBContext
{
    public class dbContext : DbContext
    {
        public dbContext(DbContextOptions<dbContext> option) : base(option)
        {
        }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "Action", DisplayOrder = 1 },
                new Category { CategoryId = 2, Name = "Adventure", DisplayOrder = 2 },
                new Category { CategoryId = 3, Name = "Comedy", DisplayOrder = 3 },
                new Category { CategoryId = 4, Name = "Horror", DisplayOrder = 4 },
                new Category { CategoryId = 5, Name = "Thriller", DisplayOrder = 5 }
            );
        }
    }
}
