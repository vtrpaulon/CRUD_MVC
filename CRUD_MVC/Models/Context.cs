using Microsoft.EntityFrameworkCore;

namespace CRUD_MVC.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) :base(options)
        {
        }

        public DbSet<Produto> Produto { get; set; }
    }
}
