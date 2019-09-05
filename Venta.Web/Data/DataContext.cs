using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Venta.Web.Data.Entities;
using Venta.Web.Data.Entities.Selles;
using Venta.Web.Data.Entities.Users;

namespace Venta.Web.Data
{
    public class DataContext : IdentityDbContext<User>
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Bill> Bills { get; set; }
        public DbSet<BillCategory> BillCategories { get; set; }
        public DbSet<BillType> BillTypes { get; set; }
        public DbSet<BillDetails> BillDetails { get; set; }
        public DbSet<Serialization> Serializations { get; set; }


        public DbSet<Customer> Customers { get; set; }
        public DbSet<employee> Employees { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<Seller> Sellers { get; set; }
        public DbSet<UserImage> UserImages  { get; set; }
        public DbSet<Serializer> Serializers { get; set; }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<ProductInventary> ProductInventaries { get; set; }
        public DbSet<ProductMarca> ProductMarcas { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }

    }
}
