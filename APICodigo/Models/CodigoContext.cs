using Microsoft.EntityFrameworkCore;

namespace APICodigo.Models
{
    public class CodigoContext : DbContext
    {
        public CodigoContext(DbContextOptions<CodigoContext> options)
            : base(options)
        {
        }

        public DbSet<Person> People { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
    

}
