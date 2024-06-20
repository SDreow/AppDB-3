using System.Data.Entity;

namespace App_DB_3.Model
{
    public partial class App3DbContext : DbContext
    {
        public App3DbContext() : base("name=App3Entities")
        {
        }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<Brands> Brands { get; set; }
        public virtual DbSet<Store> Store { get; set; }
    }
}
