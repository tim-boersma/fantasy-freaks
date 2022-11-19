using Fantasy_Freaks.Models;
using Microsoft.EntityFrameworkCore;

namespace Fantasy_Freaks
{
    public class FantasyDataContext : DbContext
    {
        public FantasyDataContext()
        {
        }

        public FantasyDataContext(DbContextOptions<FantasyDataContext> options) : base(options)
        {
        }

        public DbSet<DefenseDataModel> Defense { get; set; }
        public DbSet<LastSeasonPlayerDataModel> LastSeasonPlayer { get; set; }
        public DbSet<PlayerDataModel> Week1Player { get; set; }
        public DbSet<PlayerDataModel> Week2Player { get; set; }
        public DbSet<PlayerDataModel> Week3Player { get; set; }
        public DbSet<PlayerDataModel> Week4Player { get; set; }
        public DbSet<PlayerDataModel> Week5Player { get; set; }
        public DbSet<PlayerDataModel> Week6Player { get; set; }
        public DbSet<PlayerDataModel> Week7Player { get; set; }
        public DbSet<PlayerDataModel> Week8Player { get; set; }
        public DbSet<PlayerDataModel> Week9Player { get; set; }
        public DbSet<PlayerDataModel> Week10Player { get; set; }
        public DbSet<PlayerDataModel> Week11Player { get; set; }
        public DbSet<PlayerDataModel> Week12Player { get; set; }
        public DbSet<PlayerDataModel> Week13Player { get; set; }
        public DbSet<PlayerDataModel> Week14Player { get; set; }
        public DbSet<PlayerDataModel> Week15Player { get; set; }
        public DbSet<PlayerDataModel> Week16Player { get; set; }
        public DbSet<PlayerDataModel> Week17Player { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DefenseDataModel>().ToTable("Defense");
            modelBuilder.Entity<LastSeasonPlayerDataModel>().ToTable("LastSeasonPlayer");
            for(int i = 1; i <= 17; i++)
            {
                modelBuilder.Entity<PlayerDataModel>().ToTable("Week" + i + "Player");
            }

        }
    }
}
