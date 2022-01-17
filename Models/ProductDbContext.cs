using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Ecrap.Models
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext() : base("DefaultConnection")
        {

        }
        public DbSet<Product> Producttable { get; set; }
    }
}