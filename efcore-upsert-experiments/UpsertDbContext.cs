using Microsoft.EntityFrameworkCore;

namespace efcore_upsert_experiments
{
    public class UpsertDbContext : DbContext
    {
        public DbSet<TSomething> TSomethings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\.;Initial Catalog=upserter;Integrated Security=True;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
