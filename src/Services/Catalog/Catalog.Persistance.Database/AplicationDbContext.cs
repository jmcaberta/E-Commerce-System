using Catalog.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog.Persistance.Database
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(
            DbContextOptions<AplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductInStock> Stocks { get; set; }
    }
}
