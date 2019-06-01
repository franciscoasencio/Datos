namespace Common.Models
{
    using System.Data.Entity;

    public class DataContext : DbContext
    {

        public DataContext() : base("Somee")
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}
