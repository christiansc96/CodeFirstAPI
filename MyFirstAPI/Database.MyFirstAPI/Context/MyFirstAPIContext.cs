using Database.MyFirstAPI.DBModels;
using Microsoft.EntityFrameworkCore;

namespace Database.MyFirstAPI.Context
{
    public class MyFirstAPIContext : DbContext
    {
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Presentations> Presentations { get; set; }
        public DbSet<Products> Products { get; set; }
    }
}