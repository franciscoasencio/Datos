namespace Common.Models
{
    using System.Data.Entity;

    public class DataContext : DbContext
    {

        public DataContext() : base("Somee")
        {

        }

        public System.Data.Entity.DbSet<Common.Models.Product> Products { get; set; }
    }
}
