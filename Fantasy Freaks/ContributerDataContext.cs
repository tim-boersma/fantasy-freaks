using Microsoft.EntityFrameworkCore;

namespace Fantasy_Freaks
{
    public class ContributerDataContext : DbContext
    {
        public ContributerDataContext()
        {
        }

        public ContributerDataContext(DbContextOptions<ContributerDataContext> options) : base(options)
        {
        }

        public DbSet<ContributerDataModel> Contributer { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ContributerDataModel>().ToTable("Contributer");
        }
    }
}
